using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WorkOutTracker.Program;

namespace WorkOutTracker
{
    class Weightlifting : Workout
    {
        public WeightType LiftType;
        public BodyPart BodyPart;
    }

    public class BodyPart
    {
    }

    class Workout
    {
        public int Weight;
        public int Sets;
        public int Reps;
        public DateTime DateOfEntry;
        public TimeSpan Duration;


        public int TotalWeightLifted
        {
            get
            {
                return Weight * Sets * Reps;
            }
        }

     
        private int myVar;

        public int MyProperty
        {
            get 
            {
           
                return myVar; 
            }
            set 
            { 
                if(value > 0)
                    myVar = value; 
            }
        }


        private String _backingField;

        public String MagicNumber
        {
            get { return _backingField; }
            set { _backingField = value; }
        }

        public int Magic2 
        {
            get
            {
                return 5;
            } 
        }

        public int Whaever { get; set; }


    }

    class Magic 
    {
        public String Weight;
    }
}
