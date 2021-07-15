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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL.IBL bl;
        public MainWindow()//c-tor
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }
        /// <summary>
        /// Opens the nanny window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nanny_Click(object sender, RoutedEventArgs e)
        {
            Window Nanny = new AllNanny();
            Nanny.Show();
        }
        /// <summary>
        /// Opens the mother window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mother_Click(object sender, RoutedEventArgs e)
        {
            new AllMother().Show();
        }
        /// <summary>
        /// Opens the child window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Child_Click(object sender, RoutedEventArgs e)
        {
            new AllChild().Show();
        }
        /// <summary>
        /// Opens the contract window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Contract_Click(object sender, RoutedEventArgs e)
        {
            new AllContrat().Show();
        }
        /// <summary>
        /// Opens the manager window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Manager_Click(object sender, RoutedEventArgs e)
        {
            new ManagerOptions().Show();
        }
        /// <summary>
        /// Opens the linq window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Linq_Click(object sender, RoutedEventArgs e)
        {
            new AllLinq().Show();
        }
        /// <summary>
        /// closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        // just for fun 
        /// <summary>
        /// when we enter so tge color of the text is blue and underlined 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarryEnter(object sender, RoutedEventArgs e)
        {
            MarryPoppins.Foreground = System.Windows.Media.Brushes.Blue;
            MarryPoppins.TextDecorations = TextDecorations.Underline;// souligner 
        }
        /// <summary>
        /// when we leave so the color of the text is black 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarryLeave(object sender, RoutedEventArgs e)
        {
            MarryPoppins.Foreground = System.Windows.Media.Brushes.Black;
            MarryPoppins.TextDecorations = null;
        }
        /// <summary>
        /// when we click in the link go to video 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToLink(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=tRFHXMQP-QU");
        }
        /// <summary>
        /// function when we close the window the end 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
