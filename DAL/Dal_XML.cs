using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using BE;
using System.Reflection;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DAL
{
    class Dal_XML : IDAL
    {
        //the main element in file
        private XElement childRoot;
        private XElement configRoot;

        // the placement of the files
        private string contractPath = "..//..//..//xmlFiles//ContractXML.xml";
        private string childPath = "..//..//..//xmlFiles//ChildXML.xml";
        private string motherPath = "..//..//..//xmlFiles//motherXML.xml";
        private string nannyPath = "..//..//..//xmlFiles//NannyXML.xml";
        private string configPath = "..//..//..//xmlFiles//ConfigXML.xml";
        /// <summary>
        /// //c-tor
        /// </summary>
        public Dal_XML()
        {
            try
            {
                #region open/creat all files
                //Linq to XML
                if (!File.Exists(childPath))
                {
                    childRoot = new XElement("childs");
                    childRoot.Save(childPath);
                }
                else
                {
                    LoadChild();
                }
                //serializer
                if (!File.Exists(contractPath))
                {
                    List<Contract> contractList = new List<Contract>();//empty list to create file
                    SaveToXML<List<Contract>>(contractList, contractPath);
                }
                if (!File.Exists(motherPath))
                {
                    List<Mother> motherList = new List<Mother>();//empty list to create file
                    SaveToXML<List<Mother>>(motherList, motherPath);
                }
                if (!File.Exists(nannyPath))
                {
                    List<Nanny> nannyList = new List<Nanny>();//empty list to create file
                    SaveToXML<List<Nanny>>(nannyList, nannyPath);
                }
                #endregion
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }
        /// <summary>
        /// loading path file
        /// </summary>
        private void LoadConfig()
        {
            try
            {
                configRoot = XElement.Load(configPath);// load a XElement from file 
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }
        /// <summary>
        /// loading path file
        /// </summary>
        private void LoadChild()
        {
            try
            {
                childRoot = XElement.Load(childPath);// load a XElement from file 
            }
            catch
            {
                throw new Exception("File upload problem");
            }
        }
        /// <summary>
        /// saves an Type to XML element
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="path"></param>
        public static void SaveToXML<T>(T source, string path)//save to xml file ,save object like element from program to file
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
            xmlSerializer.Serialize(file, source);
            file.Close();
        }
        /// <summary>
        /// loads a XML element to object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T LoadFromXML<T>(string path)//load object from element, from  file to program 
        {
            FileStream file = new FileStream(path, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            T result = (T)xmlSerializer.Deserialize(file);
            file.Close();
            return result;
        }
        #region CHILD FUNCTIONS
        //Linq to XML
        /// <summary>
        /// converts a child type to XML element
        /// </summary>
        /// <param name="child"></param>
        /// <returns></returns>
        XElement ChildToXML(Child child)
        {
            if (child == null)
                return null;
            XElement id = new XElement("id", child.Id);
            XElement name = new XElement("name", child.Name);
            XElement gender = new XElement("gender", child.GenderKid);
            XElement idMom = new XElement("idMom", child.IdMom);
            XElement dateBirth = new XElement("dateBirth", child.DateBirth);
            XElement inNeed = new XElement("inNeed", child.InNeed);
            XElement needList = new XElement("needList", child.NeedList);
            XElement hasAllergies = new XElement("hasAllergies", child.HasAllergies);
            XElement allergies = new XElement("allergies", child.Allergies);
            XElement specialMedication = new XElement("specialMedication", child.SpecialMedication);
            XElement inDiapers = new XElement("inDiapers", child.InDiapers);
            XElement hasNanny = new XElement("hasNanny", child.HasNanny);

            XElement childElement = new XElement("child", id, name, gender, idMom, dateBirth, inNeed, needList, hasAllergies, allergies, specialMedication, inDiapers, hasNanny);

            return childElement;
        }
        /// <summary>
        /// convert a XML element to Child
        /// </summary>
        /// <param name="xe"></param>
        /// <returns></returns>
        Child XMLToChild(XElement c)
        {
            if (c == null)
                return null;
            Child child = new Child() {
                Id = int.Parse(c.Element("id").Value),
                Name = c.Element("name").Value,
                GenderKid = (Gender)Enum.Parse(typeof(Gender), c.Element("gender").Value),
                IdMom = Convert.ToInt32(c.Element("idMom").Value),
                DateBirth = DateTime.Parse(c.Element("dateBirth").Value),
                InNeed = Convert.ToBoolean(c.Element("inNeed").Value),
                NeedList = c.Element("needList").Value,
                HasAllergies = Convert.ToBoolean(c.Element("hasAllergies").Value),
                Allergies = c.Element("allergies").Value,
                SpecialMedication = Convert.ToBoolean(c.Element("specialMedication").Value),
                InDiapers = Convert.ToBoolean(c.Element("inDiapers").Value),
                HasNanny = Convert.ToBoolean(c.Element("hasNanny").Value),
            };           
            return child;
        }
        /// <summary>
        /// Returns a Child from the list according to the id, if doesnt exist returns null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Child GetChild(int id)
        {
            LoadChild();
            // pass of all elements in childRoot, find the first child which correspond and return it 
            XElement chld = (from c in childRoot.Elements()
                             where (int.Parse(c.Element("id").Value)) == id
                             select c).FirstOrDefault();
            if (chld == null)
                return null;
            return XMLToChild(chld);
        }

        /// <summary>
        /// Adds a Child to the list, if already exist throw an exeption
        /// </summary>
        /// <param name="child"></param>
        public void AddChild(Child child)
        {
            
            LoadChild();
            if (child == null)
                return;
            if (GetChild(child.Id) != null)
                throw new Exception("Child is already in the system");
            childRoot.Add(ChildToXML(child));
            childRoot.Save(childPath);
        }

        /// <summary>
        /// Removes a Child from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="id"></param>
        public void RemoveChild(int id)
        {
            LoadChild();
            XElement childElement;
            try
            {
                Child check = GetChild(id);
                if (check == null)
                    throw new Exception("Child with this ID doesn't exists in the system\n");
                // pass of all elements in childRoot, find the first child which correspond and return it 
                childElement = (from c in childRoot.Elements()
                                where Convert.ToInt32(c.Element("id").Value) == id
                                select c).FirstOrDefault();
                childElement.Remove();
                childRoot.Save(childPath);
                return;
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Updates a Child from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="child"></param>
        public void UpdateChild(Child child)
        {
            LoadChild();
            if (GetChild(child.Id) == null || child == null)
                throw new Exception("Child doesn't exist in the system");
            // pass of all elements in childRoot, find the first child which correspond and return it 
            XElement childElement = (from c in childRoot.Elements()
                                     where Convert.ToInt32(c.Element("id").Value) == child.Id
                                     select c).FirstOrDefault();

            childElement.Element("id").Value = child.Id.ToString();
            childElement.Element("name").Value = child.Name.ToString();
            childElement.Element("gender").Value = child.GenderKid.ToString();
            childElement.Element("idMom").Value = child.IdMom.ToString();
            childElement.Element("dateBirth").Value = child.DateBirth.ToString();
            childElement.Element("inNeed").Value = child.InNeed.ToString();
            childElement.Element("needList").Value = child.NeedList.ToString();
            childElement.Element("hasAllergies").Value = child.HasAllergies.ToString();
            childElement.Element("allergies").Value = child.Allergies.ToString();
            childElement.Element("specialMedication").Value = child.SpecialMedication.ToString();
            childElement.Element("inDiapers").Value = child.InDiapers.ToString();
            childElement.Element("hasNanny").Value = child.HasNanny.ToString();

            childRoot.Save(childPath);

        }

        /// <summary>
        /// Gets all the Childs acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Child> GetAllChild(Func<Child, bool> predicate = null)
        {
            LoadChild();
            List<Child> childs = new List<Child>();
            try
            {
                // pass of all elements in childRoot, convert form each element from XML to Child
                var items = from temp in childRoot.Elements()
                            select XMLToChild(temp);
                childs = items.ToList();// to list 
            }
            catch
            {
                childs = null;
            }
            // if predicate exist so return all chils whose respect the predicate else return AsEnumerable 
            if (predicate != null)
                return childs.Where(predicate).AsEnumerable();
            return childs.AsEnumerable();
        }

        #endregion

        //serialize
        #region NANNY FUNCTIONS
        /// <summary>
        /// Returns a nanny from the list according to the id, if doesnt exist returns null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Nanny GetNanny(int id)
        {
            try
            {
                List<Nanny> nannylist = LoadFromXML<List<Nanny>>(nannyPath); //all nanny 
                return nannylist.FirstOrDefault(na => na.Id == id); // return the first nanny whose correspond 
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Adds a nanny to the list, if already exist throw an exeption
        /// </summary>
        /// <param name="nanny"></param>
        public void AddNanny(Nanny nanny)
        {
            try
            {
                if (GetNanny(nanny.Id) != null)
                    throw new Exception("Nanny with this ID already exist in the system/n");
                List<Nanny> nannylist = LoadFromXML<List<Nanny>>(nannyPath);// all nanny 
                nannylist.Add(nanny);
                SaveToXML<List<Nanny>>(nannylist, nannyPath);//save all nanny include new one
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Removes a Nanny from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="id"></param>
        public void RemoveNanny(int id)
        {

            try
            {              
                if (GetNanny(id) == null)
                    throw new Exception("Nanny with this ID doesn't exists in the system\n");
                List<Nanny> nannylist = LoadFromXML<List<Nanny>>(nannyPath);// all nanny 
                Nanny n = GetNanny(id);
                nannylist.Remove(n);
                SaveToXML<List<Nanny>>(nannylist, nannyPath);// save all nanny after remove the nanny 
                return;
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Updates a Nanny from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="nanny"></param>
        public void UpdateNanny(Nanny nanny)
        {
            try
            {
                if (GetNanny(nanny.Id) == null)
                    throw new Exception("This nanny doesn't exist in the system/n");
                List<Nanny> nannylist = LoadFromXML<List<Nanny>>(nannyPath);//all nanny
                int index = nannylist.FindIndex(na => na.Id == nanny.Id);// index of the wanted nanny in the list of nanny 
                nannylist[index] = nanny;
                SaveToXML<List<Nanny>>(nannylist, nannyPath);//save all nanny after the updating
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Gets all the nanny acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Nanny> GetAllNanny(Func<Nanny, bool> predicate = null)
        {
            try
            {
                List<Nanny> nannys = LoadFromXML<List<Nanny>>(nannyPath);//get all nanny
                // if predicate is null (does not exist) so return AsEnumerable else return all nanny whose respect this predicate 
                if (predicate == null)
                    return nannys.AsEnumerable();
                return nannys.Where(predicate);
            }
            catch
            {
                return null;
            }
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
            List<Mother> motherList = LoadFromXML<List<Mother>>(motherPath);//all mother
            return motherList.FirstOrDefault(mom => mom.Id == id);// return the first mother whose correspond 
        }
        /// <summary>
        /// Adds a mother to the list, if already exist throw an exeption
        /// </summary>
        /// <param name="mother"></param>
        public void AddMother(Mother mother)
        {
            if (GetMother(mother.Id) != null)
                throw new Exception("Mother with this ID already exists in the system\n");
            List<Mother> momList = LoadFromXML<List<Mother>>(motherPath);//all mother
            momList.Add(mother);
            SaveToXML<List<Mother>>(momList, motherPath);//save all mother include new one

        }
        /// <summary>
        /// Removes a Mother from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="id"></param>
        public void RemoveMother(int id)
        {
            try
            {
                if (GetMother(id) == null)
                    throw new Exception("Mother with this ID doesn't exists in the system\n");
                List<Mother> motherList = LoadFromXML<List<Mother>>(motherPath);
                motherList.Remove(GetMother(id));
                SaveToXML<List<Mother>>(motherList, motherPath);//save the mother list with all mother after remove one 
                return;
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Updates a Mother from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="mother"></param>
        public void UpdateMother(Mother mother)
        {
            try
            {
                if (GetMother(mother.Id) == null)
                    throw new Exception("This mother doesn't exist in the system\n");
                List<Mother> motherList = LoadFromXML<List<Mother>>(motherPath);
                int index = motherList.FindIndex(mom => mom.Id == mother.Id);// index of wanted contract in list
                motherList[index] = mother;
                SaveToXML<List<Mother>>(motherList, motherPath);// save the mother list after updating 
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Gets all the Mothers acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Mother> GetAllMother(Func<Mother, bool> predicate = null)
        {

            try
            {
                List<Mother> mothers = LoadFromXML<List<Mother>>(motherPath);//get all mothers
                // if predicate is null (does not exist) so return AsEnumerable else return all nanny whose respect this predicate 
                if (predicate == null)
                    return mothers.AsEnumerable();
                return mothers.Where(predicate);
            }
            catch
            {
                return null;
            }
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
            try
            {
                List<Contract> contractList = LoadFromXML<List<Contract>>(contractPath);// all contract 
                return contractList.FirstOrDefault(con => con.ContractNum == cn);// return the first contract which correspond 
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Adds a Contract to the list, if already exist/an error ocure throw an exeption
        /// </summary>
        /// <param name="contract"></param>
        public void AddContract(Contract contract)
        {
            try
            {
                if (GetContract(contract.ContractNum) != null)
                    throw new Exception("Contract is already in the system");

                XElement help = XElement.Load(configPath);
                int cc = int.Parse(help.Value);// convert to int 
                cc++; // advance the ContractNum
                contract.ContractNum = cc;
                
                help.Value = cc.ToString();// connvert to string 
                help.Save(configPath);// save in the file 

                List<Contract> contractList = LoadFromXML<List<Contract>>(contractPath);
                contractList.Add(contract);//add the new contract
                SaveToXML<List<Contract>>(contractList, contractPath);//save all contract list include new one in contract file 
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Removes a Contract from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="cn"></param>
        public void RemoveContract(int cn)
        {
            try
            {
                if (GetContract(cn) == null)
                    throw new Exception("This contract number doesn't exists in the system\n");
                List<Contract> contractList = LoadFromXML<List<Contract>>(contractPath);
                contractList.Remove(GetContract(cn));//remove the contract
                SaveToXML<List<Contract>>(contractList, contractPath);//save the contract list with all contract in contract file after rmove one 
                return;
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Updates a Contract from the list, if doesnt exist throws an exeption
        /// </summary>
        /// <param name="contract"></param>
        public void UpdateContract(Contract contract)
        {
            try
            {
                if (GetContract(contract.ContractNum) == null)
                    throw new Exception("This contract doesn't exist in the system\n");
                List<Contract> contractList = LoadFromXML<List<Contract>>(contractPath);
                int index = contractList.FindIndex(con => con.ContractNum == contract.ContractNum);//index of wanted contract in list
                contractList[index] = contract;
                SaveToXML<List<Contract>>(contractList, contractPath);//save the contract list with all contract in contract file after updating 
            }
            catch (Exception m)
            {
                throw new Exception(m.Message);
            }
        }
        /// <summary>
        /// Gets all the Contracts acording to a specific condition, if there is none predicate=null
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Contract> GetAllContract(Func<Contract, bool> predicate = null)
        {
            try
            {
                List<Contract> contractList = LoadFromXML<List<Contract>>(contractPath);
                // if predicate is null (does not exist) so return AsEnumerable else return all nanny whose respect this predicate 
                if (predicate == null)
                    return contractList.AsEnumerable();
                return contractList.Where(predicate);//return by condition
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
