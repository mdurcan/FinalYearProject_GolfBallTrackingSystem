using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;

namespace BackgroundSubtraction
{
    class TrackedObject
    {
        //variable
        private List<CircleF> Detections;
        private bool Updated;
        private List<PointF> CirclePath;
        private List<int> frames;

        // constructor
        public TrackedObject(CircleF circle,int frame)
        {
            //adds circle
            Detections = new List<CircleF>();
            Detections.Add(circle);
            //adds centre to path
            CirclePath = new List<PointF>();
            CirclePath.Add(circle.Center);
            // adds the frame it was detected in
            frames = new List<int>();
            frames.Add(frame);
            Updated = true;
        }

        // add circles to detected
        public void AddNewDetection(CircleF circle, int frame)
        {
            Detections.Add(circle);
            CirclePath.Add(circle.Center);
            frames.Add(frame);
        }

        //if updated or not
        public void Update(bool result)
        {
            Updated = result;
        }

        // get the circles list
        public List<CircleF> GetCircles()
        {
            return Detections;
        }

        // get the list of points that make up the path
        public List<PointF> GetPath()
        {
            return CirclePath;
        }

        // gets the last circle entered
        public CircleF getLastCircle()
        {
            return Detections[Detections.Count - 1];
        }

        //Check if it has been Updated
        public bool CheckIfUpdated()
        {
            return Updated;
        }
    }
}
