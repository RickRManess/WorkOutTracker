using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WorkOutTracker.Program;

namespace WorkOutTracker
{
    class CrossFit : Workout
    {
        public CrossType CrossType;
    }

    class BeerDrinking : Workout
    {
        public int NumOfPints;
    }


}
