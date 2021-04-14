using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WorkOutTracker.workout
{
    class SaveData
    {

        private List<CrossFit> _crossList;

        public List<CrossFit> CrossList
        {
            get { return _crossList; }
            set { _crossList = value; }
        }


        private List<Weightlifting> _weightList;

        public List<Weightlifting> WeightList
        {
            get { return _weightList; }
            set { _weightList = value; }
        }


        private List<UserFavorites> _userFavorites;

        public List<UserFavorites> UserFavorites
        {
            get { return _userFavorites; }
            set { _userFavorites = value; }
        }


    }
}
