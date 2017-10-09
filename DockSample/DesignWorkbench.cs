using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using ZLB_Zutai.HelperClass;
using ZLB_Zutai.Model;
using ZLB_Zutai.Services;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace ZLB_Zutai
{
    public delegate void ChangeSurface();

    public partial class DesignWorkbench : DockContent
    {
        public CustomToolboxService _toolboxService;
        public IDesignerHost _host;
        public MenuCommandService _menuCommandService;
        public Loader.CodeDomHostLoader _CodeDomHostLoader;
        public Form rootComponent = null;

        public TextEditorControl _textEditor;
        public PropertyGrid _propertyGrid;

        public event ChangeSurface ChangeSur;
        public DesignSurface surface;

        internal Guid pageGuid;//与model的编号对应



        public DesignWorkbench(string  pageName)
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;

            PageMoel pm = new PageMoel();
            _propertyGrid = new PropertyGrid { Dock = DockStyle.Fill };
            pm.propertyGrid = _propertyGrid;
            pm.PageName = pageName;

            ServiceContainer serviceContainer = new ServiceContainer();
            serviceContainer.AddService(typeof(System.ComponentModel.Design.IDesignerEventService), new DesignerEventService());
            serviceContainer.AddService(typeof(System.ComponentModel.Design.Serialization.INameCreationService), new NameCreationService());
            _toolboxService = new CustomToolboxService();
            serviceContainer.AddService(typeof(IToolboxService), _toolboxService);

            surface = new DesignSurface(serviceContainer);
            _host = (IDesignerHost)surface.GetService(typeof(IDesignerHost));

            serviceContainer.AddService(typeof(System.ComponentModel.Design.IEventBindingService), new Services.EventBindingService(surface));

            _menuCommandService = new MenuCommandService(surface);
            serviceContainer.AddService(typeof(IMenuCommandService), _menuCommandService);

            //surface.BeginLoad(typeof(Form));
            _CodeDomHostLoader = new Loader.CodeDomHostLoader();
            surface.BeginLoad(_CodeDomHostLoader);

            Control designerContorl = (Control)surface.View;


            designerContorl.BackColor = Color.Aqua;
            designerContorl.Dock = DockStyle.Fill;
            //获取root组件
            var designerHost = (IDesignerHost)this._host;
            if (designerHost != null) rootComponent = (Form)designerHost.RootComponent;

            rootComponent.FormBorderStyle = FormBorderStyle.None;

            #region 初始化窗体大小

            //- set the Size
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(designerContorl);
            //- Sets a PropertyDescriptor to the specific property.
            PropertyDescriptor pdS = pdc.Find("Size", false);
            if (null != pdS)
                pdS.SetValue(_host.RootComponent, new Size(800, 480));
            #endregion
            tpDesign.Controls.Add(designerContorl);//窗体

            _textEditor = new TextEditorControl
            {
                IsReadOnly = true,
                Dock = DockStyle.Fill,
                Document = { HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#") }
            }; //代码编辑器
            tpCode.Controls.Add(_textEditor);

            _propertyGrid.SelectedObject = surface.ComponentContainer.Components[0];
            _propertyGrid.Site = (new IDEContainer(_host)).CreateSite(_propertyGrid);
            _propertyGrid.PropertyTabs.AddTabType(typeof(System.Windows.Forms.Design.EventsTab), PropertyTabScope.Document);


            pm.serviceContainer = serviceContainer;
            pm.surFace = surface;
            pageGuid=Guid.NewGuid();
            pm.PageGuid = pageGuid;
            List<PageMoel> pages = GolableInstance.PageList();
            pages.Add(pm);


            //if (ChangeSur != null) ChangeSur();
        }

        private string m_fileName = string.Empty;
        public string FileName
        {
            get { return m_fileName; }
            set
            {
                if (value != string.Empty)
                {
                    Stream s = new FileStream(value, FileMode.Open);

                    FileInfo efInfo = new FileInfo(value);

                    string fext = efInfo.Extension.ToUpper();

                    //if (fext.Equals(".RTF"))
                    //    richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText);
                    //else
                    //    richTextBox1.LoadFile(s, RichTextBoxStreamType.PlainText);
                    s.Close();
                }

                m_fileName = value;
                //this.ToolTipText = value;
            }
        }

        // workaround of RichTextbox control's bug:
        // If load file before the control showed, all the text format will be lost
        // re-load the file after it get showed.
        private bool m_resetText = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (m_resetText)
            {
                m_resetText = false;
                FileName = FileName;
            }
        }

        //protected override string GetPersistString()
        //{
        //    // Add extra information into the persist string for this document
        //    // so that it is available when deserialized.
        //    return GetType().ToString() + "," + FileName + "," + Text;
        //}



        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            //if (FileName == string.Empty)
            //    this.richTextBox1.Text = Text;
        }

        private void DesignWorkbench_Load(object sender, EventArgs e)
        {
            ChangeSur?.Invoke();
        }

      
    }
}