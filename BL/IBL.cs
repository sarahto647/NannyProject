using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        //Definition of all the function
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
        Contract GetContract(int cn);
        IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null);
        #endregion
        #region OTHER FUNCTIONS
        int CalculateDistance(string source, string dest);
        IEnumerable<Nanny> MatchNanny(Mother mom);
        IEnumerable<Nanny> ClosestMatch(Mother mom);
        IEnumerable<Child> ChildNoNannyFound();
        IEnumerable<Nanny> NannyTAMAT();
        IEnumerable<Contract> ConractMatchCondition(Func<Contract, bool> condition = null);
        int ConractMatchConditionNum(Func<Contract, bool> condition = null);
        IEnumerable<Nanny> DistanceAddress(Mother mom);
        IEnumerable<Nanny> WithExperienceInNeeds();
        IEnumerable<Nanny> WithCar();
        IEnumerable<Child> ChildAllergies();
        IEnumerable<Nanny> NannyNoSmokeNoAlcool();
        IEnumerable<Nanny> AcceptCash();
        IEnumerable<Nanny> FloorOk();
        IEnumerable<IGrouping<float, Nanny>> GroupChildAge(bool sort = false, bool sortInMinAge = true);
        IEnumerable<IGrouping<int,Contract>> GroupNannyDistance(bool sort = false);
        #endregion
    }
}
