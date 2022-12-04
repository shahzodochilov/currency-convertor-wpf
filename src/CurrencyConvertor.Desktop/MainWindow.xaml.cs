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

namespace CurrencyConvertor.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string dollar = "USD";
        private const string som = "UZS";
        private double amount;
        public MainWindow()
        {
            InitializeComponent();
            From.Text = dollar;
            To.Text = som;
            MinHeight = 350;
            MinWidth = 400;
        }

        private void Exchange_Event(object sender, RoutedEventArgs e)
        {
            if (From.Text == dollar)
            {
                From.Text = som;
                To.Text = dollar;
            }
            else
            {
                From.Text = dollar;
                To.Text = som;
            }
        }
        private void Calculate_Event(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Amount.Text != "" && FromNumber.Text != "")
                {
                    amount = Convert.ToDouble(Amount.Text);
                    if (From.Text == dollar)
                    {
                        ToNumber.Text = String.Format("{0,12:N2}", (amount * Convert.ToDouble(FromNumber.Text)));
                    }
                    else
                    {
                        ToNumber.Text = String.Format("{0,12:N2}", (Convert.ToDouble(FromNumber.Text) / amount));
                    }
                }
                else
                {
                    MessageBox.Show("Qiymatlarni kiriting");
                }
            }
            catch
            {
                MessageBox.Show("Iltimos maydonni to'g'ri to'ldiring");
            }
        }
    }
}
