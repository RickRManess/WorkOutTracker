using System;
using System.IO;
using System.Xml.Serialization;

namespace WorkOutTracker.workout
{
    class CrossFit
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


        public void Save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(CrossFit));
                XML.Serialize(stream, this);

                TextWriter WriteFileStream = new StreamWriter(@"C:\test.xml");
                XML.Serialize(WriteFileStream, this);

                WriteFileStream.Close();
            }
        }
    }
}
