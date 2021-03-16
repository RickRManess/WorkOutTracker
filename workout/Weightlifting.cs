using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOutTracker
{
    class Weightlifting
    {
        public string liftType;
        public int liftWeight;
        public int liftSets;
        public int liftReps;
        DateTime DateTime;
    public override string ToString()
    {
        return $"{liftType}";
    }

    }
}
