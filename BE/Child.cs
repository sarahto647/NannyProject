using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{

    public class Child
    {
        /// <summary>
        /// PROPERTIES OF THE CHILD
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender GenderKid { get; set; }
        public int IdMom { get; set; }
        public DateTime DateBirth { get; set; }
        public bool InNeed { get; set; }
        public string NeedList { get; set; }
        public bool HasAllergies { get; set; }
        public string Allergies { get; set; }
        public bool SpecialMedication { get; set; }
        public bool InDiapers { get; set; }
        public bool HasNanny { get; set; }

        public override string ToString()
        {
            return "ID: "+ Id + " Name: "+ Name;
        }


    }
}
