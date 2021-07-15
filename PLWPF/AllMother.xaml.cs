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
using BL;
using BE;


namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AllMother.xaml
    /// </summary>
    public partial class AllMother : Window
    {
        IBL bl;
        Mother mother;
        List<TimeSpan> TimeSpanList = new List<TimeSpan>();// definition of the matrix 
        public Mother mom1;
        public Mother mom2;
        /// <summary>
        /// updating the grid on the windows
        /// </summary>
        public AllMother()//c-tor
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            mother = new Mother();
            this.DataContext = mother;
            mom1 = new Mother();
            mom2 = new Mother();

            languageMomComboBox.ItemsSource = Enum.GetValues(typeof(BE.Languages));
            religionComboBox.ItemsSource = Enum.GetValues(typeof(BE.Religion));
            languageMomComboBox1.ItemsSource = Enum.GetValues(typeof(BE.Languages));
            religionComboBox1.ItemsSource = Enum.GetValues(typeof(BE.Religion));

            // initialisation of TimeSpanList
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
            Addgrid1.DataContext = mom1;
            Updategrid2.DataContext = mom2;
            UpdateAllComboBox();
        }
        /// <summary>
        /// Updating all the combo box on the nanny window
        /// </summary>
        public void UpdateAllComboBox()
        {

            this.idComboBox.ItemsSource = bl.GetAllMother();
            this.idComboBox.DisplayMemberPath = "Id";
            this.idComboBox.SelectedValuePath = "Id";
           
            this.removeMotherComboBox.ItemsSource = bl.GetAllMother();
            this.removeMotherComboBox.DisplayMemberPath = "Id";
            this.removeMotherComboBox.SelectedValuePath = "Id";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //  System.Windows.Data.CollectionViewSource motherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("motherViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // motherViewSource.Source = [generic data source]
        }
        /// <summary>
        /// adding a mother to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMother_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // enter all the data of the window to the "NeedNanny" property of mother 
                mom1.NeedNanny[0] = (bool)this.SundayCheckBox.IsChecked;
                mom1.NeedNanny[1] = (bool)this.MondayCheckBox.IsChecked;
                mom1.NeedNanny[2] = (bool)this.TuesdayCheckBox.IsChecked;
                mom1.NeedNanny[3] = (bool)this.WednesdayCheckBox.IsChecked;
                mom1.NeedNanny[4] = (bool)this.ThursdayCheckBox.IsChecked;
                mom1.NeedNanny[5] = (bool)this.FridayCheckBox.IsChecked;
                mom1.NeedNanny[6] = (bool)this.SaturdayCheckBox.IsChecked;
                //add mother
                bl.AddMother(mom1);
                // reinisialisation 
                mom1 = new Mother();
                Addgrid1.DataContext = mom1;
                UpdateAllComboBox();
                MessageBox.Show("The mother was added successfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// Updating a mother to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateMother_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mom2 != null)
                {
                    this.SundayCheckBox1.IsChecked = mom2.NeedNanny[0];
                    this.MondayCheckBox1.IsChecked = mom2.NeedNanny[1];
                    this.TuesdayCheckBox1.IsChecked = mom2.NeedNanny[2];
                    this.WednesdayCheckBox1.IsChecked = mom2.NeedNanny[3];
                    this.ThursdayCheckBox1.IsChecked = mom2.NeedNanny[4];
                    this.FridayCheckBox1.IsChecked = mom2.NeedNanny[5];
                    this.SaturdayCheckBox1.IsChecked = mom2.NeedNanny[6];

                    bl.UpdateMother(mom2);
                }
                mom2 = new Mother();
                Updategrid2.DataContext = mom2;           
                idComboBox.DataContext = null;
                UpdateAllComboBox();
                MessageBox.Show("The mother was updated successfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// copying all the relevent data to a mother so we could use it to update all the data when a mother is choosen 
        /// in the relevent combo box
        /// </summary>
        /// <param name="na"></param>
        /// <returns></returns>       
        private Mother CopyC(Mother m)
        {
            if (m == null)
            {
                return null;
            }
            Mother mother = new Mother();
            mother.Id = m.Id;
            mother.Name = m.Name;
            mother.LastName = m.LastName;
            mother.Phone = m.Phone;
            mother.Address = m.Address;
            mother.AddressArea = m.AddressArea;
            mother.WantedDistance = m.WantedDistance;
            mother.EmergencyContact = m.EmergencyContact;
            mother.FamilySituation = m.FamilySituation;
            mother.ReligionM = m.ReligionM;
            mother.ImportantReligion = m.ImportantReligion;
            mother.LanguageMom = m.LanguageMom;
            mother.NumberOfChildren = m.NumberOfChildren;
            mother.Remarks = m.Remarks;
            mother.Smokes = m.Smokes;
            for (int i = 0; i < 7; i++)
            {
                mother.NeedNanny[i] = m.NeedNanny[i];
                mother.NeedSchedule[0, i] = m.NeedSchedule[0, i];
                mother.NeedSchedule[1, i] = m.NeedSchedule[1, i];
            }
            return mother;
        }
        /// <summary>
        /// When mother selected in combo box- all field updates to the mother selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mother mo = idComboBox.SelectedItem as Mother;
            if (mo != null)
            {
                mom2 = CopyC(mo);
                Updategrid2.DataContext = mom2;

                if (mom2.NeedNanny[0] == true)
                {
                    SundayComboBoxBegin1.SelectedValue = mo.NeedSchedule[0, 0];
                    SundayComboBoxEnd1.SelectedValue = mo.NeedSchedule[1, 0];
                }
                if (mom2.NeedNanny[1] == true)
                {
                    MondayComboBoxBegin1.SelectedValue = mo.NeedSchedule[0, 1];
                    MondayComboBoxEnd1.SelectedValue = mo.NeedSchedule[1, 1];
                }
                if (mom2.NeedNanny[2] == true)
                {
                    TuesdayComboBoxBegin1.SelectedValue = mo.NeedSchedule[0, 2];
                    TuesdayComboBoxEnd1.SelectedValue = mo.NeedSchedule[1, 2];
                }
                if (mom2.NeedNanny[3] == true)
                {
                    WednesdayComboBoxBegin1.SelectedValue = mo.NeedSchedule[0, 3];
                    WednesdayComboBoxEnd1.SelectedValue = mo.NeedSchedule[1, 3];
                }
                if (mom2.NeedNanny[4] == true)
                {
                    ThursdayComboBoxBegin1.SelectedValue = mo.NeedSchedule[0, 4];
                    ThursdayComboBoxEnd1.SelectedValue = mo.NeedSchedule[1, 4];
                }
                if (mom2.NeedNanny[5] == true)
                {
                    FridayComboBoxBegin1.SelectedValue = mo.NeedSchedule[0, 5];
                    FridayComboBoxEnd1.SelectedValue = mo.NeedSchedule[1, 5];
                }
                if (mom2.NeedNanny[6] == true)
                {
                    SaturdayComboBoxBegin1.SelectedValue = mo.NeedSchedule[0, 6];
                    SaturdayComboBoxEnd1.SelectedValue = mo.NeedSchedule[1, 6];
                }
            }
        }
        /// <summary>
        /// removing a mother from the system, sends an exeption if no mother chas been choosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveMother_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mother mo = removeMotherComboBox.SelectedItem as Mother;
                if (mo == null)
                    throw new Exception("You must choose a mother first");
                bl.RemoveMother(mo.Id);
                MessageBox.Show("The mother was removed successfully");
                removeMotherComboBox.ItemsSource = null;
                UpdateAllComboBox();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        #region Matrix 
        /// <summary>
        /// Add Matrix: define a new TimeSpan enter the item which was selected to it and enter this in this place in the matrix 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SundayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxBegin.SelectedItem;
            mom1.NeedSchedule[0, 0] = dateT;
        }
        private void MondayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxBegin.SelectedItem;
            mom1.NeedSchedule[0, 1] = dateT;
        }
        private void TuesdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxBegin.SelectedItem;
            mom1.NeedSchedule[0, 2] = dateT;
        }
        private void WednesdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxBegin.SelectedItem;
            mom1.NeedSchedule[0, 3] = dateT;
        }
        private void ThursdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxBegin.SelectedItem;
            mom1.NeedSchedule[0, 4] = dateT;
        }
        private void FridayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin.SelectedItem;
            mom1.NeedSchedule[0, 5] = dateT;
        }
        private void SaturdayComboBoxBegin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin.SelectedItem;
            mom1.NeedSchedule[0, 6] = dateT;
        }
        private void SundayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxEnd.SelectedItem;
            mom1.NeedSchedule[1, 0] = dateT;
        }
        private void MondayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxEnd.SelectedItem;
            mom1.NeedSchedule[1, 1] = dateT;
        }
        private void TuesdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxEnd.SelectedItem;
            mom1.NeedSchedule[1, 2] = dateT;
        }
        private void WednesdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxEnd.SelectedItem;
            mom1.NeedSchedule[1, 3] = dateT;
        }
       private void ThursdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxEnd.SelectedItem;
            mom1.NeedSchedule[1, 4] = dateT;
        }
        private void FridayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxEnd.SelectedItem;
            mom1.NeedSchedule[1, 5] = dateT;
        }
        private void SaturdayComboBoxEnd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SaturdayComboBoxEnd.SelectedItem;
            mom1.NeedSchedule[1, 6] = dateT;
        }
        /// <summary>
        /// Updating Matrix: define a new TimeSpan enter the item which was selected to it and enter this in this place in the matrix 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SundayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxBegin1.SelectedItem;
            mom2.NeedSchedule[0, 0] = dateT;
        }
        private void MondayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxBegin1.SelectedItem;
            mom2.NeedSchedule[0, 1] = dateT;
        }
        private void TuesdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxBegin1.SelectedItem;
            mom2.NeedSchedule[0, 2] = dateT;
        }
        private void WednesdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxBegin1.SelectedItem;
            mom2.NeedSchedule[0, 3] = dateT;
        }
        private void ThursdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxBegin1.SelectedItem;
            mom2.NeedSchedule[0, 4] = dateT;
        }
        private void FridayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin1.SelectedItem;
            mom2.NeedSchedule[0, 5] = dateT;
        }
        private void SaturdayComboBoxBegin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxBegin1.SelectedItem;
            mom2.NeedSchedule[0, 6] = dateT;
        }
        private void SundayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SundayComboBoxEnd1.SelectedItem;
            mom2.NeedSchedule[1, 0] = dateT;
        }
        private void MondayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)MondayComboBoxEnd1.SelectedItem;
            mom2.NeedSchedule[1, 1] = dateT;
        }
        private void TuesdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)TuesdayComboBoxEnd1.SelectedItem;
            mom2.NeedSchedule[1, 2] = dateT;
        }
        private void WednesdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)WednesdayComboBoxEnd1.SelectedItem;
            mom2.NeedSchedule[1, 3] = dateT;
        }
        private void ThursdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)ThursdayComboBoxEnd1.SelectedItem;
            mom2.NeedSchedule[1, 4] = dateT;
        }
        private void FridayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)FridayComboBoxEnd1.SelectedItem;
            mom2.NeedSchedule[1, 5] = dateT;
        }
        private void SaturdayComboBoxEnd1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeSpan dateT = (TimeSpan)SaturdayComboBoxEnd1.SelectedItem;
            mom2.NeedSchedule[1, 6] = dateT;
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