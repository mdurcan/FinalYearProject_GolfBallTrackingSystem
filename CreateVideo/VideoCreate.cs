using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace CreateVideo
{
    public partial class VideoCreate : Form
    {
        //Create videos
        private VideoWriter videoWriter;
        private Capture capture;
        private string file;

        public VideoCreate()
        {
            InitializeComponent();

            //creates the video
            videoWriter = new VideoWriter(@"C:\Users\Martin\Documents\4th_year\FYP\testData\ATest2.avi",
                    VideoWriter.Fourcc('M', 'S', 'V', 'C'),
                    20,
                    new Size(1170, 878),
                    true);
        }

        private void NextFrame_Click(object sender, EventArgs e)
        {
            //file explorer to get video file
            OpenFileDialog choosefile = new OpenFileDialog();
            choosefile.Multiselect = false;

            if (choosefile.ShowDialog() == DialogResult.OK)
            {
                file = @choosefile.FileName;
            }

            // capture image
            capture = new Capture(file);
            //save image
            videoWriter.Write(capture.QueryFrame());
        }
    }
}
