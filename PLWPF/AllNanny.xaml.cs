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
    /// Interaction logic for AllNanny.xaml
    /// </summary>
    public partial class AllNanny : Window
    {
        IBL bl;
        Nanny nanny;
        List<TimeSpan> TimeSpanList = new List<TimeSpan>();// definition of the matrix 
        public Nanny nanny1;
        public Nanny nanny2;
        /// <summary>
        /// updating the grid on the windows
        /// </summary>
        public AllNanny()//c-tor
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            nanny = new Nanny();
            this.DataContext = nanny;
            nanny1 = new Nanny();
            nanny2 = new Nanny();
            nanny1.DateBirth = DateTime.Now;
            nanny2.DateBirth = DateTime.Now;

            // initilaization of TimeSpanList
            for (int i = 0; i <= 23; i++)
            {
                TimeSpanList.Add(new TimeSpan(i, 0, 0));
                TimeSpanList.Add(new TimeSpan(i, 30, 0));
            }
            // enter all values in comboBox 
            // begin add
            this.SundayComboBoxBegin.ItemsSource = TimeSpanList;
            this.MondayComboBoxBegin.ItemsSource = TimeSpanList;
            this.TuesdayComboBoxBegin.ItemsSource = TimeSpanList;
            this.WednesdayComboBoxBegin.ItemsSource = TimeSpanList;
            this.ThursdayComboBoxBegin.ItemsSource = TimeSpanList;
            this.FridayComboBoxBegin.ItemsSource = TimeSpanList;
            this.SaturdayComboBoxBegin.ItemsSource = TimeSpanList;
            // end add
            this.SundayComboBoxEnd.ItemsSource = TimeSpanList;
            this.MondayComboBoxEnd.ItemsSource = TimeSpanList;
            this.TuesdayComboBoxEnd.ItemsSource = TimeSpanList;
            this.WednesdayComboBoxEnd.ItemsSource = TimeSpanList;
            this.ThursdayComboBoxEnd.ItemsSource = TimeSpanList;
            this.FridayComboBoxEnd.ItemsSource = TimeSpanList;
            this.SaturdayComboBoxEnd.ItemsSource = TimeSpanList;
            // begin update
            this.SundayComboBoxBegin1.ItemsSource = TimeSpanList;
            this.MondayComboBoxBegin1.ItemsSource = TimeSpanList;
            this.TuesdayComboBoxBegin1.ItemsSource = TimeSpanList;
            this.WednesdayComboBoxBegin1.ItemsSource = TimeSpanList;
            this.ThursdayComboBoxBegin1.ItemsSource = TimeSpanList;
            this.FridayComboBoxBegin1.ItemsSource = TimeSpanList;
            this.SaturdayComboBoxBegin1.ItemsSource = TimeSpanList;
            // end update 
            this.SundayComboBoxEnd1.ItemsSource = TimeSpanList;
            this.MondayComboBoxEnd1.ItemsSource = TimeSpanList;
            this.TuesdayComboBoxEnd1.ItemsSource = TimeSpanList;
            this.WednesdayComboBoxEnd1.ItemsSource = TimeSpanList;
            this.ThursdayComboBoxEnd1.ItemsSource = TimeSpanList;
            this.FridayComboBoxEnd1.ItemsSource = TimeSpanList;
            this.SaturdayComboBoxEnd1.ItemsSource = TimeSpanList;

            // enter all the data to the window
            Addgrid1.DataContext = nanny1;
            grid4.DataContext = nanny2;
            UpdateAllComboBox();
        }
        /// <summary>
        /// Updating all the combo box on the nanny window
        /// </summary>
        public void UpdateAllComboBox()
        {

            this.idComboBox.ItemsSource = bl.GetAllNanny();
            this.idComboBox.DisplayMemberPath = "Id";
            this.idComboBox.SelectedValuePath = "Id";

            this.genderNanComboBox.ItemsSource = Enum.GetValues(typeof(BE.Gender));
            this.genderNanComboBox1.ItemsSource = Enum.GetValues(typeof(BE.Gender));

            this.LanguagesComboBox.ItemsSource = Enum.GetValues(typeof(BE.Languages));
            this.languageNannyComboBox.ItemsSource = Enum.GetValues(typeof(BE.Languages));

            this.religionNComboBox.ItemsSource = Enum.GetValues(typeof(BE.Religion));
            this.religionNComboBox1.ItemsSource = Enum.GetValues(typeof(BE.Religion));


            this.removeidComboBox.ItemsSource = bl.GetAllNanny();
            this.removeidComboBox.DisplayMemberPath = "Id";
            this.removeidComboBox.SelectedValuePath = "Id";
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            //System.Windows.Data.CollectionViewSource nannyViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("nannyViewSource")));
            // Charger les données en définissant la propriété CollectionViewSource.Source :
            // nannyViewSource.Source = [source de données générique]
        }
        /// <summary>
        /// adding a nanny to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // enter all the data of the window to the "Worked" property of nanny 
                nanny1.Worked[0] = (bool)this.SundayCheckBox.IsChecked;
                nanny1.Worked[1] = (bool)this.MondayCheckBox.IsChecked;
                nanny1.Worked[2] = (bool)this.TuesdayCheckBox.IsChecked;
                nanny1.Worked[3] = (bool)this.WednesdayCheckBox.IsChecked;
                nanny1.Worked[4] = (bool)this.ThursdayCheckBox.IsChecked;
                nanny1.Worked[5] = (bool)this.FridayCheckBox.IsChecked;
                nanny1.Worked[6] = (bool)this.SaturdayCheckBox.IsChecked;
               
                // dependcy property 
                nanny1.MinAge = this.userCmin.Value;
                nanny1.MaxAge = this.userCmax.Value;
                // add the nanny
                bl.AddNanny(nanny1);
                // reinisalization 
                nanny1 = new Nanny();
                nanny1.DateBirth = DateTime.Now; 
                Addgrid1.DataContext = nanny1;
                this.userCmax.Value = 0;
                this.userCmin.Value = 0; 
                UpdateAllComboBox();
                MessageBox.Show("This nanny was added successfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// Updating a nanny to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (nanny2 != null)
                {
                    this.SundayCheckBox1.IsChecked = nanny2.Worked[0];
                    this.MondayCheckBox1.IsChecked = nanny2.Worked[1];
                    this.TuesdayCheckBox1.IsChecked = nanny2.Worked[2];
                    this.WednesdayCheckBox1.IsChecked = nanny2.Worked[3];
                    this.ThursdayCheckBox1.IsChecked = nanny2.Worked[4];
                    this.FridayCheckBox1.IsChecked = nanny2.Worked[5];
                    this.SaturdayCheckBox1.IsChecked = nanny2.Worked[6];
                    // update the dependcy property 
                    this.userCmin1.Value = nanny2.MinAge;
                    this.userCmax1.Value = nanny2.MaxAge;
                    bl.UpdateNanny(nanny2);
                }
                nanny2 = new Nanny();
                grid4.DataContext = nanny2;
                nanny2.DateBirth = DateTime.Now; 
                idComboBox.ItemsSource = null;
                this.userCmax1.Value = 0;
                this.userCmin1.Value = 0;
                UpdateAllComboBox();
                MessageBox.Show("This nanny was updated sccessfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// copying all the relevent data to a nanny so we could use it to update all the data when a nanny is choosen 
        /// in the relevent combo box
        /// </summary>
        /// <param name="na"></param>
        /// <returns>Nanny</returns>
        private Nanny CopyC(Nanny na)
        {
            if (na == null)
            {
                return null;
            }
            Nanny n = new Nanny();
            n.Id = na.Id;
            n.Name = na.Name;
            n.LastName = na.LastName;
            n.DateBirth = na.DateBirth;
            n.GenderNan = na.GenderNan;          
            n.Address = na.Address;           
            n.Floor = na.Floor;
            n.Elevator = na.Elevator;
            n.Phone = na.Phone;
            n.Email = na.Email;
            n.HourTariff = na.HourTariff;
            n.PerHour = na.PerHour;
            n.PerMonth = na.PerMonth;
            n.Cash = na.Cash;
            n.MinAge = na.MaxAge ;
            n.MaxAge = na.MaxAge;
            n.YearOfExperience = na.YearOfExperience;
            n.ExperienceWithInNeeds = na.ExperienceWithInNeeds;
            n.MaxKids = na.MaxKids;
            n.HasCar = na.HasCar;
            n.ReligionN = na.ReligionN;
            n.LanguageNanny = na.LanguageNanny;
            n.Smokes = na.Smokes;
            n.DrinksAlcool = na.DrinksAlcool;
            n.VacDays = na.VacDays;
            for (int i = 0; i < 7; i++)
            {
                n.Worked[i] = na.Worked[i];
                n.Schedule[0, i] = na.Schedule[0, i];
                n.Schedule[1, i] = na.Schedule[1, i];
            }
            return n;
        }
        /// <summary>
        /// When nanny selected in combo box- all field updates to the nanny selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)//update
        {
            Nanny n = idComboBox.SelectedItem as Nanny;
            if (n != null)
            {  
                this.userCmin1.Value = n.MinAge;
                this.userCmax1.Value = n.MaxAge;
                nanny2 = CopyC(n);
                grid4.DataContext = nanny2;

                if (nanny2.Worked[0]==true)
                {
                    SundayComboBoxBegin1.SelectedValue = n.Schedule[0, 0];
                    SundayComboBoxEnd1.SelectedValue = n.Schedule[1, 0];
                }
                if (nanny2.Worked[1] == true)
                {
                    MondayComboBoxBegin1.SelectedValue = n.Schedule[0, 1];
                    MondayComboBoxEnd1.SelectedValue = n.Schedule[1, 1];
                }
                if (nanny2.Worked[2] == true)
                {
                    TuesdayComboBoxBegin1.SelectedValue = n.Schedule[0, 2];
                    TuesdayComboBoxEnd1.SelectedValue = n.Schedule[1, 2];
                }
                if (nanny2.Worked[3] == true)
                {
                    WednesdayComboBoxBegin1.SelectedValue = n.Schedule[0, 3];
                   WednesdayComboBoxEnd1.SelectedValue = n.Schedule[1, 3];
                }
                if (nanny2.Worked[4] == true)
                {
                    ThursdayComboBoxBegin1.SelectedValue = n.Schedule[0, 4];
                    ThursdayComboBoxEnd1.SelectedValue = n.Schedule[1, 4];
                }
                if (nanny2.Worked[5] == true)
                {
                    FridayComboBoxBegin1.SelectedValue = n.Schedule[0, 5];
                    FridayComboBoxEnd1.SelectedValue = n.Schedule[1, 5];
                }
                if (nanny2.Worked[6] == true)
                {
                    SaturdayComboBoxBegin1.SelectedValue = n.Schedule[0, 6];
                    SaturdayComboBoxEnd1.SelectedValue = n.Schedule[1, 6];
                }
            }
        }
        /// <summary>
        /// removing a nanny from the system, sends an exeption if no nanny chas been choosen
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// </summary>

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Nanny n = removeidComboBox.SelectedItem as Nanny;
                if (n == null)
                    throw new Exception("You must choose a nanny first");
                bl.RemoveNanny(n.Id);
                //removeidComboBox.ItemsSource = null;
                UpdateAllComboBox();
                MessageBox.Show("This nanny was removed successfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        #region Matrix Updating
        /// <summary>
        /// Add Matrix: define a new TimeSpan enter the item which was selected to it and enter this in this place in the matrix 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SundayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxBegin.SelectedItem;
            nanny1.Schedule[0, 0] = dateT;
        }
        private void MondayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxBegin.SelectedItem;
            nanny1.Schedule[0, 1] = dateT;
        }
        private void TuesdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxBegin.SelectedItem;
            nanny1.Schedule[0, 2] = dateT;
        }
        private void WednesdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxBegin.SelectedItem;
            nanny1.Schedule[0, 3] = dateT;
        }
        private void ThursdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxBegin.SelectedItem;
            nanny1.Schedule[0, 4] = dateT;
       }
        private void FridayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin.SelectedItem;
            nanny1.Schedule[0, 5] = dateT;
        }
        private void SaturdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin.SelectedItem;
            nanny1.Schedule[0, 6] = dateT;
        }
        private void SundayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxEnd.SelectedItem;
            nanny1.Schedule[1, 0] = dateT;
        }
        private void MondayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxEnd.SelectedItem;
            nanny1.Schedule[1, 1] = dateT;
        }
        private void TuesdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxEnd.SelectedItem;
            nanny1.Schedule[1, 2] = dateT;
        }
        private void WednesdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxEnd.SelectedItem;
            nanny1.Schedule[1, 3] = dateT;
        }
        private void ThursdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxEnd.SelectedItem;
            nanny1.Schedule[1, 4] = dateT;
        }
        private void FridayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxEnd.SelectedItem;
            nanny1.Schedule[1, 5] = dateT;
        }
        private void SaturdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SaturdayComboBoxEnd.SelectedItem;
            nanny1.Schedule[1, 6] = dateT;
        }

        /// <summary>
        /// Updating Matrix: define a new TimeSpan enter the item which was selected to it and enter this in this place in the matrix 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SundayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxBegin1.SelectedItem;
            nanny2.Schedule[0, 0] = dateT;
        }
        private void MondayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxBegin1.SelectedItem;
            nanny2.Schedule[0, 1] = dateT;
        }
        private void TuesdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxBegin1.SelectedItem;
            nanny2.Schedule[0, 2] = dateT;
        }
        private void WednesdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxBegin1.SelectedItem;
            nanny2.Schedule[0, 3] = dateT;
        }
        private void ThursdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxBegin1.SelectedItem;
            nanny2.Schedule[0, 4] = dateT;
        }
        private void FridayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin1.SelectedItem;
            nanny2.Schedule[0, 5] = dateT;
        }
        private void SaturdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin1.SelectedItem;
            nanny2.Schedule[0, 6] = dateT;
        }
        private void SundayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxEnd1.SelectedItem;
            nanny2.Schedule[1, 0] = dateT;
        }
        private void MondayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxEnd1.SelectedItem;
            nanny2.Schedule[1, 1] = dateT;
        }
        private void TuesdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxEnd1.SelectedItem;
            nanny2.Schedule[1, 2] = dateT;
        }
        private void WednesdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxEnd1.SelectedItem;
            nanny2.Schedule[1, 3] = dateT;
        }
        private void ThursdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxEnd1.SelectedItem;
            nanny2.Schedule[1, 4] = dateT;
        }
       private void FridayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxEnd1.SelectedItem;
            nanny2.Schedule[1, 5] = dateT;
        }
        private void SaturdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SaturdayComboBoxEnd1.SelectedItem;
            nanny2.Schedule[1, 6] = dateT;
        }
        #endregion
        /// <summary>
        /// in add: check if the user choose Saturday so message of "Shabbat Chalom"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaturdayCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Shabbat Shalom! :)");
            SaturdayCheckBox.IsChecked = false;
        }
        /// <summary>
        /// in update: check if the user choose Saturday so message of "Shabbat Chalom"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaturdayCheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Shabbat Shalom! :)");
            SaturdayCheckBox1.IsChecked = false;
        }
    }
}
