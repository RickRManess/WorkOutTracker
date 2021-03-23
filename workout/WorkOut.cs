using System;
using System.IO;
using System.Xml.Serialization;

namespace WorkOutTracker.workout
{
    class WorkOut
    {


        private int _privateWeight;

        public int Weight
        {
            get { return _privateWeight; }
            set { _privateWeight = value; }
        }


        private int _privateSets;

        public int Sets
        {
            get { return _privateSets; }
            set { _privateSets = value; }
        }


        private int _privateReps;

        public int Reps
        {
            get { return _privateReps; }
            set { _privateReps = value; }
        }


        public DateTime DateOfEntry;
        public TimeSpan Duration;



    }
}
