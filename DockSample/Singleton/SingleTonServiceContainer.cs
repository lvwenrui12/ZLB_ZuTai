using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using ZLB_Zutai.Services;

namespace ZLB_Zutai.Singleton
{
 public   class SingleTonServiceContainer
    {//单例模式

        private static ServiceContainer instance;
        private static object _lock = new object();

        public static ServiceContainer GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new ServiceContainer();

                        instance.AddService(typeof(System.ComponentModel.Design.IDesignerEventService), new DesignerEventService());
                        instance.AddService(typeof(System.ComponentModel.Design.Serialization.INameCreationService), new NameCreationService());


                        instance.AddService(typeof(IToolboxService),SingleTonCustomToolboxService.GetInstance());
                        
                    }
                }
            }
            return instance;
        }
    }
}
