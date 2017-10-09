using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZLB_Zutai.Model
{
  public  class PageMoel
    {
        /// <summary>
        /// 对应页面的model 编号
        /// </summary>
        public  Guid PageGuid { get; set; }
       
        public  string PageName { get; set; }

        public DesignSurface surFace { get; set; }

        public ServiceContainer serviceContainer { get; set; }

        public MenuCommandService menuCommandService => new MenuCommandService(this.surFace);

        public PropertyGrid propertyGrid { get; set; }

        public IDesignerHost host
        {
            get
            {
                return (IDesignerHost) surFace?.GetService(typeof(IDesignerHost));
            }
        } 

        /// <summary>
        ///  选中项改变时的事件
        /// </summary>
        public ISelectionService selectionService => this.surFace?.GetService(typeof(ISelectionService)) as ISelectionService;

        /// <summary>
        /// 增/删/重命名组件的事件
        /// </summary>
        public IComponentChangeService componentChangeService=> (IComponentChangeService)this.surFace?.GetService(typeof(IComponentChangeService));

    }
}
