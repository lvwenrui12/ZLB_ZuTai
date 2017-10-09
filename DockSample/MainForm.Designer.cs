using WeifenLuo.WinFormsUI.Docking;
using ZLB_Zutai.Services;

namespace ZLB_Zutai
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCloseAllButThisOne = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWithoutSavingLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.对齐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMiddle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSolutionExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPropertyWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemToolbox = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOutputWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaskList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemLayoutByXml = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLockLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDockingMdi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDockingSdi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDockingWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSystemMdi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Light = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2015Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2013Light = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2013Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2013Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2012Light = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2012Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2012Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2005 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSchemaVS2003 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemShowDocumentIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showRightToLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolBarButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarButtonSolutionExplorer = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonPropertyWindow = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonToolbox = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonOutputWindow = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonTaskList = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBarButtonLayoutByCode = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonLayoutByXml = new System.Windows.Forms.ToolStripButton();
            this.toolBarButtonSave = new System.Windows.Forms.ToolStripButton();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
            this.vS2003Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2003Theme();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.vS2013LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013LightTheme();
            this.vS2013BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme();
            this.vS2013DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2013DarkTheme();
            this.vS2012LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012LightTheme();
            this.vS2012BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012BlueTheme();
            this.vS2012DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2012DarkTheme();
            this.vsToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.toolStripMenuItem3,
            this.menuItemView,
            this.menuItemTools,
            this.menuItemWindow,
            this.menuItemHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.menuItemWindow;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(579, 25);
            this.mainMenu.TabIndex = 7;
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemSave,
            this.menuItemOpen,
            this.menuItemClose,
            this.menuItemCloseAll,
            this.menuItemCloseAllButThisOne,
            this.menuItem4,
            this.menuItemExit,
            this.exitWithoutSavingLayout});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(44, 21);
            this.menuItemFile.Text = "&文件";
            this.menuItemFile.DropDownOpening += new System.EventHandler(this.menuItemFile_Popup);
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(172, 22);
            this.menuItemNew.Text = "新建";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemNew_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(172, 22);
            this.menuItemOpen.Text = "打开...";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(172, 22);
            this.menuItemClose.Text = "关闭";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItemCloseAll
            // 
            this.menuItemCloseAll.Name = "menuItemCloseAll";
            this.menuItemCloseAll.Size = new System.Drawing.Size(172, 22);
            this.menuItemCloseAll.Text = "关闭所有";
            this.menuItemCloseAll.Click += new System.EventHandler(this.menuItemCloseAll_Click);
            // 
            // menuItemCloseAllButThisOne
            // 
            this.menuItemCloseAllButThisOne.Name = "menuItemCloseAllButThisOne";
            this.menuItemCloseAllButThisOne.Size = new System.Drawing.Size(172, 22);
            this.menuItemCloseAllButThisOne.Text = "关闭其他页面";
            this.menuItemCloseAllButThisOne.Click += new System.EventHandler(this.menuItemCloseAllButThisOne_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(169, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(172, 22);
            this.menuItemExit.Text = "退出";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // exitWithoutSavingLayout
            // 
            this.exitWithoutSavingLayout.Name = "exitWithoutSavingLayout";
            this.exitWithoutSavingLayout.Size = new System.Drawing.Size(172, 22);
            this.exitWithoutSavingLayout.Text = "退出保存软件布局";
            this.exitWithoutSavingLayout.Click += new System.EventHandler(this.exitWithoutSavingLayout_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.对齐ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem3.Text = "编辑";
            // 
            // 对齐ToolStripMenuItem
            // 
            this.对齐ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLeft,
            this.tsmiRight,
            this.tsmiCenter,
            this.toolStripSeparator1,
            this.tsmiTop,
            this.tsmiBottom,
            this.tsmiMiddle});
            this.对齐ToolStripMenuItem.Name = "对齐ToolStripMenuItem";
            this.对齐ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.对齐ToolStripMenuItem.Text = "对齐";
            // 
            // tsmiLeft
            // 
            this.tsmiLeft.Name = "tsmiLeft";
            this.tsmiLeft.Size = new System.Drawing.Size(148, 22);
            this.tsmiLeft.Text = "左对齐";
            // 
            // tsmiRight
            // 
            this.tsmiRight.Name = "tsmiRight";
            this.tsmiRight.Size = new System.Drawing.Size(148, 22);
            this.tsmiRight.Text = "右对齐";
            // 
            // tsmiCenter
            // 
            this.tsmiCenter.Name = "tsmiCenter";
            this.tsmiCenter.Size = new System.Drawing.Size(148, 22);
            this.tsmiCenter.Text = "水平中间对齐";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // tsmiTop
            // 
            this.tsmiTop.Name = "tsmiTop";
            this.tsmiTop.Size = new System.Drawing.Size(148, 22);
            this.tsmiTop.Text = "顶部对齐";
            // 
            // tsmiBottom
            // 
            this.tsmiBottom.Name = "tsmiBottom";
            this.tsmiBottom.Size = new System.Drawing.Size(148, 22);
            this.tsmiBottom.Text = "底部对齐";
            // 
            // tsmiMiddle
            // 
            this.tsmiMiddle.Name = "tsmiMiddle";
            this.tsmiMiddle.Size = new System.Drawing.Size(148, 22);
            this.tsmiMiddle.Text = "垂直中间对齐";
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSolutionExplorer,
            this.menuItemPropertyWindow,
            this.menuItemToolbox,
            this.menuItemOutputWindow,
            this.menuItemTaskList,
            this.menuItem1,
            this.menuItemToolBar,
            this.menuItemStatusBar,
            this.menuItem2,
            this.menuItemLayoutByXml});
            this.menuItemView.MergeIndex = 1;
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(44, 21);
            this.menuItemView.Text = "&视图";
            // 
            // menuItemSolutionExplorer
            // 
            this.menuItemSolutionExplorer.Name = "menuItemSolutionExplorer";
            this.menuItemSolutionExplorer.Size = new System.Drawing.Size(160, 22);
            this.menuItemSolutionExplorer.Text = "解决方案管理器";
            this.menuItemSolutionExplorer.Click += new System.EventHandler(this.menuItemSolutionExplorer_Click);
            // 
            // menuItemPropertyWindow
            // 
            this.menuItemPropertyWindow.Name = "menuItemPropertyWindow";
            this.menuItemPropertyWindow.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuItemPropertyWindow.Size = new System.Drawing.Size(160, 22);
            this.menuItemPropertyWindow.Text = "属性串口";
            this.menuItemPropertyWindow.Click += new System.EventHandler(this.menuItemPropertyWindow_Click);
            // 
            // menuItemToolbox
            // 
            this.menuItemToolbox.Name = "menuItemToolbox";
            this.menuItemToolbox.Size = new System.Drawing.Size(160, 22);
            this.menuItemToolbox.Text = "工具窗口";
            this.menuItemToolbox.Click += new System.EventHandler(this.menuItemToolbox_Click);
            // 
            // menuItemOutputWindow
            // 
            this.menuItemOutputWindow.Name = "menuItemOutputWindow";
            this.menuItemOutputWindow.Size = new System.Drawing.Size(160, 22);
            this.menuItemOutputWindow.Text = "输出窗口";
            this.menuItemOutputWindow.Click += new System.EventHandler(this.menuItemOutputWindow_Click);
            // 
            // menuItemTaskList
            // 
            this.menuItemTaskList.Name = "menuItemTaskList";
            this.menuItemTaskList.Size = new System.Drawing.Size(160, 22);
            this.menuItemTaskList.Text = "任务列表";
            this.menuItemTaskList.Click += new System.EventHandler(this.menuItemTaskList_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // menuItemToolBar
            // 
            this.menuItemToolBar.Checked = true;
            this.menuItemToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemToolBar.Name = "menuItemToolBar";
            this.menuItemToolBar.Size = new System.Drawing.Size(160, 22);
            this.menuItemToolBar.Text = "工具条";
            this.menuItemToolBar.Click += new System.EventHandler(this.menuItemToolBar_Click);
            // 
            // menuItemStatusBar
            // 
            this.menuItemStatusBar.Checked = true;
            this.menuItemStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemStatusBar.Name = "menuItemStatusBar";
            this.menuItemStatusBar.Size = new System.Drawing.Size(160, 22);
            this.menuItemStatusBar.Text = "状态蓝";
            this.menuItemStatusBar.Click += new System.EventHandler(this.menuItemStatusBar_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // menuItemLayoutByXml
            // 
            this.menuItemLayoutByXml.Name = "menuItemLayoutByXml";
            this.menuItemLayoutByXml.Size = new System.Drawing.Size(160, 22);
            this.menuItemLayoutByXml.Text = "根据XML布局";
            this.menuItemLayoutByXml.Click += new System.EventHandler(this.menuItemLayoutByXml_Click);
            // 
            // menuItemTools
            // 
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLockLayout,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.menuItemShowDocumentIcon,
            this.menuItem3,
            this.menuItem6,
            this.menuItem5,
            this.showRightToLeft});
            this.menuItemTools.MergeIndex = 2;
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(44, 21);
            this.menuItemTools.Text = "&工具";
            this.menuItemTools.DropDownOpening += new System.EventHandler(this.menuItemTools_Popup);
            // 
            // menuItemLockLayout
            // 
            this.menuItemLockLayout.Name = "menuItemLockLayout";
            this.menuItemLockLayout.Size = new System.Drawing.Size(199, 22);
            this.menuItemLockLayout.Text = "锁定布局";
            this.menuItemLockLayout.Click += new System.EventHandler(this.menuItemLockLayout_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDockingMdi,
            this.menuItemDockingSdi,
            this.menuItemDockingWindow,
            this.menuItemSystemMdi});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem2.Text = "文档风格";
            // 
            // menuItemDockingMdi
            // 
            this.menuItemDockingMdi.Name = "menuItemDockingMdi";
            this.menuItemDockingMdi.Size = new System.Drawing.Size(129, 22);
            this.menuItemDockingMdi.Text = "MDI";
            this.menuItemDockingMdi.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // menuItemDockingSdi
            // 
            this.menuItemDockingSdi.Name = "menuItemDockingSdi";
            this.menuItemDockingSdi.Size = new System.Drawing.Size(129, 22);
            this.menuItemDockingSdi.Text = "SDI";
            this.menuItemDockingSdi.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // menuItemDockingWindow
            // 
            this.menuItemDockingWindow.Name = "menuItemDockingWindow";
            this.menuItemDockingWindow.Size = new System.Drawing.Size(129, 22);
            this.menuItemDockingWindow.Text = "Window";
            this.menuItemDockingWindow.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // menuItemSystemMdi
            // 
            this.menuItemSystemMdi.Name = "menuItemSystemMdi";
            this.menuItemSystemMdi.Size = new System.Drawing.Size(129, 22);
            this.menuItemSystemMdi.Text = "系统 MDI";
            this.menuItemSystemMdi.Click += new System.EventHandler(this.SetDocumentStyle);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSchemaVS2015Light,
            this.menuItemSchemaVS2015Blue,
            this.menuItemSchemaVS2015Dark,
            this.menuItemSchemaVS2013Light,
            this.menuItemSchemaVS2013Blue,
            this.menuItemSchemaVS2013Dark,
            this.menuItemSchemaVS2012Light,
            this.menuItemSchemaVS2012Blue,
            this.menuItemSchemaVS2012Dark,
            this.menuItemSchemaVS2005,
            this.menuItemSchemaVS2003});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem1.Text = "切换肤色";
            // 
            // menuItemSchemaVS2015Light
            // 
            this.menuItemSchemaVS2015Light.Name = "menuItemSchemaVS2015Light";
            this.menuItemSchemaVS2015Light.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2015Light.Text = "VS2015 Light";
            this.menuItemSchemaVS2015Light.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2015Blue
            // 
            this.menuItemSchemaVS2015Blue.Name = "menuItemSchemaVS2015Blue";
            this.menuItemSchemaVS2015Blue.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2015Blue.Text = "VS2015 Blue";
            this.menuItemSchemaVS2015Blue.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2015Dark
            // 
            this.menuItemSchemaVS2015Dark.Name = "menuItemSchemaVS2015Dark";
            this.menuItemSchemaVS2015Dark.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2015Dark.Text = "VS2015 Dark";
            this.menuItemSchemaVS2015Dark.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2013Light
            // 
            this.menuItemSchemaVS2013Light.Name = "menuItemSchemaVS2013Light";
            this.menuItemSchemaVS2013Light.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2013Light.Text = "VS2013 Light";
            this.menuItemSchemaVS2013Light.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2013Blue
            // 
            this.menuItemSchemaVS2013Blue.Name = "menuItemSchemaVS2013Blue";
            this.menuItemSchemaVS2013Blue.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2013Blue.Text = "VS2013 Blue";
            this.menuItemSchemaVS2013Blue.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2013Dark
            // 
            this.menuItemSchemaVS2013Dark.Name = "menuItemSchemaVS2013Dark";
            this.menuItemSchemaVS2013Dark.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2013Dark.Text = "VS2013 Dark";
            this.menuItemSchemaVS2013Dark.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2012Light
            // 
            this.menuItemSchemaVS2012Light.Name = "menuItemSchemaVS2012Light";
            this.menuItemSchemaVS2012Light.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2012Light.Text = "VS2012 Light";
            this.menuItemSchemaVS2012Light.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2012Blue
            // 
            this.menuItemSchemaVS2012Blue.Name = "menuItemSchemaVS2012Blue";
            this.menuItemSchemaVS2012Blue.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2012Blue.Text = "VS2012 Blue";
            this.menuItemSchemaVS2012Blue.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2012Dark
            // 
            this.menuItemSchemaVS2012Dark.Name = "menuItemSchemaVS2012Dark";
            this.menuItemSchemaVS2012Dark.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2012Dark.Text = "VS2012 Dark";
            this.menuItemSchemaVS2012Dark.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2005
            // 
            this.menuItemSchemaVS2005.Name = "menuItemSchemaVS2005";
            this.menuItemSchemaVS2005.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2005.Text = "VS200&5";
            this.menuItemSchemaVS2005.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemSchemaVS2003
            // 
            this.menuItemSchemaVS2003.Name = "menuItemSchemaVS2003";
            this.menuItemSchemaVS2003.Size = new System.Drawing.Size(151, 22);
            this.menuItemSchemaVS2003.Text = " VS200&3";
            this.menuItemSchemaVS2003.Click += new System.EventHandler(this.SetSchema);
            // 
            // menuItemShowDocumentIcon
            // 
            this.menuItemShowDocumentIcon.Name = "menuItemShowDocumentIcon";
            this.menuItemShowDocumentIcon.Size = new System.Drawing.Size(199, 22);
            this.menuItemShowDocumentIcon.Text = "&Show Document Icon";
            this.menuItemShowDocumentIcon.Click += new System.EventHandler(this.menuItemShowDocumentIcon_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(196, 6);
            // 
            // menuItem6
            // 
            this.menuItem6.Name = "menuItem6";
            this.menuItem6.Size = new System.Drawing.Size(196, 6);
            // 
            // menuItem5
            // 
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(196, 6);
            // 
            // showRightToLeft
            // 
            this.showRightToLeft.Name = "showRightToLeft";
            this.showRightToLeft.Size = new System.Drawing.Size(199, 22);
            this.showRightToLeft.Text = "Show &Right-To-Left";
            this.showRightToLeft.Click += new System.EventHandler(this.showRightToLeft_Click);
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewWindow});
            this.menuItemWindow.MergeIndex = 2;
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.Size = new System.Drawing.Size(44, 21);
            this.menuItemWindow.Text = "&窗口";
            // 
            // menuItemNewWindow
            // 
            this.menuItemNewWindow.Name = "menuItemNewWindow";
            this.menuItemNewWindow.Size = new System.Drawing.Size(153, 22);
            this.menuItemNewWindow.Text = "&New Window";
            this.menuItemNewWindow.Click += new System.EventHandler(this.menuItemNewWindow_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.MergeIndex = 3;
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 21);
            this.menuItemHelp.Text = "帮助";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(193, 22);
            this.menuItemAbout.Text = "&关于智联宝组态软件...";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Black;
            this.statusBar.Location = new System.Drawing.Point(0, 387);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(579, 22);
            this.statusBar.TabIndex = 4;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            this.imageList.Images.SetKeyName(5, "");
            this.imageList.Images.SetKeyName(6, "");
            this.imageList.Images.SetKeyName(7, "");
            this.imageList.Images.SetKeyName(8, "");
            // 
            // toolBar
            // 
            this.toolBar.ImageList = this.imageList;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarButtonNew,
            this.toolBarButtonOpen,
            this.toolBarButtonSeparator1,
            this.toolBarButtonSolutionExplorer,
            this.toolBarButtonPropertyWindow,
            this.toolBarButtonToolbox,
            this.toolBarButtonOutputWindow,
            this.toolBarButtonTaskList,
            this.toolBarButtonSeparator2,
            this.toolBarButtonLayoutByCode,
            this.toolBarButtonLayoutByXml,
            this.toolBarButtonSave});
            this.toolBar.Location = new System.Drawing.Point(0, 25);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(579, 25);
            this.toolBar.TabIndex = 6;
            this.toolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolBar_ButtonClick);
            // 
            // toolBarButtonNew
            // 
            this.toolBarButtonNew.ImageIndex = 0;
            this.toolBarButtonNew.Name = "toolBarButtonNew";
            this.toolBarButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonNew.ToolTipText = "Show Layout From XML";
            // 
            // toolBarButtonOpen
            // 
            this.toolBarButtonOpen.ImageIndex = 1;
            this.toolBarButtonOpen.Name = "toolBarButtonOpen";
            this.toolBarButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonOpen.ToolTipText = "Open";
            // 
            // toolBarButtonSeparator1
            // 
            this.toolBarButtonSeparator1.Name = "toolBarButtonSeparator1";
            this.toolBarButtonSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBarButtonSolutionExplorer
            // 
            this.toolBarButtonSolutionExplorer.ImageIndex = 2;
            this.toolBarButtonSolutionExplorer.Name = "toolBarButtonSolutionExplorer";
            this.toolBarButtonSolutionExplorer.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonSolutionExplorer.ToolTipText = "Solution Explorer";
            // 
            // toolBarButtonPropertyWindow
            // 
            this.toolBarButtonPropertyWindow.ImageIndex = 3;
            this.toolBarButtonPropertyWindow.Name = "toolBarButtonPropertyWindow";
            this.toolBarButtonPropertyWindow.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonPropertyWindow.ToolTipText = "Property Window";
            // 
            // toolBarButtonToolbox
            // 
            this.toolBarButtonToolbox.ImageIndex = 4;
            this.toolBarButtonToolbox.Name = "toolBarButtonToolbox";
            this.toolBarButtonToolbox.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonToolbox.ToolTipText = "Tool Box";
            // 
            // toolBarButtonOutputWindow
            // 
            this.toolBarButtonOutputWindow.ImageIndex = 5;
            this.toolBarButtonOutputWindow.Name = "toolBarButtonOutputWindow";
            this.toolBarButtonOutputWindow.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonOutputWindow.ToolTipText = "Output Window";
            // 
            // toolBarButtonTaskList
            // 
            this.toolBarButtonTaskList.ImageIndex = 6;
            this.toolBarButtonTaskList.Name = "toolBarButtonTaskList";
            this.toolBarButtonTaskList.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonTaskList.ToolTipText = "Task List";
            // 
            // toolBarButtonSeparator2
            // 
            this.toolBarButtonSeparator2.Name = "toolBarButtonSeparator2";
            this.toolBarButtonSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBarButtonLayoutByCode
            // 
            this.toolBarButtonLayoutByCode.ImageIndex = 7;
            this.toolBarButtonLayoutByCode.Name = "toolBarButtonLayoutByCode";
            this.toolBarButtonLayoutByCode.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonLayoutByCode.ToolTipText = "Show Layout By Code";
            this.toolBarButtonLayoutByCode.Click += new System.EventHandler(this.toolBarButtonLayoutByCode_Click);
            // 
            // toolBarButtonLayoutByXml
            // 
            this.toolBarButtonLayoutByXml.ImageIndex = 8;
            this.toolBarButtonLayoutByXml.Name = "toolBarButtonLayoutByXml";
            this.toolBarButtonLayoutByXml.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonLayoutByXml.ToolTipText = "Show layout by predefined XML file";
            // 
            // toolBarButtonSave
            // 
            this.toolBarButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBarButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolBarButtonSave.Image")));
            this.toolBarButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarButtonSave.Name = "toolBarButtonSave";
            this.toolBarButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolBarButtonSave.Text = "toolStripButton1";
            this.toolBarButtonSave.ToolTipText = "保存";
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.dockPanel.Location = new System.Drawing.Point(0, 50);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(579, 337);
            this.dockPanel.TabIndex = 0;
            this.dockPanel.ActiveDocumentChanged += new System.EventHandler(this.dockPanel_ActiveDocumentChanged);
            // 
            // vsToolStripExtender1
            // 
            this.vsToolStripExtender1.DefaultRenderer = null;
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(172, 22);
            this.menuItemSave.Text = "保存";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(579, 409);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "智联宝组态";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolBarButtonNew;
        private System.Windows.Forms.ToolStripButton toolBarButtonOpen;
        private System.Windows.Forms.ToolStripSeparator toolBarButtonSeparator1;
        private System.Windows.Forms.ToolStripButton toolBarButtonSolutionExplorer;
        private System.Windows.Forms.ToolStripButton toolBarButtonPropertyWindow;
        private System.Windows.Forms.ToolStripButton toolBarButtonToolbox;
        private System.Windows.Forms.ToolStripButton toolBarButtonOutputWindow;
        private System.Windows.Forms.ToolStripButton toolBarButtonTaskList;
        private System.Windows.Forms.ToolStripSeparator toolBarButtonSeparator2;
        private System.Windows.Forms.ToolStripButton toolBarButtonLayoutByCode;
        private System.Windows.Forms.ToolStripButton toolBarButtonLayoutByXml;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
        private System.Windows.Forms.ToolStripMenuItem menuItemCloseAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemCloseAllButThisOne;
        private System.Windows.Forms.ToolStripSeparator menuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemSolutionExplorer;
        private System.Windows.Forms.ToolStripMenuItem menuItemPropertyWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolbox;
        private System.Windows.Forms.ToolStripMenuItem menuItemOutputWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemTaskList;
        private System.Windows.Forms.ToolStripSeparator menuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemToolBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemStatusBar;
        private System.Windows.Forms.ToolStripSeparator menuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemLayoutByXml;
        private System.Windows.Forms.ToolStripMenuItem menuItemTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemLockLayout;
        private System.Windows.Forms.ToolStripSeparator menuItem3;
        private System.Windows.Forms.ToolStripSeparator menuItem6;
        private System.Windows.Forms.ToolStripSeparator menuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuItemShowDocumentIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem showRightToLeft;
        private System.Windows.Forms.ToolStripMenuItem exitWithoutSavingLayout;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2013LightTheme vS2013LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2013BlueTheme vS2013BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2013DarkTheme vS2013DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2012LightTheme vS2012LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2012BlueTheme vS2012BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2012DarkTheme vS2012DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2003Theme vS2003Theme1;
        private WeifenLuo.WinFormsUI.Docking.VS2005Theme vS2005Theme1;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender vsToolStripExtender1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Light;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2015Dark;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2013Light;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2013Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2013Dark;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2012Light;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2012Blue;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2012Dark;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2005;
        private System.Windows.Forms.ToolStripMenuItem menuItemSchemaVS2003;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemDockingMdi;
        private System.Windows.Forms.ToolStripMenuItem menuItemDockingSdi;
        private System.Windows.Forms.ToolStripMenuItem menuItemDockingWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemSystemMdi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 对齐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmiRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiCenter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiBottom;
        private System.Windows.Forms.ToolStripMenuItem tsmiMiddle;
        private System.Windows.Forms.ToolStripButton toolBarButtonSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
    }
}