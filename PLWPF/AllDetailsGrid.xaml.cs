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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AllDetailsGrid.xaml
    /// </summary>
    public partial class AllDetailsGrid : Window
    {
        BL.IBL bl;
        //ctor
        public AllDetailsGrid()//ctor
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }
        /// <summary>
        /// Shows all nanny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nanny_Click(object sender, RoutedEventArgs e)
        {
            this.ShowAll.ItemsSource = bl.GetAllNanny();
            return;
        }
        /// <summary>
        /// Shows all mothers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mother_Click(object sender, RoutedEventArgs e)
        {
            this.ShowAll.ItemsSource = bl.GetAllMother();
            return;
        }
        /// <summary>
        /// Shows all childs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Child_Click(object sender, RoutedEventArgs e)
        {
            this.ShowAll.ItemsSource = bl.GetAllChild();
            return;
        }
        /// <summary>
        /// Shows all contracts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Contract_Click(object sender, RoutedEventArgs e)
        {
            this.ShowAll.ItemsSource = bl.GetAllContract();
            return;
        }
    }
}

