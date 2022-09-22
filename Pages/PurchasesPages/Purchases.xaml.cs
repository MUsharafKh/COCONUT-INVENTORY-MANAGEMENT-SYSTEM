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

namespace Coco_Master.Pages.PurchasesPages
{
    /// <summary>
    /// Interaction logic for Purchases.xaml
    /// </summary>
    public partial class Purchases : Page
    {
        public Purchases()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                string CmdString = string.Empty;

                using (SqlConnection con = new SqlConnection(ConString))

                {

                    CmdString = "SELECT * FROM Purchases";

                    SqlCommand cmd = new SqlCommand(CmdString, con);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable("Purchases");

                    sda.Fill(dt);

                    dgvPurchases.ItemsSource = dt.DefaultView;

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
                        CmdString = "DELETE FROM Purchases WHERE Id = '" + id + "'";
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

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddNewPurchase_Click(object sender, RoutedEventArgs e)
        {
            new AddNewPurchase().Show();
        }

        private void dgvPurchases_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
