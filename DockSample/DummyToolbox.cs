using System.Reflection;
using System.Windows.Forms;
using ZLB_Zutai.Loader;
using ToolBox;

namespace ZLB_Zutai
{
    public partial class DummyToolbox : ToolWindow
    {
        public ToolBox.ToolBox toolBox;
        public DummyToolbox()
        {
            InitializeComponent();

            #region Ìí¼ÓToolBox

            string fileName = Application.StartupPath + @"\..\..\data\ControlLibrary.xml";
            ComponentLibraryLoader componentLibraryLoader = new ComponentLibraryLoader();
            componentLibraryLoader.LoadToolComponentLibrary(fileName);

       toolBox = new ToolBox.ToolBox { Dock = DockStyle.Fill };

            foreach (Category category in componentLibraryLoader.Categories)
            {
                if (category.IsEnabled)
                {
                    ToolBoxCategory cate = new ToolBoxCategory();
                    cate.ImageIndex = -1;
                    cate.IsOpen = false;
                    cate.Name = category.Name;
                    cate.Parent = null;

                    ToolBoxItem item = new ToolBoxItem();
                    item.Tag = null;
                    item.Name = "<Pointer>";
                    item.Parent = null;
                    cate.Items.Add(item);

                    foreach (ToolComponent component in category.ToolComponents)
                    {
                        item = new ToolBoxItem();

                        System.Drawing.Design.ToolboxItem toolboxItem = new System.Drawing.Design.ToolboxItem();
                        toolboxItem.TypeName = component.FullName;
                        toolboxItem.Bitmap = componentLibraryLoader.GetIcon(component);
                        toolboxItem.DisplayName = component.Name;
                        Assembly asm = component.LoadAssembly();
                        toolboxItem.AssemblyName = asm.GetName();

                        item.Image = toolboxItem.Bitmap;
                        item.Tag = toolboxItem;
                        item.Name = component.Name;
                        item.Parent = null;

                        cate.Items.Add(item);
                    }

                    toolBox.Categories.Add(cate);
                }
            }

            pnlToolBox.Controls.Add(toolBox);//×ó±ßpanelÌí¼Ó¿Ø¼þ

            #endregion
        }
    }
}