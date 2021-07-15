using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FactoryDAL
    {
        static IDAL dal = null;
        public static IDAL GetDal()
        {
            if(dal==null)
                dal=new Dal_XML();
            return dal;
        }
    }
}
