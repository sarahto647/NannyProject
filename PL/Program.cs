/* Name of course: .NET (Mini Proyekt)
 * Name of file: dotNet5778_02_1196_3884
 * Name of students: Sarah Tordjman (327321196) and Morgane Ankonina (208883884)
 * Date: 16/12/2017
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using BL;
using DS;


namespace PL
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("PL\n");
            //try
            //{
            //    BL.IBL bl = FactoryBL.GetBL();

            //    #region CHECK  THE BASIC FUNC
            //    //NANNY FUNCTIONS
            //    Nanny nan = bl.GetNanny(208883886);//get
            //    nan.DrinksAlcool = true;
            //    bl.UpdateNanny(nan);//update
            //    Nanny non = new Nanny
            //    {
            //        Id = 888203664,
            //        LastName = "Akonina",
            //        Name = "Morgane",
            //        GenderNan = Gender.female,
            //        DateBirth = new DateTime(2016, 3, 1, 7, 0, 0),
            //        Phone = "123456789",
            //        Street = "Beit Hadfous",
            //        City = "Jerusalem",
            //        Contry = "Israel",
            //        Elevator = true,
            //        Floor = 4,
            //        YearOfExperience = 5,
            //        ExperienceWithInNeeds = false,
            //        MaxKids = 6,
            //        MinAge = 1,
            //        MaxAge = 4,
            //        HourTariff = true,
            //        Cash = true,
            //        PerHour = 38,
            //        PerMonth = 5481,
            //        Worked = new bool[7] { true, true, false, true, true, true, false },
            //        VacDays = true,
            //        Recommendations = "great babysiter",
            //        HasCar = false,
            //        DrinksAlcool = false,
            //        Smokes = false
            //    };
            //    bl.UpdateNanny(non);//no such nanny
            //    bl.AddNanny(non);//over 18
            //    IEnumerable<Nanny> checkNANNY = bl.GetAllNanny();//get all 
            //    // CHILD FUNCTIONS
            //    Child chi = bl.GetChild(987654321);//get
            //    chi.InDiapers = false;
            //    bl.UpdateChild(chi);//update
            //    bl.RemoveChild(chi.Id);
            //    Child cho = new Child
            //    {
            //        Id = 440444044,
            //        Name = "Hana",
            //        GenderKid = Gender.female,
            //        IdMom = 234504411,
            //        DateBirth = new DateTime(2017, 9, 11, 9, 0, 0),
            //        InNeed = false,
            //        NeedList = null,
            //        HasAllergies = true,
            //        Allergies = "peanuts, avocado, lactoze intolerance",
            //        SpecialMedication = false,
            //        InDiapers = false,
            //        HasNanny = false,
            //    };
            //    bl.RemoveChild(44);//no such kid
            //    bl.UpdateChild(cho);//no such kid
            //    IEnumerable<Child> checkCHILD = bl.GetAllChild();//get all 

            //    // MOTHER FUNCTIONS
            //    Mother mom = bl.GetMother(234523654);//get
            //    mom.Phone = "0500000000";
            //    bl.UpdateMother(mom);//update
            //    bl.RemoveMother(mom.Id);//remove
            //    Mother mim = new Mother
            //    {
            //        Id = 999909947,
            //        LastName = "Tordjman",
            //        Name = "Yael",
            //        Phone = "987654321",
            //        Street = "Nahal Lashish",
            //        City = "Beit-Shemesh",
            //        Contry = "Israel",
            //        AddressArea = "Beith Adfoouss 7, Jerusalem",
            //        NeedNanny = new bool[7] { true, true, false, true, true, true, false },
            //        Remarks = "something",
            //        FamilySituation = "Married+4",
            //        Smokes = false,
            //        EmergencyContact = "Father-654321987, Sister=32165497"
            //    };
            //    bl.UpdateMother(mim);//no such mom
            //    bl.RemoveMother(mim.Id);//no such mom
            //    IEnumerable<Mother> checkMOTHER = bl.GetAllMother();//get all

            //    //CONTRACT FUNCTION
            //    Contract con = bl.GetContract(89745632);
            //    con.HOrM = HourOrMonth.month;
            //    bl.UpdateContract(con);
            //    Contract cin = new Contract
            //    {
            //        ContractNum = 1002111,
            //        IdNanny = 123256984,
            //        IdChild = 308836547,
            //        IdMother = 234545698,
            //        Meeting = false,
            //        ContractSigned = false,
            //        PerHour = 30.5,
            //        PerMonth = 6500.5,
            //        HOrM = HourOrMonth.hour,
            //        DateDealBegin = new DateTime(2017, 1, 11, 9, 0, 0),
            //        DateDealEnd = new DateTime(2020, 1, 11, 9, 0, 0),
            //        Remarks = null,
            //    };
            //    bl.AddContract(cin);//cant little kid
            //    bl.RemoveContract(89745632);//remove
            //    bl.RemoveContract(1111);//doesnt exist
            //    bl.UpdateContract(cin);//no such contract
            //    IEnumerable<Contract> checkCONTRACT = bl.GetAllContract();//get all
            //    #endregion

            //    #region CHECKING THE ADDITIONAL FUNCTION

            //    Mother mum = bl.GetMother(234523654);
            //    IEnumerable<Nanny> checkMatch = bl.MatchNanny(mum);
            //    foreach (Nanny item in checkMatch)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Nanny> checkClosestMatch = bl.ClosestMatch(mum);
            //    foreach (Nanny item in checkClosestMatch)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Child> checkNoNanny = bl.ChildNoNannyFound();
            //    foreach (Child item in checkNoNanny)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Nanny> checkNannyTAMAT = bl.NannyTAMAT();
            //    foreach (Nanny item in checkNannyTAMAT)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Contract> checkContractMatchCondition = bl.ConractMatchCondition();
            //    foreach (Contract item in checkContractMatchCondition)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    int ContractMatchConditionNum = bl.ConractMatchConditionNum();
            //    Console.WriteLine(ContractMatchConditionNum);

            //    IEnumerable<Nanny> checkDistanceAddress = bl.DistanceAddress(mum);
            //    foreach (Nanny item in checkDistanceAddress)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Nanny> checkWithExperienceInNeeds = bl.WithExperienceInNeeds();
            //    foreach (Nanny item in checkWithExperienceInNeeds)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Nanny> checkNannyCar = bl.WithCar();
            //    foreach (Nanny item in checkNannyCar)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Child> checkChildrensAllergies = bl.ChildAllergies();
            //    foreach (Child item in checkChildrensAllergies)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Nanny> checkNannyNoSmokeAlcool = bl.NannyNoSmokeNoAlcool();
            //    foreach (Nanny item in checkNannyNoSmokeAlcool)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Nanny> checkNannyFloor = bl.FloorOk();
            //    foreach (Nanny item in checkNannyFloor)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    IEnumerable<Nanny> checkNannySameCity = bl.SameCity();
            //    foreach (Nanny item in checkNannySameCity)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    IEnumerable<IGrouping<float, Nanny>> nana = bl.GroupChildAge(true, true);
            //    foreach (Nanny item in nana)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Mother mother = new Mother
            //    {
            //        Id = 234585412,
            //        LastName = "Tordjman",
            //        Name = "Yael",
            //        Phone = "987654321",
            //        Street = "Nahal Lashish",
            //        City = "Beit-Shemesh",
            //        Contry = "Israel",
            //        AddressArea = "Beith Hadfouss7, Jerusalem",
            //        NeedNanny = new bool[7] { true, true, false, true, true, true, false },
            //        Remarks = "something",
            //        FamilySituation = "Married+4",
            //        Smokes = false,
            //    };
            //    IEnumerable<Nanny> nn = bl.MatchNanny(mom);
            //    foreach (Nanny item in nn)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //#endregion
            //catch (Exception str)
            //{
            //    Console.WriteLine(str);
            //}
        }
    }
}