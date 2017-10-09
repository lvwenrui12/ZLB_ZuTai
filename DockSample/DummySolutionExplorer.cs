using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DynamicTreeView;
using WeifenLuo.WinFormsUI.Docking;
using ZLB_Zutai.Model;
using ZLB_Zutai.Services;

namespace ZLB_Zutai
{
    public delegate void NewPanel();

    public delegate void ActivePanel(PageMoel page);
    public partial class DummySolutionExplorer : ToolWindow
    {
        DynamicTreeNode rootNode;
        public event NewPanel newPanel;
        public event ActivePanel activePanel;
        public DummySolutionExplorer()
        {
            InitializeComponent();
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            //treeView.RightToLeftLayout = RightToLeftLayout;
        }
     


        private void treeView_NodeMouseDown(object sender, DynamicTreeNodeMouseEventArgs e)
        {
            DynamicTreeNode selection = e.Node;

            if (selection == null && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //select regardless of horizontal alignment in the view                
                selection =
                    treeView.Nodes.VisibleNodes.Where(node => node.Bounds.Top <= e.Y && node.Bounds.Bottom >= e.Y).
                        FirstOrDefault();
            }


            treeView.SelectedNode = selection;
            btnRemove.Enabled = selection != null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                treeView.SelectedNode.Remove();
            }
        }

        private DynamicTreeNode selection;
        public void btnAdd_Click(object sender, EventArgs e)
        {
            //AddPageDialog addPage = new AddPageDialog();

            //addPage.btnAdd.Click += (o, args) =>
            //{
            //    var addition = Regex.Replace(addPage.txtInput.Text, @"(?<!\\)\\f", "\f");
            //    AddNode(addition);

            //    addPage.Close();

            //};
            //addPage.ShowDialog();
            //addPage.txtInput.Select();

            newPanel();
        }

        public void AddNode(string str)
        {
            if (selection == null)
            {
                selection = treeView.Nodes.Add("解决方案1");

            }

            selection.Nodes.Add(str);
            selection.Expanded = true;

        }
        PageMoel _activModel = GolableInstance.GetActiPage();
        public void treeView_SelectedNodeChanged(DynamicTreeView.DynamicTreeView obj)
        {
            if (treeView.SelectedNode != null)
            {
                foreach (var item in GolableInstance.PageList())
                {
                    if (item.PageName == treeView.SelectedNode.Text)
                    {
                        _activModel = item;
                        
                    }
                }

                activePanel(_activModel);
                //DockPanel panel = GolableInstance.GetDockPanel();
                //foreach (var item in panel.Documents )
                //{
                //    if (item is DesignWorkbench)
                //    {
                //        DesignWorkbench workbench = item as DesignWorkbench;
                //        if (workbench.pageGuid==_activModel.PageGuid)
                //        {
                //            workbench.Activate();
                //        }
                //    }
                //}
            }
        }
    }
}