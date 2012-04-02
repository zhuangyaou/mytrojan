using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoImplementedProperties_ex
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主要进入点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
