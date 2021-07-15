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
    /// Logique d'interaction pour UserC1.xaml
    /// </summary>
    public partial class UserC1 : UserControl
    {      
        // Using a DependencyProperty as the backing store for Value. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(float?), typeof(UserC1),
                new PropertyMetadata(null, PropertyChangedCallback, ValueCoerceValueCallback));

        public static object ValueCoerceValueCallback(DependencyObject d, object baseValue)
        {
            float? value = baseValue as float?;
            UserC1 THIS = d as UserC1;
            // if value is > of the maxValue so return the maxValue 
            if (value > THIS.MaxValue)
                return (float?)THIS.MaxValue;
            ///if value is < of the minValue so return the minValue 
            else if (value < THIS.MinValue)
                return (float?)THIS.MinValue;
            // if the value is in the range of maxValue and minValue so return the value 
            else return value;
        }

        public static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserC1 THIS = d as UserC1;
            THIS.txtNum.Text = THIS.Value == null ? "" : THIS.Value.ToString();
        }

        //property of UserC1
        public float? MinValue { get; set; }
        public float? MaxValue { get; set; }
        public float? Value
        {
            get { return (float?)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        /// <summary>
        /// c_tor 
        /// </summary>
        public UserC1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when we click Up so value++
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            Value++;
        }
        /// <summary>
        /// when we click Down so value--
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            Value--;
        }
        /// <summary>
        /// the text in middle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null || txtNum.Text == "-")
            { 
                return;
            }
            float val;
            // if txtNum is different to null so try to convert it, return if the conversion is succecced or not 
            if (!float.TryParse(txtNum.Text, out val))
                txtNum.Text = Value.ToString();
            else
                Value = val;
        }
    }
}