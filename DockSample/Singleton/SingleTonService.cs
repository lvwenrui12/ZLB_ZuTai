using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace ZLB_Zutai.Singleton
{
  public  class SingleTonService
    {
      
        private static List<DesignSurface> dsList;
        private static object _lock = new object();
        

        public static List<DesignSurface> DesignSurfaceList()
        {
            if (dsList == null)
            {
                lock (_lock)
                {
                    if (dsList == null)
                    {
                        dsList = new List<DesignSurface>();
                    }
                }
            }
            return dsList;
        }
        private static List<MenuCommandService> MenuServiceList;
        private static MenuCommandService _menuCommandService;

        public static List<MenuCommandService> MenuCommandServiceList()
        {
            if (MenuServiceList == null)
            {
                lock (_lock)
                {
                    if (MenuServiceList == null)
                    {
                        MenuServiceList = new List<MenuCommandService>();
                    }
                }
            }
            return MenuServiceList;
        }


    }
}
