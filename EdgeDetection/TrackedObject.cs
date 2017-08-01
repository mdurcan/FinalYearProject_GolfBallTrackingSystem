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

        // constructor
        public TrackedObject(CircleF circle)
        {
            Detections = new List<CircleF>();
            Detections.Add(circle);
            Updated = true;
        }

        // add circles to detected
        public void AddNewDetection(CircleF circle)
        {
            Detections.Add(circle);
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
            List<PointF> path = new List<PointF>();
            foreach (CircleF circle in Detections)
            {
                path.Add(circle.Center);
            }
            return path;
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
