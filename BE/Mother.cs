using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BE
{
    public class Mother
    {
        /// <summary>
        /// PROPERTIES OF THE MOTHER 
        /// </summary>
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string AddressArea { get; set; }
        public int WantedDistance { get; set; }
        private bool[] needNanny = new bool[7];
        public bool[] NeedNanny
        {
            get { return needNanny; }
            set { needNanny = value; }
        }
        [XmlIgnore]//solution for matrix to XML by serializ
        public TimeSpan[,] NeedSchedule = new TimeSpan[2, 7];
        public string TempScheduel
        {
            get
            {
                if (NeedSchedule == null)
                    return null;
                string result = "";
                if (NeedSchedule != null)
                {
                    // dimension of the matrix 
                    int sizeA = NeedSchedule.GetLength(0);
                    int sizeB = NeedSchedule.GetLength(1);
                    result += "" + sizeA + "," + sizeB;
                    // regroup all the values of the matrix in result 
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            result += "," + NeedSchedule[i, j];
                }
                return result;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    string[] values = value.Split(',');
                    // dimension 
                    int sizeA = int.Parse(values[0]);
                    int sizeB = int.Parse(values[1]);
                    // definition of the matrix 
                    NeedSchedule = new TimeSpan[sizeA, sizeB];
                    int index = 2;
                    // enter all values in NeedShedule
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            NeedSchedule[i, j] = TimeSpan.Parse(values[index++]);
                }
            }
        }

        public override bool Equals(object obj)
        {
            Mother m = obj as Mother;
            if (m == null)
                return false;
            return ((m).Id == this.Id);

        }
        public string Remarks { get; set; }
        public string FamilySituation { get; set; }
        public bool Smokes { get; set; }
        public string EmergencyContact { get; set; }
        public Religion ReligionM { get; set; }
        public bool ImportantReligion { get; set; }
        public int NumberOfChildren { get; set; }
        public Languages LanguageMom { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + " Full Name: " + Name + ' ' + LastName + " Phone Number: " + Phone + " Address: " + Address + "\n";
        }

        /// <summary>
        /// indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[int index]
        {
            get { return NeedNanny[index]; }
            set { NeedNanny[index] = value; }
        }

        public TimeSpan this[int i, int j]
        {
            get { return NeedSchedule[i, j]; }
            set { NeedSchedule[i, j] = value; }
        }
    }
}
