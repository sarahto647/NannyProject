using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BE;
using BL;
namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AllContrat.xaml
    /// </summary>
    public partial class AllContrat : Window
    {
        IBL bl;
        public Contract contract1;
        public Contract contract2;
        public string source;
        public string dest;
        public int distance;
        /// <summary>
        /// updating the grid on the windows
        /// </summary>
        public AllContrat()//c-tor
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            contract1 = new Contract();
            contract2 = new Contract();
            contract1.DateDealBegin = DateTime.Now;
            contract1.DateDealEnd = DateTime.Now;
            contract2.DateDealBegin = DateTime.Now;
            contract2.DateDealEnd = DateTime.Now;
            this.hOrMComboBox1.ItemsSource = Enum.GetValues(typeof(BE.HourOrMonth));
            this.hOrMComboBox.ItemsSource = Enum.GetValues(typeof(BE.HourOrMonth));
            Addgrid.DataContext = contract1;
            Updategrid.DataContext = contract2;
            UpdateAllCombox();
        }
        /// <summary>
        /// Updating all the combo box on the nanny window
        /// </summary>
        private void UpdateAllCombox()
        {
            this.idNannyComboBox.ItemsSource = bl.GetAllNanny();
            this.idNannyComboBox.DisplayMemberPath = "Id";
            this.idNannyComboBox.SelectedValuePath = "Id";

            this.idChildComboBox.ItemsSource = bl.GetAllChild();
            this.idChildComboBox.DisplayMemberPath = "Id";
            this.idChildComboBox.SelectedValuePath = "Id";

            this.idMotherComboBox.ItemsSource = bl.GetAllMother();
            this.idMotherComboBox.DisplayMemberPath = "Id";
            this.idMotherComboBox.SelectedValuePath = "Id";


            this.contractNumComboBox.ItemsSource = bl.GetAllContract();
            this.contractNumComboBox.DisplayMemberPath = "ContractNum";
            this.contractNumComboBox.SelectedValuePath = "ContractNum";


            this.removeContract.ItemsSource = bl.GetAllContract();
            this.removeContract.DisplayMemberPath = "ContractNum";
            this.removeContract.SelectedValuePath = "ContractNum";
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            //System.Windows.Data.CollectionViewSource contractViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contractViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // contractViewSource.Source = [generic data source]
        }
        /// <summary>
        /// adding a contract to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddContract(contract1);
                contract1 = bl.GetAllContract(c => c.IdChild == contract1.IdChild && c.IdNanny == contract1.IdNanny).FirstOrDefault();
                Addgrid.DataContext = contract1;
                MessageBox.Show("The contract N°" + contract1.ContractNum.ToString() + " was added successfully");
                contract1 = new Contract();
                Addgrid.DataContext = contract1;
                UpdateAllCombox();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// Updating a contract to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (contract2 != null)
                    bl.UpdateContract(contract2);
                contract2 = new Contract();
                Updategrid.DataContext = contract2;
                UpdateAllCombox();
                MessageBox.Show("The contract was updated successfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// copying all the relevent data to a contract so we could use it to update all the data when a contract is choosen 
        /// in the relevent combo box
        /// </summary>
        /// <param name="na"></param>
        /// <returns>Contract</returns>
        private Contract CopyC(Contract c)
        {
            if (c == null)
            {
                return null;
            }
            return (new Contract
            {
                ContractNum = c.ContractNum,
                ContractSigned = c.ContractSigned,
                IdNanny = c.IdNanny,
                DateDealBegin = c.DateDealBegin,
                DateDealEnd = c.DateDealEnd,
                IdChild = c.IdChild,
                IdMother = c.IdMother,
                Meeting = c.Meeting,
                PerHour = c.PerHour,
                PerMonth = c.PerMonth,
                Remarks = c.Remarks
            });
        }
        /// <summary>
        /// When contract selected in combo box- all field updates to the contract selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contractNumComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contract c = contractNumComboBox.SelectedItem as Contract;
            if (c != null)
            {
                contract2 = CopyC(c);
                Updategrid.DataContext = contract2;
            }
        }
        /// <summary>
        /// removing a contract from the system, sends an exeption if no contract chas been choosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Contract c = removeContract.SelectedItem as Contract;
                if (c == null)
                    throw new Exception("You must choose a contract first");
                bl.RemoveContract(c.ContractNum);
                MessageBox.Show("The contract was removed successfully");
                this.removeContract.ItemsSource = null;
                UpdateAllCombox();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// Cheks that it meets all the criteria  and if they are ad button is enable and you can add the contract to the system 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Nanny nanch = new Nanny();
                nanch = bl.GetNanny(contract1.IdNanny);
                if (nanch.HourTariff == false && contract1.HOrM == HourOrMonth.hour)
                    throw new Exception("Contract not valid: nanny does not accept payment by hour");
                Mother mom = new Mother();
                mom = bl.GetMother(contract1.IdMother);
                for (int i = 0; i < 7; i++)
                {
                    if (mom.NeedNanny[i] == true)
                    {
                        if (nanch.Worked[i] == false)// checking if the nanny worked 
                            throw new Exception("The needed workind days of the mother doesn't match the work days of the nanny");
                    }
                }
                // google map 
                source = mom.Address;
                dest = nanch.Address;
                System.ComponentModel.BackgroundWorker worker = new System.ComponentModel.BackgroundWorker();// execution of one operation a thread 
                worker.DoWork += W_DoWork;
                worker.RunWorkerCompleted += W_RunWorkerCompleted;
                if ((distance > mom.WantedDistance) && (mom.WantedDistance > 0))
                {
                    throw new Exception("The nanny is not in the range you asked for");
                }
                worker.RunWorkerAsync();// execution of the operation in the background
                // end google map 

                Add.IsEnabled = true;
            }  
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }
        /// <summary>
        /// Check the distance between a mother and a nanny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void W_DoWork(Object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                distance = bl.CalculateDistance(source, dest);
            }
            catch (Exception)
            {

                distance = -1;
            }
        }
        /// <summary>
        /// Verified the distance betwen the mother and the nanny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void W_RunWorkerCompleted(Object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            string check;
            if (distance != -1)
            {
                if (distance < 1000)
                {
                    check = "Nanny is located " + distance + " meters from you";
                    MessageBox.Show(check);
                }
                else
                {
                    check = "Nanny is located" + distance / 1000.01 + " meters from you";
                    MessageBox.Show(check);
                }
            }
            else
            {
                check = "Please check that the address of the nanny and the mother is correct";
                MessageBox.Show(check);
            }
        }
        /// <summary>
        /// Cheks that it meets all the criteria  and if they are ad button is enable and you can add the contract to the system 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Nanny nanch = new Nanny();
                nanch = bl.GetNanny(contract2.IdNanny);
                if (nanch.HourTariff == false && contract2.HOrM == HourOrMonth.hour)
                    throw new Exception("Contract not valid: nanny does not accept payment by hour");
                Mother mom = new Mother();
                mom = bl.GetMother(contract2.IdMother);
                for (int i = 0; i < 7; i++)
                {
                    if (mom.NeedNanny[i] == true)
                    {
                        if (nanch.Worked[i] == false)// checking if the nanny worked 
                            throw new Exception("The needed workind days of the mother doesn't match the work days of the nanny");

                    }
                }
                source = mom.Address;
                dest = nanch.Address;
                System.ComponentModel.BackgroundWorker worker = new System.ComponentModel.BackgroundWorker();// execution of one operation a thread 
                worker.DoWork += W_DoWork;
                worker.RunWorkerCompleted += W_RunWorkerCompleted;
                if ((distance > mom.WantedDistance) && (mom.WantedDistance > 0))
                {
                    throw new Exception("The nanny is not in the range you asked for");
                }
                worker.RunWorkerAsync();// execution of the operation in the background

                Update.IsEnabled = true;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }
    }
}
