using System.Collections.Generic;

namespace ZLB_Zutai.Singleton
{
  public  class SingletonClass<T> where T :class ,new ()
    {
        private static T instance;
        private static List<T> instanceList;
        private static object _lock = new object();
        
        public static T GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                }
            }
            return instance;
        }
        public static List<T> GetInstanceList()
        {
            if (instanceList == null)
            {
                lock (_lock)
                {
                    if (instanceList == null)
                    {
                        instanceList = new List<T>();
                    }
                }
            }
            return instanceList;
        }
    }
}
