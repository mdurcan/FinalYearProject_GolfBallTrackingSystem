using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateVideo
{
    static class Program
    {
        /// Application to create video
        /// Martin Durcan
        /// main code in: VideoCreate.cs
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VideoCreate());
        }
    }
}
