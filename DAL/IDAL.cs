using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        /// <summary>
        /// All the basic function to run the Data Base
        /// </summary>
        #region NANNY
        void AddNanny(Nanny nanny);
        void RemoveNanny(int id);
        void UpdateNanny(Nanny nanny);
        Nanny GetNanny(int id);
        IEnumerable<Nanny> GetAllNanny(Func<Nanny, bool> predicate = null);
        #endregion
        #region MOTHER
        void AddMother(Mother mother);
        void RemoveMother(int id);
        void UpdateMother(Mother mother);
        Mother GetMother(int id);
        IEnumerable<Mother> GetAllMother(Func<Mother, bool> predicate = null);
        #endregion
        #region CHILD
        void AddChild(Child child);
        void RemoveChild(int id);
        void UpdateChild(Child child);
        Child GetChild(int id);
        IEnumerable<Child> GetAllChild(Func<Child, bool> predicate = null);
        #endregion
        #region CONTRACT
        void AddContract(Contract contract);
        void RemoveContract(int numContract);
        void UpdateContract(Contract contract);
        Contract GetContract(int id);
        IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null);
        #endregion
    }
}
