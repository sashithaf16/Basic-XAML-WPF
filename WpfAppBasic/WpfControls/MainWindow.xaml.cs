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

namespace WpfControls
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

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name");
            sb.Append(empName.Text);
            sb.Append("Gender ?!");
            sb.Append((bool)male.IsChecked ? "male" : "female");
            sb.Append("Device");
            sb.Append((bool)yes.IsChecked ? "yes" : "no");
            sb.Append("Your Job");
            sb.Append(job.SelectedItem.ToString());
            sb.Append("Delivery Date");
            sb.Append(deliveryDate.SelectedDate.ToString());
            MessageBox.Show(sb.ToString());
        }
    }
}

