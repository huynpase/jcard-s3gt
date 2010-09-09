using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JCard
{
    public class Common
    {
        public static  bool checkSingleInstance(string appName)
        {
            bool isNewIns;
            using (Mutex mt = new Mutex(true, appName, out isNewIns))
            {
                if (isNewIns)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
