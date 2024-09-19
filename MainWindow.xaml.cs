using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture3Lab1
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double mm = Convert.ToDouble(MonthlyMortgage.Text);
            double bal = Convert.ToDouble(Balance.Text);

            double interest = bal * 0.0639 / 12;
            mm -= interest;

            Output.Content = interest + " goes into interest and " + mm + " goes into principal";

        }
    }
}