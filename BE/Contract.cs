using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    
    public class Contract
    {
        /// <summary>
        /// PROPERTIES OF THE CONTRACT 
        /// </summary>
        /// 
        public static int conNum ;
        public int ConNum { get { return conNum; } set {} }
        public int ContractNum { get; set; }
        public int IdNanny { get; set; }
        public int IdChild { get; set; }
        public int IdMother { get; set; }
        public bool Meeting { get; set; }
        public bool ContractSigned { get; set; }
        public float Salary { get; set; }
        public double PerHour { get; set; }
        public double PerMonth { get; set; }
        public HourOrMonth HOrM { get; set; }
        public DateTime DateDealBegin { get; set; }
        public DateTime DateDealEnd { get; set; }
        public string Remarks { get; set; }
        
        public override bool Equals(object obj)
        {
            Contract c = obj as Contract;
            if (c == null)
                return false;
            return ((c).ContractNum == this.ContractNum);

        }

        public override string ToString()
        {
            return "Contract: " + ContractNum + " ID nanny: " + IdNanny + "ID child: " + IdChild + "Contract time from: " + DateDealBegin + " till: " + DateDealEnd +"\n";
        }
    }
}
