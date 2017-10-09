using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using ZLB_Zutai.Model;

namespace ZLB_Zutai.Services
{
    public class GolableInstance
    {

     
        private static List<PageMoel> instanceList;
        private static object _lock = new object();

        public static List<PageMoel> PageList()
        {
            if (instanceList == null)
            {
                lock (_lock)
                {
                    if (instanceList == null)
                    {
                        instanceList = new List<PageMoel>();
                    }
                }
            }
            return instanceList;
        }

        public static int Pagecount;

        private static PageMoel ActivePage;

        public static PageMoel GetActiPage()
        {
            if (ActivePage==null)
            {
                lock (_lock)
                {
                    if (ActivePage==null)
                    {
                        ActivePage=new PageMoel();
                    }
                }
                
            }
            return ActivePage;
        }
    
    }
}
