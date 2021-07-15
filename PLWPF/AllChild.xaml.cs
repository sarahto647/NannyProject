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
    /// Interaction logic for AllChild.xaml
    /// </summary>
    public partial class AllChild : Window
    {
        IBL bl;
        public Child child1;
        public Child child2;
        /// <summary>
        /// updating the grid on the windows
        /// </summary>
        public AllChild()//c-tor
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            child1 = new Child();
            child2 = new Child(); 
            child1.DateBirth = DateTime.Now;
            child2.DateBirth = DateTime.Now;
            Addgrid1.DataContext = child1;
            updategrid2.DataContext = child2;
            UpdateAllComboBox(); 
        }
        /// <summary>
        /// Updating all the combo box on the nanny window
        /// </summary>
        public void UpdateAllComboBox()
        {
            this.idMomComboBox.ItemsSource = bl.GetAllMother();
            this.idMomComboBox.DisplayMemberPath = "Id";
            this.idMomComboBox.SelectedValuePath = "Id";

            this.genderKidComboBox.ItemsSource = Enum.GetValues(typeof(BE.Gender));

            this.updateidComboBox.ItemsSource = bl.GetAllChild();
            this.updateidComboBox.DisplayMemberPath = "Id";
            this.updateidComboBox.SelectedValuePath = "Id";

            this.genderKidComboBox1.ItemsSource = Enum.GetValues(typeof(BE.Gender));

            this.removeidComboBox.ItemsSource = bl.GetAllChild();
            this.removeidComboBox.DisplayMemberPath = "Id";
            this.removeidComboBox.SelectedValuePath = "Id";  
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           // System.Windows.Data.CollectionViewSource childViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("childViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // childViewSource.Source = [generic data source]
        }
        /// <summary>
        /// adding a child to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddChild(child1);
                child1 = new Child();
                Addgrid1.DataContext = child1;
                child1.DateBirth = DateTime.Now;
                UpdateAllComboBox();
                MessageBox.Show("The child was added successfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
        /// <summary>
        /// Updating a child to the system, sends an exeption if something is typed wrongly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (child2!=null)
                {
                    bl.UpdateChild(child2);
                }             
                child2 = new Child();
                updategrid2.DataContext = child2;
                child2.DateBirth = DateTime.Now;
                UpdateAllComboBox();
                MessageBox.Show("The child was updated successfully");
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        /// <summary>
        /// copying all the relevent data to a child so we could use it to update all the data when a child is choosen 
        /// in the relevent combo box
        /// </summary>
        /// <param name="na"></param>
        /// <returns></returns>       
        private Child Copyc(Child c)
        {
            if (c == null)
            {
                return null;
            }
            return (new Child()
            {
                Id = c.Id,
                IdMom = c.IdMom,
                Name = c.Name,
                DateBirth = c.DateBirth,
                InNeed = c.InNeed,
                NeedList = c.NeedList,
                InDiapers = c.InDiapers,
                SpecialMedication = c.SpecialMedication,
                Allergies = c.Allergies,
                GenderKid = c.GenderKid,
                HasAllergies = c.HasAllergies
            });
        }
        /// <summary>
        /// When child selected in combo box- all field updates to the child selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateidComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Child c = updateidComboBox.SelectedItem as Child;
            if (c != null)
            {
                child2 = Copyc(c);
                updategrid2.DataContext = child2;
            }
        }
        /// <summary>
        /// removing a child from the system, sends an exeption if no child chas been choosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Child c = removeidComboBox.SelectedItem as Child;
                if (c == null)
                    throw new Exception("You must choose a child first");
                bl.RemoveChild((int)c.Id);
                MessageBox.Show("The child was removed successfully");
                this.removeidComboBox.ItemsSource = null;
                UpdateAllComboBox();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
