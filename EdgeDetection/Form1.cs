using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// EmguCV 
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.Util;

namespace CircleDetection
{
    public partial class tlpContent : Form
    {
        // Variables /////////////////////////////////////////////////////////
        private Capture capWebcam = null;
        private bool bInCaptureingInProcess = false;

        private Image<Bgr, byte> imgOrginal;
        private Image<Bgr, byte> imgSmoothed;
        private Image<Gray, byte> imgGray;
        private Image<Gray, byte> imgEdge;
        private Image<Bgr, byte> imgCircles;

        private bool bInFirstTimeInResizeEvent = true;
        private int intOrigForWidth;
        private int intOrigForHieght;
        private int intOrigTableLayoutPaneWidth;
        private int intOrigTableLayoutPaneHieght;

        private List<Point> centrePoints = new List<Point>();
        private Boolean startingPointFound=false;
        private int pointNum = 0;

        // constructure ///////////////////////////////////////////////////////
        public tlpContent()
        {
            InitializeComponent();

            //size of form
            intOrigForWidth = Width;
            intOrigForHieght = Height;

            intOrigTableLayoutPaneWidth = tplImages.Width;
            intOrigTableLayoutPaneHieght = tplImages.Height;
        }

        // when form resized //////////////////////////////////////////////
        private void tlpContent_Resize(object sender, EventArgs e)
        {
            if (bInFirstTimeInResizeEvent)
            {
                bInFirstTimeInResizeEvent = false;
            }
            else
            {
                tplImages.Width = Width - (intOrigForWidth - intOrigTableLayoutPaneWidth);
                tplImages.Height = Height - (intOrigForHieght - intOrigTableLayoutPaneHieght);
            }
        }

        // when Form Loaded //////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                capWebcam = new Capture(); //uses default webcam
            }
            catch (NullReferenceException except) //catch error if unsuccesful
            {
                Console.WriteLine(except.Message); //show error project message
            }
            //now it has good capture

            Application.Idle += ProcessFrameAndUpdateGui; //going to add process image function to the application list of tasks

            bInCaptureingInProcess = true; // now cam is in use

        }

        // when form closed //////////////////////////////////////////////////
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            capWebcam?.Dispose();
        }

        // Stop and start image being taken //////////////////////////////////
        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (bInCaptureingInProcess) //if currently process whe button pressed
            {
                Application.Idle -= ProcessFrameAndUpdateGui; //remove func from list of tasks
                bInCaptureingInProcess = false; // update flag
                btnPausePlay.Text = "resume"; //change text on button
            }
            else //if nothing is happening when button is pressed
            {
                Application.Idle += ProcessFrameAndUpdateGui; //add func to list of task
                bInCaptureingInProcess = true; //update flag
                btnPausePlay.Text = "pause"; //change btn text
            }
        }

        // show circles on orginal image ////////////////////////////////////////////
        private void chkCirclesOnOrginal_CheckedChanged(object sender, EventArgs e)
        {
            if (bInCaptureingInProcess == false)
            {
                ProcessFrameAndUpdateGui(new Object(), new EventArgs());
            }
        }

        // process images /////////////////////////////////////////////////////////
        private void ProcessFrameAndUpdateGui(object sender, EventArgs arg)
        {
            imgOrginal = (capWebcam.QueryFrame()).ToImage<Bgr, byte>(); //next frame from web cam
            if (imgOrginal == null) return; //if not getting frame, bail

           
            //smoothing
            imgSmoothed = imgOrginal;
            imgSmoothed.PyrDown();
            imgSmoothed.PyrUp();
            imgSmoothed._SmoothGaussian(3);             // gaussian smooth, argument is the size of fliter window

            //Turn Gray
            imgGray = imgSmoothed.Convert<Gray, byte>();

            //get edges
            imgEdge = imgGray.Canny(100, 50);

            //Canny Threshold
            var grayCannyThreshold = 160.0; // used first all all dection 
            var grayCirclesAccumThreshold = 100.0; // second canny threshold for circle detection more selective 

            // get circles
            imgCircles = imgOrginal.CopyBlank();

            double dblAccumRes = 2.0;   //resolution used to detect the centre of the cirlces
            double dblMinDistBetweenCircles = imgGray.Height / 4;   //min distance from detected centers of detected circles
            int intMinRaduis = 10;      // min raduis of circles
            int intMaxRaduis = 80;    // max raduis of circles

            CircleF[] circles =
                imgGray.HoughCircles(new Gray(grayCannyThreshold), new Gray(grayCirclesAccumThreshold),
                    dblAccumRes,
                    dblMinDistBetweenCircles, intMinRaduis, intMaxRaduis)[0];

            foreach (CircleF circle in circles)
            {
                imgCircles.Draw(circle, new Bgr(Color.Red), 2);
                if (chkCirclesOnOrginal.Checked)
                {
                    imgOrginal.Draw(circle, new Bgr(Color.Red), 2);
                }

                Point point = new Point((int) circle.Center.X, (int) circle.Center.X);
                centrePoints.Add(point);
                pointNum++;
                //if (startingPointFound==false)
                //{
                //    centrePoints.Add( point);
                //    pointNum++;
                //    startingPointFound = true;
                //}else if ((new LineSegment2D(centrePoints[pointNum - 1], point).Length) < 10.0)
                //{
                //    centrePoints.Add(point);
                //    pointNum++;
                //}
            }

            int i;
            for (i = pointNum; i>1;i--)
            {
                Point[] points = centrePoints.ToArray();
                LineSegment2D line = new LineSegment2D(points[i-1], points[i-2]);
                imgCircles.Draw(line,new Bgr(Color.Red),((i/pointNum)*2) );
                if (chkCirclesOnOrginal.Checked)
                {
                    imgOrginal.Draw(line, new Bgr(Color.Red),2);
                }
            }
            //output images
            ibOrginal.Image = imgOrginal;
            ibGray.Image = imgEdge;
            ibCircles.Image = imgCircles;
        }

        
    }
}
