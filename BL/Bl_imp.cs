using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DS;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi;

namespace BL
{
    internal class Bl_imp : IBL
    {
        DAL.IDAL dal;
        //c-tor
        public Bl_imp()
        {
            //gets a dal
            dal = DAL.FactoryDAL.GetDal(); 
        }
        #region Nanny Function
        /// <summary>
        /// Get nanny via ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Nanny GetNanny(int id)
        {
            if (dal.GetNanny(id) == null)
                throw new Exception("Nanny doesn't exist\n");
            return dal.GetNanny(id);
        }
        /// <summary>
        /// Add a new nanny to list, if doesn't match expectation exception thrown
        /// </summary>
        /// <param name="nanny"></param>
        public void AddNanny(Nanny nanny)
        {
            DateTime check = DateTime.Now;// date of today 
            if ((check.Year) - (nanny.DateBirth.Year) < 18)
                throw new Exception("A nanny must be over 18\n");
            if (nanny.MaxKids <= 0)
                throw new Exception("Nanny must be able to keep at least one child\n");
            bool flag = false;
            // check id the nanny work least one day per week 
            for (int i = 0; i < 7; i++)
            {
                if (nanny.Worked[i] == true)
                    flag = true;
            }
            if (flag == false)
                throw new Exception("A nanny must work at least one day per week\n");
            //check if nanny has a car 
            if (nanny.HasCar == true)
            {
                nanny.CarOrWalk = TravelType.Driving;
            }
            else
            {
                nanny.CarOrWalk = TravelType.Walking;
            }

            dal.AddNanny(nanny);
        }
        /// <summary>
        /// Remove a nanny from the list
        /// </summary>
        /// <param name="id"></param>
        public void RemoveNanny(int id)
        {
            Nanny nan = GetNanny(id);
            dal.RemoveNanny(id);
        }
        /// <summary>
        /// Update a nanny, if doesn't match expectation exception thrown
        /// </summary>
        /// <param name="nanny"></param>
        public void UpdateNanny(Nanny nanny)
        {
            DateTime check = DateTime.Now;
            if ((check.Year) - (nanny.DateBirth.Year) < 18)
                throw new Exception("A nanny must be over 18\n");
            if (nanny.MaxKids <= 0)
                throw new Exception("Nanny must be able to keep at least one child\n");
            bool flag = false;
            // check id=f the nanny work leat one day in the week 
            for (int i = 0; i < 7; i++)
            {
                if (nanny.Worked[i] == true)
                    flag = true;
            }
            if (flag == false)
                throw new Exception("A nanny must work at least one day per week\n");

            dal.UpdateNanny(nanny);
        }
        /// <summary>
        /// Get all the Nannys according to a predicate- if no predicate given then predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Nanny> GetAllNanny(Func<Nanny, bool> predicate = null)
        {
            return dal.GetAllNanny(predicate);
        }
        #endregion

        #region Mother Function
        /// <summary>
        /// Get a mom according to its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Mother GetMother(int id)
        {
            if (dal.GetMother(id) == null)
                throw new Exception("Mother not found\n");
            return dal.GetMother(id);
        }
        /// <summary>
        /// Add a mother to the MotherList
        /// </summary>
        /// <param name="mother"></param>
        public void AddMother(Mother mother)
        {
            if (mother.NumberOfChildren <= 0)
                throw new Exception("A mother in this system must have at least one child\n");
            dal.AddMother(mother);
        }
        /// <summary>
        /// Remove a mother from the MotherList
        /// </summary>
        /// <param name="id"></param>
        public void RemoveMother(int id)
        {
            int check = GetAllContract(c => c.IdMother == id).Count();
            if (check > 1)
                throw new Exception("The mother has an active contract therfore cannot be removed\n");
            dal.RemoveMother(id);
        }
        /// <summary>
        /// Update a mother from the MotherList
        /// </summary>
        /// <param name="mother"></param>
        public void UpdateMother(Mother mother)
        {
            dal.UpdateMother(mother);
        }
        /// <summary>
        /// Get all the Mothers according to a predicate- if no predicate given then predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Mother> GetAllMother(Func<Mother, bool> predicate = null)
        {
            return dal.GetAllMother(predicate);
        }
        #endregion

        #region Child Function
        /// <summary>
        /// Get a child according to its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Child</returns>
        public Child GetChild(int id)
        {
            Child check = dal.GetChild(id);
            if (check == null)
                throw new Exception("Child not found\n");
            return check;
        }
        /// <summary>
        /// Add a child to the childList
        /// </summary>
        /// <param name="child">child to add</param>
        public void AddChild(Child child)
        {
            Mother mom = dal.GetMother((int)child.IdMom);
            if (mom == null)
                throw new Exception("Please add the mother of the child first\n");
            dal.AddChild(child);
        }
        /// <summary>
        /// Remove a child from ChildList
        /// </summary>
        /// <param name="id"></param>
        public void RemoveChild(int id)
        {
            if (GetChild(id).HasNanny == true)
                throw new Exception("The child is in an active contract\n");
            dal.RemoveChild(id);
        }

        /// <summary>
        /// Updates an existing child
        /// </summary>
        /// <param name="child"></param>
        public void UpdateChild(Child child)
        {
            Mother mom = dal.GetMother((int)child.IdMom);
            if (mom == null)
                throw new Exception("Please add the mother of the child first\n");
            dal.UpdateChild(child);
        }
        /// <summary>
        /// Get all childs acording to a specific predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Child> GetAllChild(Func<Child, bool> predicate = null)
        {
            return dal.GetAllChild(predicate);
        }
        #endregion

        #region Contract Function
        /// <summary>
        ///  Get a contract according to its number
        /// </summary>
        /// <param name="cn"></param>
        /// <returns></returns>
        public Contract GetContract(int cn)
        {
            if (dal.GetContract(cn) == null)
                throw new Exception("Contract not found\n");
            return dal.GetContract(cn);
        }
        /// <summary>
        /// Add a contract while making sure that everything is correct-if not then an exeption is thrown
        /// </summary>
        /// <param name="contract"></param>
        public void AddContract(Contract contract)
        {
            //contract doesn't exist
            if (contract == null)
                return;
            // get the nanny, mother and child via the contract 
            Nanny checkNanny = GetNanny(contract.IdNanny);
            Child checkChild = GetChild(contract.IdChild);
            Mother checkMom = GetMother(contract.IdMother);
            //checking religion match
            if (checkMom.ImportantReligion == true && checkMom.ReligionM != checkNanny.ReligionN)
                throw new Exception("The Nannys religion does not match the mothers expectations\n");
            DateTime check = DateTime.Now;
            // get the year and the month of the date birthday of the child
            int yearChild = checkChild.DateBirth.Year;
            int monthChild = checkChild.DateBirth.Month;
            // check if number of the childs is not more than the max kids the nanny can keep
            if (checkNanny.NannyChild.Count() >= checkNanny.MaxKids)
                throw new Exception("Cannot add the contract to a nanny who already reached a maximum number of contracts\n");
            // checking the age of the child 
            if (check.Year - yearChild == 0 && check.Month - monthChild < 3)
              throw new Exception("Cannot creat a contract for a child that is less than 3 months old\n");
            // all brothers and sisters whose have the same nanny 
              IEnumerable<Child> childSiblings = GetAllChild(c => c.IdMom == checkChild.IdMom);
            int count = childSiblings.Count();
            float hoursSalary = 0;
            // if the salary of the nanny is by hour 
            if (contract.HOrM == HourOrMonth.hour)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (checkMom.NeedNanny[i] == true && checkNanny.Worked[i] == true)
                    {
                        TimeSpan checkTime = checkNanny.Schedule[1, i] - checkNanny.Schedule[0, i];
                        hoursSalary += checkTime.Hours;
                        hoursSalary += (float)(checkTime.Minutes / (60.0));
                        hoursSalary += (float)(checkTime.Seconds / (3600.0));
                    }
                }
                contract.Salary = hoursSalary * checkNanny.PerHour * 4 * (float)(1 - (0.02 * count));//final salary
            }
            // if the salary of the nanny is by month 
            if (contract.HOrM == HourOrMonth.month)
            {
                if (count > 0)
                    contract.Salary = checkNanny.PerMonth * (float)(1 - (0.02 * count));
                else
                    contract.Salary = checkNanny.PerMonth;
            }
            // contract.ContractNum = contract.ConNum++;
            checkChild.HasNanny = true;
            UpdateChild(checkChild);
            checkNanny.NannyChild.Add(checkChild);
            UpdateNanny(checkNanny);
            dal.AddContract(contract);
        }
        /// <summary>
        /// Remove a contract from the list
        /// </summary>
        /// <param name="numContract"></param>
        public void RemoveContract(int numContract)
        {
            // get the nanny and the child via the contract 
            Nanny checkNanny = GetNanny(GetContract(numContract).IdNanny);
            Child checkChild = GetChild(GetContract(numContract).IdChild);
            checkNanny.NannyChild.Remove(checkChild);
            // count of contract of this child 
            int check = GetAllContract(c => c.IdChild == checkChild.Id).Count();
            if (check <= 0)
                checkChild.HasNanny = false;
            dal.RemoveContract(numContract);
        }
        /// <summary>
        /// Update a contract
        /// </summary>
        /// <param name="contract"></param>
        public void UpdateContract(Contract contract)
        {
            // get the nanny, mother and child via the contract 
            Nanny checkNanny = GetNanny(contract.IdNanny);
            Child checkChild = GetChild(contract.IdChild);
            Mother checkMom = GetMother(contract.IdMother);
            //checking religion match
            if (checkMom.ImportantReligion == true && checkMom.ReligionM != checkNanny.ReligionN)
                throw new Exception("The Nannys religion does not match the mothers expectations\n");
            DateTime check = DateTime.Now;
            // get the year and the month of the date birthday of the child
            int yearChild = checkChild.DateBirth.Year;
            int monthChild = checkChild.DateBirth.Month;
            // check if number of the childs is not more than the max kids the nanny can keep
            if (checkNanny.NannyChild.Count() >= checkNanny.MaxKids)
                throw new Exception("Cannot add the contract to a nanny who already reached a maximum number of contracts\n");
            // checking the age of the child 
            if (check.Year - yearChild == 0 && check.Month - monthChild < 3)
              throw new Exception("Cannot creat a contract for a child that is less than 3 months old\n");
            // all brothers and sisters whose have the same nanny 
            IEnumerable<Child> childSiblings = GetAllChild(c => c.IdMom == checkChild.IdMom);
            int count = childSiblings.Count();
            float hoursSalary = 0;
            // if the salary of the nanny is by hour 
            if (contract.HOrM == HourOrMonth.hour)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (checkMom.NeedNanny[i] == true && checkNanny.Worked[i] == true)
                    {
                        TimeSpan checkTime = checkNanny.Schedule[1, i] - checkNanny.Schedule[0, i];
                        hoursSalary += checkTime.Hours;
                        hoursSalary += (float)(checkTime.Minutes / (60.0));
                        hoursSalary += (float)(checkTime.Seconds / (3600.0));
                    }
                }
                contract.Salary = hoursSalary * checkNanny.PerHour * 4 * (float)(1 - (0.02 * count));//final salary
            }
            // id the salary of the nanny is by month 
            if (contract.HOrM == HourOrMonth.month)
            {
                if (count > 0)
                    contract.Salary = checkNanny.PerMonth * (float)(1 - (0.02 * count));
                else
                    contract.Salary = checkNanny.PerMonth;
            }
            checkChild.HasNanny = true;
            UpdateChild(checkChild);
            checkNanny.NannyChild.Add(checkChild);
            UpdateNanny(checkNanny);
            dal.UpdateContract(contract);
        }
        /// <summary>
        /// Get all the Contracts acording to a predicate- if no predicate given then predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null)
        {
            return dal.GetAllContract(predicate);
        }
        #endregion

        #region Other Functions
        /// <summary>
        /// Get the distance between two address 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        public int CalculateDistance(string source, string dest)
        {
            var drivingDirectionRequest = new DirectionsRequest
            {
                TravelMode = TravelMode.Walking,
                Origin = source,
                Destination = dest,
            };
            //drivingDirections contains all the routs options
            DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);
            // the first route
            Route route = drivingDirections.Routes.First();
            // the first leg is the destination
            Leg leg = route.Legs.First();
            // return the distance between source and destination
            return leg.Distance.Value;
        }
        /// <summary>
        /// Get nanny whose correspond to the caracteristics of the mother 
        /// </summary>
        /// <param name="mom"></param>
        /// <returns></returns>
        public IEnumerable<Nanny> MatchNanny(Mother mom)
        {
            if (mom == null)
                throw new Exception("The mother does not exist");
            bool flag = true;
            int i = 0;
            foreach (Nanny item in dal.GetAllNanny())
            {
                // if the mother needs nanny 
                if (mom.NeedNanny[i] == true)
                {
                    if (item.Worked[i] == false)// checking if the nanny worked 
                        flag = false;
                    if (mom.NeedSchedule[0, i] < item.Schedule[0, i])// checking the hour begining 
                        flag = false;
                    if (mom.NeedSchedule[1, i] > item.Schedule[1, i])// checking the hour finishing
                        flag = false;
                }
                // if the nanny correspond
                if (flag == true)
                {
                    yield return item;
                    i++;
                }
            }
        }
        /// <summary>
        /// If the nanny is not completly correspond to the the caracteristics of the mother, get nanny whose almost correpond 
        /// </summary>
        /// <param name="mom"></param>
        /// <returns></returns>
        public IEnumerable<Nanny> ClosestMatch(Mother mom)
        {
            if (mom == null)
                throw new Exception("The mother does not exist");
            int i = 0;
            foreach (Nanny item in dal.GetAllNanny())
            {
                bool flag = true;
                // if the mother needs nanny in the same day but not in the same hours the mother need 
                if (mom.NeedNanny[i] == true && item.Worked[i] == false)
                    flag = false;
                if (flag == true)
                {
                    yield return item;
                    i++;
                }
            }
        }
        /// <summary>
        /// Get all childrens whose din't have nanny 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Child> ChildNoNannyFound()
        {
            IEnumerable<Child> NoNanny = from child in dal.GetAllChild()
                                         where child.HasNanny == false
                                         select child;
            return NoNanny;
        }
        /// <summary>
        /// Get all nanny whose work on vacations from the TAMAT
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Nanny> NannyTAMAT()
        {
            return GetAllNanny(n => n.VacDays == true);

        }
        /// <summary>
        /// Get all contracts that fit a particular condition
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public IEnumerable<Contract> ConractMatchCondition(Func<Contract, bool> condition = null)
        {
            return GetAllContract(condition);

        }
        /// <summary>
        /// Get number of contracts that fit a particular condition
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int ConractMatchConditionNum(Func<Contract, bool> condition = null)
        {
            return GetAllContract(condition).Count();
        }
        /// <summary>
        /// Get all nanny that the distance between the nanny and the mother fit to the mother 
        /// </summary>
        /// <param name="mom"></param>
        /// <returns></returns>
        public IEnumerable<Nanny> DistanceAddress(Mother mom)
        {
            IEnumerable<Nanny> AreaNanny = from item in dal.GetAllNanny()
                                           where CalculateDistance(item.Address, mom.AddressArea) <= mom.WantedDistance
                                           select item;
            return AreaNanny;
        }
        /// <summary>
        /// Get all nanny whose have experiences with childrens whose need help 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Nanny> WithExperienceInNeeds()
        {
            return GetAllNanny(n => n.ExperienceWithInNeeds == true);
        }
        /// <summary>
        /// Get all nanny whose have a car 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Nanny> WithCar()
        {
            return GetAllNanny(n => n.HasCar == true);
        }
        /// <summary>
        /// Get all childrens whose have allergies 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Child> ChildAllergies()
        {
            return GetAllChild(c => c.HasAllergies == true);
        }
        /// <summary>
        /// Get all nanny whose don't smoke and don't drink alcool 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Nanny> NannyNoSmokeNoAlcool()
        {
            return GetAllNanny(n => n.Smokes == false && n.DrinksAlcool == false);
        }
        /// <summary>
        /// Get all nanny whose accept to be paid in cash 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Nanny> AcceptCash()
        {
            return GetAllNanny(n => n.Cash == true);
        }
        /// <summary>
        /// Get all nanny whose live in a floor less than 5 or nanny whose have an elevator and live in a floor more 5
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Nanny> FloorOk()
        {
            return GetAllNanny(n => n.Floor < 5 || (n.Floor > 5 && n.Elevator == true));
        }

        /// <summary>
        /// Grouping a list of nanny by age of children the nanny can keep
        /// </summary>
        /// <param name="sort"></param>
        /// <param name="sortInMinAge"></param>
        /// <returns></returns>
        public IEnumerable<IGrouping<float, Nanny>> GroupChildAge(bool sort = false, bool sortInMinAge = true)
        {
            IEnumerable<IGrouping<float, Nanny>> groupNannyOfChildAge = null;
            if (sort == true)
            {
                if (sortInMinAge == true)
                {
                    groupNannyOfChildAge = from item in GetAllNanny()
                                           orderby item.Name
                                           group item by (float)((int)(item.MinAge / 3) * 3);
                }
                else
                {
                    groupNannyOfChildAge = from item in GetAllNanny()
                                           orderby item.Name
                                           group item by (float)((int)(item.MinAge / 3) * 3);
                }
            }
            else
            {
                if (sortInMinAge == true)
                {
                    groupNannyOfChildAge = from item in GetAllNanny()
                                           group item by (float)((int)(item.MaxAge / 3) * 3);
                }
                else
                {
                    groupNannyOfChildAge = from item in GetAllNanny()
                                           group item by (float)((int)(item.MaxAge / 3) * 3);
                }
            }
            return groupNannyOfChildAge;
        }
        /// <summary>
        /// Grouping the contracts according to the distance between nanny and mother 
        /// </summary>
        /// <param name="sort"></param>
        /// <returns></returns>
        public IEnumerable<IGrouping<int, Contract>> GroupNannyDistance(bool sort = false)
        {
            IEnumerable<IGrouping<int, Contract>> groupOfDistance = null;
            if (sort == true)
            {
                groupOfDistance = from item in GetAllContract()
                                  let mom = GetMother(item.IdMother)
                                  let nanny = GetNanny(item.IdNanny)
                                  let distance = CalculateDistance(mom.Address, nanny.Address)
                                  orderby distance
                                  group item by ((int)distance / 5 + 1) * 5;
            }
            else
            {
                groupOfDistance = from item in GetAllContract()
                                  let mom = GetMother(item.IdMother)
                                  let nanny = GetNanny(item.IdNanny)
                                  let distance = CalculateDistance(mom.Address, nanny.Address)
                                  group item by ((int)distance / 5 + 1) * 5;
            }
            return groupOfDistance;
        }
        #endregion
    }
}
