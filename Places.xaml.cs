using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for Places.xaml
    /// </summary>
    public partial class Places : Window
    {
        public Places()
        {
            InitializeComponent();
        }

       

        private void load(object sender, RoutedEventArgs e)
        {
            try

            {

                SqlConnection dbConnection = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST;Initial Catalog=IvanovaA_FinalProject;Integrated Security=True");

                dbConnection.Open();

                string qe = "Select * from Places";

                SqlCommand load = new SqlCommand(qe, dbConnection);

                load.ExecuteNonQuery();

                SqlDataAdapter ALoad = new SqlDataAdapter(load);

                DataTable DTLOAD = new DataTable();

                ALoad.Fill(DTLOAD);

                dataGrid.ItemsSource = DTLOAD.DefaultView;

                ALoad.Update(DTLOAD);

                

                dbConnection.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void back(object sender, RoutedEventArgs e)
        {
            HomePage lg = new HomePage();
            lg.Show();
            this.Close();
        }
    }
}
