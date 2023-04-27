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

namespace final_project1
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        

        private void activities(object sender, RoutedEventArgs e)
        {
            Activities window3 = new Activities();
            window3.Show();
            this.Close();
        }

        private void placs(object sender, RoutedEventArgs e)
        {
            Places window3 = new Places();
            window3.Show();
            this.Close();
        }

        private void visits(object sender, RoutedEventArgs e)
        {
            Visits window3 = new Visits();
            window3.Show();
            this.Close();
        }
    }
}
