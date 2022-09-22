using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace Coco_Master.Pages.EmployeePages
{
    public partial class Employees : Page
    {
        public Employees()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            new AddEmployee().Show();

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxFilter.Text == "")
            {

            }
            else
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                string CmdString = string.Empty;

                using (SqlConnection con = new SqlConnection(ConString))

                {

                    CmdString = "SELECT EmployeeId,EmployeeName,EmplyeeType,EmployeeContact,EmployeeSalary,EmployeeAddress FROM Employee WHERE EmployeeName = '" + txtboxFilter.Text.Trim() + "'";

                    SqlCommand cmd = new SqlCommand(CmdString, con);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("Employee");

                    sda.Fill(dt);

                    dgvEmployees.ItemsSource = dt.DefaultView;

                    con.Close();
                }

                btnBack.Visibility = Visibility.Visible;
            }


        }

       private void FillDataGrid()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                string CmdString = string.Empty;

                using (SqlConnection con = new SqlConnection(ConString))

                {

                    CmdString = "SELECT * FROM Employee";

                    SqlCommand cmd = new SqlCommand(CmdString, con);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("Employee");

                    sda.Fill(dt);

                    dgvEmployees.ItemsSource = dt.DefaultView;

                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + "/n" + ex);
            }

        } 

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
            btnBack.Visibility = Visibility.Hidden;
            txtboxFilter.Text = "";
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            String id = (string)btn.Tag;

            UpdateEmployee wd = new UpdateEmployee();
            wd.txtId.Text = id;
            wd.Show();
            return;

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("The record will be permanently deleted.", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                Button btn = (Button)sender;
                String id = (string)btn.Tag;

                try
                {
                    string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                    string CmdString = string.Empty;

                    using (SqlConnection con = new SqlConnection(ConString))

                    {
                        con.Open();
                        CmdString = "DELETE FROM Employee WHERE EmployeeId = '"+id+"'";
                        SqlCommand cmd = new SqlCommand(CmdString, con);
                        cmd.ExecuteNonQuery();
                        

                        con.Close();

                        MessageBox.Show("Record successfully deleted!","Succesfull");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Try Again" + "/n" + ex);
                }
                finally
                {
                    FillDataGrid();
                }

            }


        }

        private void dgvEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
