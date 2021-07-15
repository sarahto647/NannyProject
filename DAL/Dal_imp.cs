using DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    internal class Dal_imp : IDAL
    {
        #region NANNY FUNCTIONS
        /// <summary>
        /// Returns a nanny from the list according to the id, if doesnt exist returns null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Nanny GetNanny(int id)
        {
            if (DataSource.NannyList == null)
                return null;
            return DataSource.NannyList.FirstOrDefault(n => n.Id == id);
        }
        /// <summary>
        /// Adds a nanny to the list, if already exist throw an exeption
        /// </summary>
        /// <param name="nanny"></param>
        public void AddNanny(Nanny nanny)
        {
            Nanny nannycheck = GetNanny(nanny.Id);
            if (nannycheck != null)
                throw new Exception("Nanny with this ID already exists in the system\n");
            DataSource.NannyList.Add(nanny);
        }
        /// <summary>
        /// Removes a Nanny from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="id"></param>
        public void RemoveNanny(int id)
        {
            Nanny nannycheck = GetNanny(id);
            if (nannycheck == null)
                throw new Exception("Nanny with this ID doesn't exists in the system\n");
            DataSource.NannyList.Remove(nannycheck);
        }
        /// <summary>
        /// Updates a Nanny from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="nanny"></param>
        public void UpdateNanny(Nanny nanny)
        {
            int index = DataSource.NannyList.FindIndex(n => n.Id == nanny.Id);
            if (index == -1)
                throw new Exception("This nanny doesn't exist in the system\n");
            DataSource.NannyList[index] = nanny;
        }
        /// <summary>
        /// Gets all the nanny acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Nanny> GetAllNanny(Func<Nanny, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.NannyList.AsEnumerable();
            return DataSource.NannyList.Where(predicate);
        }
        #endregion
        #region MOTHER FUNCTIONS
        /// <summary>
        /// Returns a mother from the list according to the id, if doesnt exist returns null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Mother GetMother(int id)
        {
            if (DataSource.MotherList == null)
                return null;
            return DataSource.MotherList.FirstOrDefault(m => m.Id == id);
        }
        /// <summary>
        /// Adds a mother to the list, if already exist throw an exeption
        /// </summary>
        /// <param name="mother"></param>
        public void AddMother(Mother mother)
        {
            Mother mothercheck = GetMother(mother.Id);
            if (mothercheck != null)
                throw new Exception("Mother with this ID already exists in the system\n");
            DataSource.MotherList.Add(mother);
        }
        /// <summary>
        /// Removes a Mother from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="id"></param>
        public void RemoveMother(int id)
        {
            Mother mothercheck = GetMother(id);
            if (mothercheck == null)
                throw new Exception("Mother with this ID doesn't exists in the system\n");
            DataSource.MotherList.Remove(mothercheck);
        }
        /// <summary>
        /// Updates a Mother from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="mother"></param>
        public void UpdateMother(Mother mother)
        {
            int index = DataSource.MotherList.FindIndex(m => m.Id == mother.Id);
            if (index == -1)
                throw new Exception("This mother doesn't exist in the system\n");
            DataSource.MotherList[index] = mother;
        }
        /// <summary>
        /// Gets all the Mothers acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Mother> GetAllMother(Func<Mother, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.MotherList.AsEnumerable();
            return DataSource.MotherList.Where(predicate);
        }
        #endregion
        #region CHILD FUNCTIONS
        /// <summary>
        /// Returns a Child from the list according to the id, if doesnt exist returns null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Child GetChild(int id)
        {
            if (DataSource.ChildList == null)
                return null;
            return DataSource.ChildList.FirstOrDefault(c => c.Id == id);
        }
        /// <summary>
        /// Adds a Child to the list, if already exist throw an exeption
        /// </summary>
        /// <param name="child"></param>
        public void AddChild(Child child)
        {
            Child childcheck = GetChild((int)child.Id);
            if (childcheck != null)
                throw new Exception("Child with this ID already exists in the system\n");
           DataSource.ChildList.Add(child);
        }
        /// <summary>
        /// Removes a Child from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="id"></param>
        public void RemoveChild(int id)
        {
            Child childcheck = GetChild(id);
            if (childcheck == null)
                throw new Exception("Child with this ID doesn't exists in the system\n");
            DataSource.ChildList.Remove(childcheck);
        }
        /// <summary>
        /// Updates a Child from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="child"></param>
        public void UpdateChild(Child child)
        {
            int index = DataSource.ChildList.FindIndex(c => c.Id == child.Id);
            if (index == -1)
                throw new Exception("This child doesn't exist in the system\n");
            DataSource.ChildList[index] = child;
        }
        /// <summary>
        /// Gets all the Childs acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Child> GetAllChild(Func<Child, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.ChildList.AsEnumerable();
            return DataSource.ChildList.Where(predicate);
        }
        #endregion
        #region CONTRACT FUNCTIONS
        /// <summary>
        /// Returns a Contract from the list according to the id, if doesnt exist returns null
        /// </summary>
        /// <param name="cn"></param>
        /// <returns></returns>
        public Contract GetContract(int cn)
        {
            if (DataSource.ContractList == null)
                return null;
            return DataSource.ContractList.FirstOrDefault(c => c.ContractNum == cn);
        }
        /// <summary>
        /// Adds a Contract to the list, if already exist/an error ocure throw an exeption
        /// </summary>
        /// <param name="contract"></param>
        public void AddContract(Contract contract)
        {
            Child childcheck = GetChild(contract.IdChild);
            Mother mothercheck = GetMother(contract.IdMother);
            Nanny nannycheck = GetNanny(contract.IdNanny);
            Contract contractcheck = GetContract(contract.ContractNum);
            if (childcheck == null || nannycheck == null || mothercheck == null)
                throw new Exception("Please make sure you typed in the right ID for the folowing details: Mother, Nanny, Child\n");
            if (contractcheck != null)
                throw new Exception("This contract number already exists in the system\n");
            if (DataSource.ContractList.FirstOrDefault(c => (c.IdNanny == contract.IdNanny && c.IdChild == contract.IdChild)) != null)
                throw new Exception("A child cannot have more than 1 contract\n ");
            DataSource.ContractList.Add(contract);
        }
        /// <summary>
        /// Removes a Contract from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="cn"></param>
        public void RemoveContract(int cn)
        {
            Contract contractcheck = GetContract(cn);
            if (contractcheck == null)
                throw new Exception("This contract number doesn't exists in the system\n");
            DataSource.ContractList.Remove(contractcheck);
        }
        /// <summary>
        /// Updates a Contract from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="contract"></param>
        public void UpdateContract(Contract contract)
        {
            int index = DataSource.ContractList.FindIndex(c => c.ContractNum == contract.ContractNum);
            if (index == -1)
                throw new Exception("This contract doesn't exist in the system\n");
            
            DataSource.ContractList[index] = contract;
        }
        /// <summary>
        /// Gets all the Contracts acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null)
        {
            if (predicate == null)
                return DataSource.ContractList.AsEnumerable();
            return DataSource.ContractList.Where(predicate);
        }
        #endregion
    }
}