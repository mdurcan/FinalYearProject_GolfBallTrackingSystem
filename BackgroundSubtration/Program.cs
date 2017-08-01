using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundSubtration
{
    static class Program
    {
        /// Background Subtraction
        /// Martin Durcan
        /// main code in: BackgroundSubtraction.cs
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BackgroundSubtraction());
        }
    }
}
