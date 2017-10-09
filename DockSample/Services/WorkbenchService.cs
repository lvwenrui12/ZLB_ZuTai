using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZLB_Zutai.Singleton;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace ZLB_Zutai.Services
{
   public class WorkbenchService
    {
        CustomToolboxService _toolboxService;
        IDesignerHost _host;
        MenuCommandService _menuCommandService;
        Loader.CodeDomHostLoader _CodeDomHostLoader;
        private Form rootComponent = null;

        TextEditorControl _textEditor;

        public WorkbenchService()
        {
        }

        public Control GetControl()
        {
            ServiceContainer serviceContainer = new ServiceContainer();
            serviceContainer.AddService(typeof(System.ComponentModel.Design.IDesignerEventService), new DesignerEventService());
            serviceContainer.AddService(typeof(System.ComponentModel.Design.Serialization.INameCreationService), new NameCreationService());
            _toolboxService = new CustomToolboxService();
            serviceContainer.AddService(typeof(IToolboxService), _toolboxService);

            DesignSurface surface = new DesignSurface(serviceContainer);
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
         
            return designerContorl;
        }

        public TextEditorControl GeTextEditorControl()
        {
            _textEditor = new TextEditorControl
            {
                IsReadOnly = true,
                Dock = DockStyle.Fill,
                Document = { HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#") }
            }; //代码编辑器
            return _textEditor;

        }



    }
}
