using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZLB_Zutai.HelperClass;
using ZLB_Zutai.Model;
using ZLB_Zutai.Services;
using ToolBox;
using WeifenLuo.WinFormsUI.Docking;

namespace ZLB_Zutai
{
    public partial class MainForm : Form
    {
        private bool m_bSaveLayout = true;
        private DeserializeDockContent m_deserializeDockContent;
        private DummySolutionExplorer m_solutionExplorer;
        private DummyPropertyWindow m_propertyWindow;
        private DummyToolbox m_toolbox;
        private DummyOutputWindow m_outputWindow;
        private DummyTaskList m_taskList;
        private bool _showSplash;
        private SplashScreen _splashScreen;
        MenuCommandService _menuCommandService;
        public List<PageMoel> pages = GolableInstance.PageList();
        bool _ShouldUpdateSelectableObjects = false;

        bool inUpdate = false;

        private PageMoel ActivPage;
        private CustomToolboxService _toolboxService;

        public MainForm()
        {
            InitializeComponent();
            //this.dockPanel = GolableInstance.GetDockPanel();
            AutoScaleMode = AutoScaleMode.Dpi;

          
            //SetSplashScreen();
            CreateStandardControls();
          

            showRightToLeft.Checked = (RightToLeft == RightToLeft.Yes);
            RightToLeftLayout = showRightToLeft.Checked;
            m_solutionExplorer.RightToLeftLayout = RightToLeftLayout;
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            
            vsToolStripExtender1.DefaultRenderer = _toolStripProfessionalRenderer;
            SetSchema(this.menuItemSchemaVS2013Blue, null);
            ActivPage = GolableInstance.GetActiPage();
            ToolBoxSelect();
        }

        private void ToolBoxSelect()
        {
            _toolboxService = new CustomToolboxService();
            // 选中不同的工具条项目
            m_toolbox.toolBox.SelectedItemChanged += delegate (object sender, ToolBoxItem newItem)
            {
                _toolboxService.SetSelectedToolboxItem(newItem.Tag as System.Drawing.Design.ToolboxItem);
            };

            // 双击工具栏项目时增加到设计器中
            m_toolbox.toolBox.ItemDoubleClicked += delegate (object sender, ToolBoxItem newItem)
            {
                System.Drawing.Design.ToolboxItem toolboxItem = newItem.Tag as System.Drawing.Design.ToolboxItem;
                if (null != toolboxItem &&  ActivPage.surFace!=null)
                {
                    IToolboxUser toolboxUser = ActivPage.host.GetDesigner(ActivPage.host.RootComponent as IComponent) as IToolboxUser;
                    if (null != toolboxUser)
                        toolboxUser.ToolPicked(toolboxItem);
                }

            };

            // 拖动工具栏项目的支持代码
            m_toolbox.toolBox.ItemDragStart += delegate (object sender, ToolBoxItem newItem)
            {
                System.Drawing.Design.ToolboxItem toolboxItem = newItem.Tag as System.Drawing.Design.ToolboxItem;
                if (null != toolboxItem)
                {
                    DataObject dataObject = ((IToolboxService)_toolboxService).SerializeToolboxItem(toolboxItem) as DataObject;
                    m_toolbox.toolBox.DoDragDrop(dataObject, DragDropEffects.Copy);
                }
            };
            _toolboxService.ResetToolboxItem += delegate
            {
                m_toolbox.toolBox.ResetSelection();
            };

           

        }
        #region Methods

        private IDockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;

                return null;
            }
            else
            {
                foreach (IDockContent content in dockPanel.Documents)
                    if (content.DockHandler.TabText == text)
                        return content;

                return null;
            }
          
        }

        #region 中间文档操作
        private void  CreateNewDocument()
        {

        

            pages = GolableInstance.PageList();
         
            string text=string.Empty ;
            AddPageDialog addPage=new AddPageDialog();

            addPage.btnAdd.Click += (o, args) =>
            {
                text = Regex.Replace(addPage.txtInput.Text, @"(?<!\\)\\f", "\f");
                m_solutionExplorer.AddNode(text);

                addPage.Close();

            };
            addPage.ShowDialog();
            addPage.txtInput.Select();
         

            DesignWorkbench dummyDoc = new DesignWorkbench(text);
         

            ActivPage = pages[pages.Count - 1];//刚生成的页面作为活动页面

           
            dummyDoc.Text = text;
            PropertyInit();
            ActivPage.selectionService.SelectionChanged += new EventHandler(selectionService_SelectionChanged);

            ActivPage.componentChangeService.ComponentAdded += ComponentListChanged;
            ActivPage.componentChangeService.ComponentRemoved += ComponentListChanged;
            ActivPage.componentChangeService.ComponentRename += ComponentListChanged;
            ActivPage.host.TransactionClosed += new DesignerTransactionCloseEventHandler(TransactionClosed);

            ++GolableInstance.Pagecount;
            UpdateComboBox();



            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                dummyDoc.MdiParent = this;
                dummyDoc.Show();
            }
            else
                dummyDoc.Show(dockPanel);
        }
     


        void TransactionClosed(object sender, DesignerTransactionCloseEventArgs e)
        {
            if (_ShouldUpdateSelectableObjects)
            {
                m_propertyWindow.BeginInvoke(new MethodInvoker(UpdateComboBox));
                _ShouldUpdateSelectableObjects = false;
            }
        }
        void UpdateComboBox()
        {
            inUpdate = true;
            m_propertyWindow.cmbControls.Items.Clear();
            ICollection collect =ActivPage.host.Container.Components;
            if (null != collect)
            {
                foreach (object obj in collect)
                    m_propertyWindow.cmbControls.Items.Add(obj);
            }

            selectionService_SelectionChanged(null, null);
            inUpdate = false;
        }

        void ComponentListChanged(object sender, EventArgs e)
        {
            _ShouldUpdateSelectableObjects = true;
        }
        #region  创建页面时候加载默认属性窗口

        private void PropertyInit()
        {
            if (GolableInstance.Pagecount>0)
            {
                m_propertyWindow._propertyGrid.SelectedObject = ActivPage.surFace.ComponentContainer.Components[0];

                m_propertyWindow._propertyGrid.Site = (new IDEContainer(ActivPage.host)).CreateSite(m_propertyWindow._propertyGrid);
                m_propertyWindow._propertyGrid.PropertyTabs.AddTabType(typeof(System.Windows.Forms.Design.EventsTab), PropertyTabScope.Document);
            }

        }



        #region SelectService

        void selectionService_SelectionChanged(object sender, EventArgs e)
        {
            object[] selection = new object[ActivPage.selectionService.SelectionCount];
            ActivPage.selectionService.GetSelectedComponents().CopyTo(selection, 0);
            m_propertyWindow._propertyGrid.SelectedObjects = selection;
            if (ActivPage.selectionService.SelectionCount > 1)
                SetAlignMenuEnabled(true);
            else
                SetAlignMenuEnabled(false);
            SelectedObjectsChanged(m_propertyWindow.cmbControls, m_propertyWindow._propertyGrid);
        }

        void SelectedObjectsChanged(ComboBox cmbControls, PropertyGrid propertyGrid)
        {
            inUpdate = true;
            object[] objs = propertyGrid.SelectedObjects;
            if (null != objs && objs.Length == 1)
            {
                for (int i = 0; i < cmbControls.Items.Count; i++)
                    if (objs[0] == cmbControls.Items[i])
                    {
                        cmbControls.SelectedIndex = i;
                        break;
                    }
            }
            else
                cmbControls.SelectedIndex = -1;
            inUpdate = false;
        }

        void SetAlignMenuEnabled(bool bEnable)
        {
            tsmiLeft.Enabled = bEnable;
            tsmiCenter.Enabled = bEnable;
            tsmiRight.Enabled = bEnable;
            tsmiTop.Enabled = bEnable;
            tsmiMiddle.Enabled = bEnable;
            tsmiBottom.Enabled = bEnable;
        }


        #endregion
        #endregion

     

        private void CloseAllDocuments()
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    form.Close();
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    // IMPORANT: dispose all panes.
                    document.DockHandler.DockPanel = null;
                    document.DockHandler.Close();
                }
            }
        }

        private DesignWorkbench CreateNewDocument(string text)
        {
            DesignWorkbench dummyDoc = new DesignWorkbench(text);
            dummyDoc.Text = text;
            return dummyDoc;
        }
        #endregion

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(DummySolutionExplorer).ToString())
                return m_solutionExplorer;
            else if (persistString == typeof(DummyPropertyWindow).ToString())
                return m_propertyWindow;
            else if (persistString == typeof(DummyToolbox).ToString())
                return m_toolbox;
            else if (persistString == typeof(DummyOutputWindow).ToString())
                return m_outputWindow;
            else if (persistString == typeof(DummyTaskList).ToString())
                return m_taskList;
            else
            {
                // DummyDoc overrides GetPersistString to add extra information into persistString.
                // Any DockContent may override this value to add any needed information for deserialization.

                string[] parsedStrings = persistString.Split(new char[] { ',' });
                if (parsedStrings.Length != 3)
                    return null;

                if (parsedStrings[0] != typeof(DesignWorkbench).ToString())
                    return null;
                DesignWorkbench dummyDoc;

                if (parsedStrings[1] != string.Empty)
                {
                     dummyDoc = new DesignWorkbench(parsedStrings[1]);
                    dummyDoc.FileName = parsedStrings[1];
                    return dummyDoc;
                }
                  
                if (parsedStrings[2] != string.Empty)

                {
                     dummyDoc = new DesignWorkbench( parsedStrings[2]);
                    dummyDoc.Text = parsedStrings[2];
                    return dummyDoc;
                }

                return null;
            }
        }

        private void CloseAllContents()
        {
            // we don't want to create another instance of tool window, set DockPanel to null
            m_solutionExplorer.DockPanel = null;
            m_propertyWindow.DockPanel = null;
            m_toolbox.DockPanel = null;
            m_outputWindow.DockPanel = null;
            m_taskList.DockPanel = null;

            // Close all other document windows
            CloseAllDocuments();

            // IMPORTANT: dispose all float windows.
            foreach (var window in dockPanel.FloatWindows.ToList())
                window.Dispose();

            System.Diagnostics.Debug.Assert(dockPanel.Panes.Count == 0);
            System.Diagnostics.Debug.Assert(dockPanel.Contents.Count == 0);
            System.Diagnostics.Debug.Assert(dockPanel.FloatWindows.Count == 0);
        }

        private readonly ToolStripRenderer _toolStripProfessionalRenderer = new ToolStripProfessionalRenderer();
        
        private void SetSchema(object sender, System.EventArgs e)
        {
            // Persist settings when rebuilding UI
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.temp.config");

            dockPanel.SaveAsXml(configFile);
            CloseAllContents();

            if (sender == this.menuItemSchemaVS2005)
            {
                this.dockPanel.Theme = this.vS2005Theme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2005, vS2005Theme1);
            }
            else if (sender == this.menuItemSchemaVS2003)
            {
                this.dockPanel.Theme = this.vS2003Theme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2003, vS2003Theme1);
            }
            else if (sender == this.menuItemSchemaVS2012Light)
            {
                this.dockPanel.Theme = this.vS2012LightTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012LightTheme1);
            }
            else if (sender == this.menuItemSchemaVS2012Blue)
            {
                this.dockPanel.Theme = this.vS2012BlueTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012BlueTheme1);
            }
            else if (sender == this.menuItemSchemaVS2012Dark)
            {
                this.dockPanel.Theme = this.vS2012DarkTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2012, vS2012DarkTheme1);
            }
            else if (sender == this.menuItemSchemaVS2013Blue)
            {
                this.dockPanel.Theme = this.vS2013BlueTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013BlueTheme1);
            }
            else if (sender == this.menuItemSchemaVS2013Light)
            {
                this.dockPanel.Theme = this.vS2013LightTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013LightTheme1);
            }
            else if (sender == this.menuItemSchemaVS2013Dark)
            {
                this.dockPanel.Theme = this.vS2013DarkTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2013, vS2013DarkTheme1);
            }
            else if (sender == this.menuItemSchemaVS2015Blue)
            {
                this.dockPanel.Theme = this.vS2015BlueTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015BlueTheme1);
            }
            else if (sender == this.menuItemSchemaVS2015Light)
            {
                this.dockPanel.Theme = this.vS2015LightTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015LightTheme1);
            }
            else if (sender == this.menuItemSchemaVS2015Dark)
            {
                this.dockPanel.Theme = this.vS2015DarkTheme1;
                this.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, vS2015DarkTheme1);
            }

            menuItemSchemaVS2005.Checked = (sender == menuItemSchemaVS2005);
            menuItemSchemaVS2003.Checked = (sender == menuItemSchemaVS2003);
            menuItemSchemaVS2012Light.Checked = (sender == menuItemSchemaVS2012Light);
            menuItemSchemaVS2012Blue.Checked = (sender == menuItemSchemaVS2012Blue);
            menuItemSchemaVS2012Dark.Checked = (sender == menuItemSchemaVS2012Dark);
            menuItemSchemaVS2013Light.Checked = (sender == menuItemSchemaVS2013Light);
            menuItemSchemaVS2013Blue.Checked = (sender == menuItemSchemaVS2013Blue);
            menuItemSchemaVS2013Dark.Checked = (sender == menuItemSchemaVS2013Dark);
            menuItemSchemaVS2015Light.Checked = (sender == menuItemSchemaVS2015Light);
            menuItemSchemaVS2015Blue.Checked = (sender == menuItemSchemaVS2015Blue);
            menuItemSchemaVS2015Dark.Checked = (sender == menuItemSchemaVS2015Dark);
            if (dockPanel.Theme.ColorPalette != null)
            {
                statusBar.BackColor = dockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background;
            }

            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        private void EnableVSRenderer(VisualStudioToolStripExtender.VsVersion version, ThemeBase theme)
        {
            vsToolStripExtender1.SetStyle(mainMenu, version, theme);
            vsToolStripExtender1.SetStyle(toolBar, version, theme);
            vsToolStripExtender1.SetStyle(statusBar, version, theme);
        }

        private void SetDocumentStyle(object sender, System.EventArgs e)
        {
            DocumentStyle oldStyle = dockPanel.DocumentStyle;
            DocumentStyle newStyle;
            if (sender == menuItemDockingMdi)
                newStyle = DocumentStyle.DockingMdi;
            else if (sender == menuItemDockingWindow)
                newStyle = DocumentStyle.DockingWindow;
            else if (sender == menuItemDockingSdi)
                newStyle = DocumentStyle.DockingSdi;
            else
                newStyle = DocumentStyle.SystemMdi;

            if (oldStyle == newStyle)
                return;

            if (oldStyle == DocumentStyle.SystemMdi || newStyle == DocumentStyle.SystemMdi)
                CloseAllDocuments();

            dockPanel.DocumentStyle = newStyle;
            menuItemDockingMdi.Checked = (newStyle == DocumentStyle.DockingMdi);
            menuItemDockingWindow.Checked = (newStyle == DocumentStyle.DockingWindow);
            menuItemDockingSdi.Checked = (newStyle == DocumentStyle.DockingSdi);
            menuItemSystemMdi.Checked = (newStyle == DocumentStyle.SystemMdi);
        
            menuItemLayoutByXml.Enabled = (newStyle != DocumentStyle.SystemMdi);
            toolBarButtonLayoutByCode.Enabled = (newStyle != DocumentStyle.SystemMdi);
            toolBarButtonLayoutByXml.Enabled = (newStyle != DocumentStyle.SystemMdi);
        }

        #endregion

        #region Event Handlers

        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void menuItemSolutionExplorer_Click(object sender, System.EventArgs e)
        {
            m_solutionExplorer.Show(dockPanel);
        }

        private void menuItemPropertyWindow_Click(object sender, System.EventArgs e)
        {
            m_propertyWindow.Show(dockPanel);
        }

        private void menuItemToolbox_Click(object sender, System.EventArgs e)
        {
            m_toolbox.Show(dockPanel);
        }

        private void menuItemOutputWindow_Click(object sender, System.EventArgs e)
        {
            m_outputWindow.Show(dockPanel);
        }

        private void menuItemTaskList_Click(object sender, System.EventArgs e)
        {
            m_taskList.Show(dockPanel);
        }

        private void menuItemAbout_Click(object sender, System.EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog(this);
        }

        private void menuItemNew_Click(object sender, System.EventArgs e)
        {
             CreateNewDocument();
          
        }

        private void menuItemOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = Application.ExecutablePath;
            openFile.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fullName = openFile.FileName;
                string fileName = Path.GetFileName(fullName);

                if (FindDocument(fileName) != null)
                {
                    MessageBox.Show("该文档: " + fileName + " 已经打开");
                    return;
                }

                DesignWorkbench dummyDoc = new DesignWorkbench(fileName);
                dummyDoc.Text = fileName;
                if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    dummyDoc.MdiParent = this;
                    dummyDoc.Show();
                }
                else
                    dummyDoc.Show(dockPanel);
                try
                {
                    dummyDoc.FileName = fullName;
                }
                catch (Exception exception)
                {
                    dummyDoc.Close();
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void menuItemFile_Popup(object sender, System.EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                menuItemClose.Enabled = 
                    menuItemCloseAll.Enabled =
                    menuItemCloseAllButThisOne.Enabled = (ActiveMdiChild != null);
            }
            else
            {
                menuItemClose.Enabled = (dockPanel.ActiveDocument != null);
                menuItemCloseAll.Enabled =
                    menuItemCloseAllButThisOne.Enabled = (dockPanel.DocumentsCount > 0);
            }
        }

        private void menuItemClose_Click(object sender, System.EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                ActiveMdiChild.Close();
            else if (dockPanel.ActiveDocument != null)
                dockPanel.ActiveDocument.DockHandler.Close();
        }

        private void menuItemCloseAll_Click(object sender, System.EventArgs e)
        {
            CloseAllDocuments();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

            if (File.Exists(configFile))
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            if (m_bSaveLayout)
                dockPanel.SaveAsXml(configFile);
            else if (File.Exists(configFile))
                File.Delete(configFile);
        }

        private void menuItemToolBar_Click(object sender, System.EventArgs e)
        {
            toolBar.Visible = menuItemToolBar.Checked = !menuItemToolBar.Checked;
        }

        private void menuItemStatusBar_Click(object sender, System.EventArgs e)
        {
            statusBar.Visible = menuItemStatusBar.Checked = !menuItemStatusBar.Checked;
        }

        private void toolBar_ButtonClick(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolBarButtonNew)
                menuItemNew_Click(null, null);
            else if (e.ClickedItem == toolBarButtonOpen)
                menuItemOpen_Click(null, null);
            else if (e.ClickedItem == toolBarButtonSolutionExplorer)
                menuItemSolutionExplorer_Click(null, null);
            else if (e.ClickedItem == toolBarButtonPropertyWindow)
                menuItemPropertyWindow_Click(null, null);
            else if (e.ClickedItem == toolBarButtonToolbox)
                menuItemToolbox_Click(null, null);
            else if (e.ClickedItem == toolBarButtonOutputWindow)
                menuItemOutputWindow_Click(null, null);
            else if (e.ClickedItem == toolBarButtonTaskList)
                menuItemTaskList_Click(null, null);
         
            else if (e.ClickedItem == toolBarButtonLayoutByXml)
                menuItemLayoutByXml_Click(null, null);
            else if (e.ClickedItem==toolBarButtonSave)
            {
                menuItemSave_Click(null,null);
            }
        }

        private void menuItemNewWindow_Click(object sender, System.EventArgs e)
        {
            MainForm newWindow = new MainForm();
            newWindow.Text = newWindow.Text + " - New";
            newWindow.Show();
        }

        private void menuItemTools_Popup(object sender, System.EventArgs e)
        {
            menuItemLockLayout.Checked = !this.dockPanel.AllowEndUserDocking;
        }

        private void menuItemLockLayout_Click(object sender, System.EventArgs e)
        {
            dockPanel.AllowEndUserDocking = !dockPanel.AllowEndUserDocking;
        }

 

        private void SetSplashScreen()
        {
            
            _showSplash = true;
            _splashScreen = new SplashScreen();

            ResizeSplash();
            _splashScreen.Visible = true;
            _splashScreen.TopMost = true;

            Timer _timer = new Timer();
            _timer.Tick += (sender, e) =>
            {
                _splashScreen.Visible = false;
                _timer.Enabled = false;
                _showSplash = false;
            };
            _timer.Interval = 10;
            _timer.Enabled = true;
        }

        private void ResizeSplash()
        {
            if (_showSplash) {
                
            var centerXMain = (this.Location.X + this.Width) / 2.0;
            var LocationXSplash = Math.Max(0, centerXMain - (_splashScreen.Width / 2.0));

            var centerYMain = (this.Location.Y + this.Height) / 2.0;
            var LocationYSplash = Math.Max(0, centerYMain - (_splashScreen.Height / 2.0));

            _splashScreen.Location = new Point((int)Math.Round(LocationXSplash), (int)Math.Round(LocationYSplash));
            }
        }

        private void CreateStandardControls()
        {
         
            m_solutionExplorer = new DummySolutionExplorer();

            m_solutionExplorer.newPanel+=new NewPanel(CreateNewDocument);
            m_solutionExplorer.activePanel+= new ActivePanel(SetPanelActive);

                m_propertyWindow = new DummyPropertyWindow();

         
            //UpdateProperty();
            m_toolbox = new DummyToolbox();
            m_outputWindow = new DummyOutputWindow();
            m_taskList = new DummyTaskList();
        }

        private void SetPanelActive(PageMoel page)
        {
          
            foreach (var item in this.dockPanel.Documents)
            {
                if (item is DesignWorkbench)
                {
                    DesignWorkbench workbench = item as DesignWorkbench;
                    if (workbench.pageGuid == page.PageGuid)
                    {
                        workbench.Activate();
                    }
                }
            }
        }


        private void menuItemLayoutByXml_Click(object sender, System.EventArgs e)
        {
            dockPanel.SuspendLayout(true);

            // In order to load layout from XML, we need to close all the DockContents
            CloseAllContents();

            CreateStandardControls();

            Assembly assembly = Assembly.GetAssembly(typeof(MainForm));
            Stream xmlStream = assembly.GetManifestResourceStream("DockSample.Resources.DockPanel.xml");
            dockPanel.LoadFromXml(xmlStream, m_deserializeDockContent);
            xmlStream.Close();

            dockPanel.ResumeLayout(true, true);
        }

        private void menuItemCloseAllButThisOne_Click(object sender, System.EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                Form activeMdi = ActiveMdiChild;
                foreach (Form form in MdiChildren)
                {
                    if (form != activeMdi)
                        form.Close();
                }
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    if (!document.DockHandler.IsActivated)
                        document.DockHandler.Close();
                }
            }
        }

        private void menuItemShowDocumentIcon_Click(object sender, System.EventArgs e)
        {
            dockPanel.ShowDocumentIcon = menuItemShowDocumentIcon.Checked = !menuItemShowDocumentIcon.Checked;
        }

        private void showRightToLeft_Click(object sender, EventArgs e)
        {
            CloseAllContents();
            if (showRightToLeft.Checked)
            {
                this.RightToLeft = RightToLeft.No;
                this.RightToLeftLayout = false;
            }
            else
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
            }
            m_solutionExplorer.RightToLeftLayout = this.RightToLeftLayout;
            showRightToLeft.Checked = !showRightToLeft.Checked;
        }

        private void exitWithoutSavingLayout_Click(object sender, EventArgs e)
        {
            m_bSaveLayout = false;
            Close();
            m_bSaveLayout = true;
        }

        #endregion

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ResizeSplash();
        }

        private void toolBarButtonLayoutByCode_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            DesignWorkbench workbench=dockPanel.ActiveContent as DesignWorkbench;
            if (workbench==null)
            {
                return;
            }
            foreach (var item in GolableInstance.PageList())
            {
                if (item.PageGuid==workbench.pageGuid)
                {
                    ActivPage = item;
                    break;
                   
                }
            }
            foreach (var item in m_solutionExplorer.treeView.Nodes.AllNodes)
            {
                if (item.Text==ActivPage.PageName)
                {
                    m_solutionExplorer.treeView.SelectedNode = item;
                    break;
                }
            }

            UpdateComboBox();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {

        }
    }
}