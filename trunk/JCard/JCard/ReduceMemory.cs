using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace JCard
{
    public class cReduceMemory
    {
        // This class will help reduce memory

        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);
        public static void ReduceMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            //{
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            //}
        }
       

        
    }
}
