using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SingletonT
{
    public static class Singleton<T> where T : class
    {
        private static T s_instance;
        private static readonly object sr_lockObj = new object();

        static Singleton() { }

        public static T Instance
        {
            get
            {
                if (s_instance == null)
                {
                    lock (sr_lockObj)
                    {
                        if (s_instance == null)
                        {                           
                            ConstructorInfo[] constructors = typeof(T).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
                            s_instance = (T)constructors[0].Invoke (null) as T;
                        }
                    }
                }

                return s_instance;
            }            
        }
    }
}
