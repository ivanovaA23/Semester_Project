using System;
using System.Collections.Generic;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC14\LOCALHOST;Initial Catalog=IvanovaA_FinalProject;Integrated Security=True");
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="H:\12-5 Infromatics Yovchevski\Final Project\Yordanov_M_FinalProjectCS23\Yordanov_M_FinalProjectCS23\FinalProject.mdf";Integrated Security=True

            
                try
                {
                    sqlCon.Open();

                    string query = "INSERT INTO LogIn_Info(Username,Email,Password)values ('" + username.Text + "','" + email.Text + "','" + password.Text + "') ";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully registered");


                    LogIn lg = new LogIn();
                    lg.Show();
                    this.Close();

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
