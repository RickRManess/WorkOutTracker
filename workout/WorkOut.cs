using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOutTracker.workout
{
    class Workout
    {

        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }

        public DateTime DateOfEntry;
        public TimeSpan Duration;
    }
}
