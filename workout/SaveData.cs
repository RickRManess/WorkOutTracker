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

        // Create new serializer instance with the type of clss
        XmlSerializer CrossFitSerializer = new XmlSerializer(typeof(CrossFit));

        TextWriter WriteFileStream = new StreamWriter(@"C:\test.xml");
       // CrossFitSerializer.Serialize(WriteFileStream, TestObj);


        private List<Weightlifting> _weightList;

        public List<Weightlifting> WeightList
        {
            get { return _weightList; }
            set { _weightList = value; }
        }




    }
}
