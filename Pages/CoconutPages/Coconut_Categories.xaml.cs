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

namespace Coco_Master.Pages.CoconutPages
{

    public partial class Coconut_Categories : Page
    {
        public Coconut_Categories()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            string CmdString = string.Empty;

            using (SqlConnection con = new SqlConnection(ConString))

            {

                CmdString = "SELECT Id,Name,Stocks,UnitPrice FROM CoconutCategory";

                SqlCommand cmd = new SqlCommand(CmdString, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable("CoconutCategory");

                sda.Fill(dt);

                dgvCategories.ItemsSource = dt.DefaultView;
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {



            MessageBox.Show("we will be arranged that facility zoon  wait for it !!!!!");




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
                        CmdString = "DELETE FROM CoconutCategory WHERE Id = '" + id + "'";
                        SqlCommand cmd = new SqlCommand(CmdString, con);
                        cmd.ExecuteNonQuery();


                        con.Close();

                        MessageBox.Show("Record successfully deleted!", "Succesfull");

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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {


            FillDataGrid();
            btnBack.Visibility = Visibility.Hidden;
            txtboxFilter.Text = "";

        }

        private void btnNewCategory_Click(object sender, RoutedEventArgs e)
        {
            new AddNewCoconutCategory().Show();
        }

        private void dgvCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
