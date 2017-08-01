using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleDetection
{
    static class Program
    {
        /// Edge Detection
        /// Martin Durcan
        /// main code in: Form1.cs
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new tlpContent());
        }
    }
}
