using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace BE
{

    public class Nanny
    {
        /// <summary>
        /// PROPERTIES OF THE NANNY
        /// </summary>
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public Gender GenderNan { get; set; }
        public DateTime DateBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Elevator { get; set; }
        public int Floor { get; set; }
        public int YearOfExperience { get; set; }
        public bool ExperienceWithInNeeds { get; set; }
        public int MaxKids { get; set; }
        public float? MinAge { get; set; }
        public float? MaxAge { get; set; }
        public bool HourTariff { get; set; }
        public bool Cash { get; set; }
        public float PerHour { get; set; }
        public float PerMonth { get; set; }
        private bool[] worked = new bool[7];
        public bool[] Worked
        {
            get {return worked;}
            set {worked=value;}
        }
        [XmlIgnore]  //solution for matrix to XML bt SERIALiZ
        public TimeSpan[,] Schedule = new TimeSpan[2, 7];
        public string TempScheduel
        {
            get
            {
                if (Schedule == null)
                    return null;
                string result = "";
                if (Schedule != null)
                {
                    // dimension of the matrix 
                    int sizeA = Schedule.GetLength(0);
                    int sizeB = Schedule.GetLength(1);
                    result += "" + sizeA + "," + sizeB;
                    // regroup all the values of the matrix in result 
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            result += "," + Schedule[i, j];
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
                    Schedule = new TimeSpan[sizeA, sizeB];
                    int index = 2;
                    // enter all values in NeedShedule
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            Schedule[i, j] = TimeSpan.Parse(values[index++]);
                }
            }
        }

        public override bool Equals(object obj)
        {
            Nanny n = obj as Nanny;
            if (n == null)
                return false;
            return (n).Id == this.Id;

        }

        public bool VacDays { get; set; }
        public TravelType CarOrWalk { get; set; }
        public string Recommendations { get; set; }
        public bool HasCar { get; set; }
        public bool DrinksAlcool { get; set; }
        public bool Smokes { get; set; }
        [XmlIgnore]
        public List<Child> NannyChild = new List<Child>();
        public Religion ReligionN { get; set; }
        public Languages LanguageNanny { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + " Full Name: " + Name + ' ' + LastName + " Phone Number: " + Phone +" Address: " + Address +"\n";
        }

        /// <summary>
        ///indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[int index]
        {
            get { return Worked[index]; }
            set { Worked[index] = value; }
        }

        public TimeSpan this[int i, int j]
        {
            get { return Schedule[i, j]; }
            set { Schedule[i, j] = value; }
        }
    }
}
