using System;
using System.Drawing.Design;

namespace ZLB_Zutai.Services
{
   public class CustomToolboxService : System.Drawing.Design.ToolboxService
    {
        ToolboxItem selectedItem = null;

        protected override CategoryNameCollection CategoryNames
        {
            get
            {
                return null;
            }
        }

        protected override System.Collections.IList GetItemContainers(string categoryName)
        {
            return null;
        }

        protected override System.Collections.IList GetItemContainers()
        {
            return null;
        }

        protected override void Refresh()
        {
            ;
        }

        protected override string SelectedCategory
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        protected override ToolboxItemContainer SelectedItemContainer
        {
            get
            {
                if (null == selectedItem)
                    return null;
                return new ToolboxItemContainer(selectedItem);
            }
            set
            {
                if (null == value)
                {
                    selectedItem = null;
                    if (null != ResetToolboxItem)
                        ResetToolboxItem(this, null);
                }
            }
        }

        public void SetSelectedToolboxItem(ToolboxItem toolboxItem)
        {
            selectedItem = toolboxItem;
        }

        public event EventHandler ResetToolboxItem;
    }
}
