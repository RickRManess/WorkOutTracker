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

        private List<CrossFit> CrossList;

        public List<CrossFit> crossList
        {
            get { return crossList; }
            set { crossList = value; }
        }

        // Create new serializer instance with the type of clss
        XmlSerializer CrossFitSerializer = new XmlSerializer(typeof(CrossFit));

        TextWriter WriteFileStream = new StreamWriter(@"C:\test.xml");
       // CrossFitSerializer.Serialize(WriteFileStream, TestObj);


        private List<Weightlifting> weightList;

        public List<Weightlifting> WeightList
        {
            get { return WeightList; }
            set { WeightList = value; }
        }




    }
}
