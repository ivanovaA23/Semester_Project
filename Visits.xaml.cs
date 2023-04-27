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
    /// Interaction logic for Visits.xaml
    /// </summary>
    public partial class Visits : Window
    {
        public Visits()
        {
            InitializeComponent();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            HomePage lg = new HomePage();
            lg.Show();
            this.Close();
        }

       

        private void add(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST;Initial Catalog=IvanovaA_FinalProject;Integrated Security=True");

            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = $"INSERT INTO Visits (Username, Location, Date) VALUES ('{username.Text}','{location.Text}', '{date.Text}');";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully added your visit");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void update(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST;Initial Catalog=IvanovaA_FinalProject;Integrated Security=True");

            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = $"UPDATE Visits SET Location = '{location.Text}'  WHERE Username = '{username.Text}' AND Date = '{date.Text}'; ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully updated your visit");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC16\LOCALHOST;Initial Catalog=IvanovaA_FinalProject;Integrated Security=True");

            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = $"DELETE FROM Visits WHERE Username = '{username.Text}' AND Date = '{date.Text}';";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully deleted the visit");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
