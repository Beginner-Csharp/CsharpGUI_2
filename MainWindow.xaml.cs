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

namespace ProjectGUI_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double income, expend, priceNeed, sumDay;

        private void TxtPriceNeed_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtExpend_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtsumDay_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TxtIncome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            income = Convert.ToDouble(txtIncome.Text);
            expend = Convert.ToDouble(txtExpend.Text);
            priceNeed = Convert.ToDouble(txtPriceNeed.Text);

            sumDay = priceNeed / (income - expend);

            txtsumDay.Text = sumDay.ToString();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtIncome.Clear();
            txtExpend.Clear();
            txtPriceNeed.Clear();
            txtsumDay.Clear();
        }


    }
}
