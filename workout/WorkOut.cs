using System;

namespace WorkOutTracker.workout
{
    class WorkOut
    {

        
        private int privateWeight;

        public int Weight
        {
            get { return Weight; }
            set { Weight = value; }
        }

        private int privateSets;

        public int Sets
        {
            get { return Sets; }
            set { Sets = value; }
        }


        private int privateReps;

        public int Reps
        {
            get { return Reps; }
            set { Reps = value; }
        }


        public DateTime DateOfEntry;
        public TimeSpan Duration;
    }
}
