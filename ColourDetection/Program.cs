using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricleDetection
{
    static class Program
    {
        /// Colour Detection
        /// Martin Durcan
        /// main code in: CircleDetection.cs
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CricleDetection());
        }
    }
}
