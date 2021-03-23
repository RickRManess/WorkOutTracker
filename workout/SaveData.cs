using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOutTracker.workout
{
    class SaveData
    {

        private List<CrossFit> CrossList;

        public List<CrossFit> crossList
        {
            get { return crossList; }
            set { crossList = value; }
        }

        private List<Weightlifting> WeightList;

        public List<Weightlifting> weightList
        {
            get { return weightList; }
            set { weightList = value; }
        }




    }
}
