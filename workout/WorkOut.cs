using System;
using System.IO;
using System.Xml.Serialization;

namespace WorkOutTracker.workout
{
    class WorkOut
    {


        private int privateWeight;

        public int Weight
        {
           get { return Weight; }
           set {  }
        }

        private int privateSets;

        public int Sets
        {
            get { return Sets; }
            set {  }
        }


        private int privateReps;

        public int Reps
        {
            get { return Reps; }
            set {  }
        }


        public DateTime DateOfEntry;
        public TimeSpan Duration;


       
    }
}
