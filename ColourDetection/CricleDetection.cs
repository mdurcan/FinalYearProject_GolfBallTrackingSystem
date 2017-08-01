using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
// EmguCV 
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;


namespace CricleDetection
{
    public partial class CricleDetection : Form
    {
        // Member Variables  //////////
        private Capture capWebcam = null;
        private bool bInCaptureingInProcess = false;
        private Image<Bgr, byte> imgOrginal;
        private Image<Gray, Byte> imgProcessed;

        
        // form creater //////////
        public CricleDetection()
        {
            InitializeComponent();
        }

        // components /////////
        private void CricleDetection_Load(object sender, EventArgs e)
        {
            try
            {
                capWebcam = new Capture(); //uses default webcam
            }
            catch (NullReferenceException except) //catch error if unsuccesful
            {
                txtXTRadius.Text = except.Message; //show error project message
            }
            //now it has good capture

            Application.Idle += processFrameAndUpdateGui; //going to add process image function to the application list of tasks

            bInCaptureingInProcess = true; // now cam is in use

        }//end func

        // ///////////
        private void CricleDetection_FormClosed(object sender, FormClosedEventArgs e)
        {
            capWebcam?.Dispose();
        }//end func

        // //////////
        private void processFrameAndUpdateGui(object sender, EventArgs arg)
        {
            imgOrginal = (capWebcam.QueryFrame()).ToImage<Bgr,byte>(); //next frame from web cam
            if (imgOrginal == null) return; //if not getting frame, bail

            imgProcessed = imgOrginal.InRange(new Bgr(120, 120, 120), //min fliter value for objects that are red
                new Bgr(255, 255, 256));                          //max fliter value red
            imgProcessed = imgProcessed.SmoothGaussian(9);        //single parameter is the x and y size of the fliter window

            CircleF[] circles = imgProcessed.HoughCircles(new Gray(100), // Canny Treshold
                new Gray(50),                                            // Accumlator threshold 
                2,                                                       // size of image/ this parameter = accumlator resolution
                imgProcessed.Height/4,                                   // min distance in pixels the center of the detected circle
                10,                                                      // min raduis of detected circles
                400)[0];                                                 // max raduis of detected circle, get circles from first channel

            foreach (CircleF circle in circles)
            {
                if(txtXTRadius.Text != null) txtXTRadius.AppendText(Environment.NewLine); // if we are not on new line moves us to one

                txtXTRadius.AppendText("Ball Position: x= " + circle.Center.X.ToString().PadLeft(4) + //x position of centre point
                    " , y= " + circle.Center.Y.ToString().PadLeft(4) + // y postion of the centre point
                    " , radius= " + circle.Radius.ToString("####.000").PadLeft(7)); //raduis of circle

                txtXTRadius.ScrollToCaret();

                // now to draw circle
                // will be a circle of raduis 3 and green, no mater the size of ball

                CvInvoke.Circle(imgOrginal, //were the circle will be drawen
                    new Point((int) circle.Center.X, (int) circle.Center.Y), //the center of the circle
                    3, //raduis of circle
                    new MCvScalar(0.255, 0), //draw green
                    -1, //thickness of circle in pixels
                    LineType.AntiAlias, //use AA 
                    0); // no shift

                //draw red circle around circles 
                imgOrginal.Draw(circle, //draw circle
                    new Bgr(Color.Red), //colour red
                    3);                 //thickness of circle 
            }//end foreach

            //output images
            ibOriginal.Image = imgOrginal;
            ibProcessed.Image = imgProcessed;
        }//end func

        // //////////
        private void btnPauseOrResume_Click(object sender, EventArgs e)
        {
            if (bInCaptureingInProcess) //if currently process whe button pressed
            {
                Application.Idle -= processFrameAndUpdateGui; //remove func from list of tasks
                bInCaptureingInProcess = false; // update flag
                btnPauseOrResume.Text = "resume"; //change text on button
            }
            else //if nothing is happening when button is pressed
            {
                Application.Idle += processFrameAndUpdateGui; //add func to list of task
                bInCaptureingInProcess = true; //update flag
                btnPauseOrResume.Text = "pause"; //change btn text
            }
        }//end func
    }//end class
}//end namespace
