using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
using System.ComponentModel;
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
    /// Interaction logic for AllLinq.xaml
    /// </summary>
    public partial class AllLinq : Window
    {
        BL.IBL bl;

        public AllLinq()//c-tor
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();

            this.ClosestMatchCombo.ItemsSource = bl.GetAllMother();
            this.ClosestMatchCombo.DisplayMemberPath = "Id";
            this.ClosestMatchCombo.SelectedValuePath = "Id";

            this.AllMotherMatchNanny.ItemsSource = bl.GetAllMother();
            this.AllMotherMatchNanny.DisplayMemberPath = "Id";
            this.AllMotherMatchNanny.SelectedValuePath = "Id";
        }

        /// <summary>
        /// Shows all the nanny with a car
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NannyWitheCar_Click(object sender, RoutedEventArgs e)
        {
            this.listNanny.ItemsSource = bl.WithCar();
            return;
        }
        /// <summary>
        /// Shows all the nanny with experience with childs in need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WithExp_Click(object sender, RoutedEventArgs e)
        {
            this.listNanny.ItemsSource = bl.WithExperienceInNeeds();
            return;
        }
        /// <summary>
        /// Shows the 5 top nanny match for a mother acording to the working days
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosestMatch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mother mom = ClosestMatchCombo.SelectedItem as Mother;
                if (mom == null)
                    throw new Exception("You must choose a mother first");
                this.listNanny.ItemsSource = bl.ClosestMatch(mom);
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// Shows the 5 top nanny match for a mother acorrding to the working days and the work hours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatchNanny_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mother mom = AllMotherMatchNanny.SelectedItem as Mother;
                if (mom == null)
                    throw new Exception("You must choose a mother first");
                this.listNanny.ItemsSource = bl.MatchNanny(mom);
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }
        }

        /// <summary>
        /// Grouping the distance (pass of all the contract and calculate the distance between nanny and mother for each contract)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Distance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // using of thread 
                Thread tread = new Thread(() =>
                  {
                      try
                      {
                          var v = bl.GroupNannyDistance(true).ToList();
                          Action<IEnumerable<IGrouping<int, Contract>>> d = DistanceFind;
                          Dispatcher.BeginInvoke(d, v);
                      }
                      catch (Exception)
                      {
                          MessageBox.Show("Pb with the internet connection", "Check your adrress", MessageBoxButton.OK, MessageBoxImage.Error);
                      }
                  });
                tread.Start();
            }
            catch (Exception m)
            { 
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// function to show the grouping in the listViewG
        /// </summary>
        /// <param name="v"></param>
        private void DistanceFind(IEnumerable<IGrouping<int, Contract>> v)
        {
            try
            {
                this.listViewG.ItemsSource = v;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// end of all the thread when the window is closed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        /// <summary>
        /// Shows all the child that has no nanny yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChildNoNanny_Click(object sender, RoutedEventArgs e)
        {
            this.listChild.ItemsSource = bl.ChildNoNannyFound();
            return;
        }
        /// <summary>
        /// Shows all the child that have allergies
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HasAllergies_Click(object sender, RoutedEventArgs e)
        {
            this.listChild.ItemsSource = bl.ChildAllergies();
            return;
        }
        /// <summary>
        /// Grouping function-all the childs through age
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupByAge_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool? sort = sortedA.IsChecked;
                bool? byAge = sortByA.IsChecked;
                this.listViewG.ItemsSource = bl.GroupChildAge((bool)sort, (bool)byAge);
                return;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
