using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;

namespace Coco_Master.Pages.CoconutPages
{
    /// <summary>
    /// Interaction logic for AddNewSale.xaml
    /// </summary>
    public partial class AddNewSale : Window
    {
        public AddNewSale()
        {
            InitializeComponent();
            
        }

        FocusEvent e1 = new FocusEvent();

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtId_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtId);
        }

        private void txtId_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtId);
        }

        private void txtCategoryId_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtCategoryId);
        }

        private void txtCategoryId_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtCategoryId);
        }

        private void txtCustomerID_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtCustomerID);
        }

        private void txtCustomerID_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtCustomerID);
        }

        private void txtSalesAmmount_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtSalesAmmount);
        }

        private void txtSalesAmmount_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtSalesAmmount);
        }

        private void txtQuantity_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtQuantity);
        }

        private void txtQuantity_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtQuantity);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            if (txtId.Text == "" || txtId.Text == "*")
            {
                MessageBox.Show("Enter the ID", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                txtId.Focus();
                return;


            }
            else if (txtCategoryId.Text == "" || txtCategoryId.Text == "*")
            {
                MessageBox.Show("Enter the category ID ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                txtCategoryId.Focus();
                return;

            }
         

            else if (txtCustomerID.Text == "" || txtCustomerID.Text == "*")
            {
                MessageBox.Show("Enter the Customer id", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                txtCustomerID.Focus();
                return;

            }
            else if (txtSalesAmmount.Text == "" || txtSalesAmmount.Text == "*")
            {
                MessageBox.Show("Enter the Sale Ammount ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSalesAmmount.Focus();
                return;

            }
            else if (txtQuantity.Text == "" || txtQuantity.Text == "*")
            {
                MessageBox.Show("Enter the Quantioty   ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                txtQuantity.Focus();
                return;

            }


            else
            {
                try
                {
                    string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                    string CmdString = string.Empty;

                    using (SqlConnection con = new SqlConnection(ConString))

                    {
                        int id = Convert.ToInt32(txtId.Text.Trim());
                        int cid = Convert.ToInt32(txtCategoryId.Text.Trim());
                        int cuid = Convert.ToInt32(txtCustomerID.Text.Trim());
                        int sm = Convert.ToInt32(txtSalesAmmount.Text.Trim());
                        int q = Convert.ToInt32(txtQuantity.Text);

                        CmdString = "insert into CoconutSales(SalesId,CoconutCategoryID,CustomerID,SalesAmmount,Quantity) values('" +id+ "','" +cid+ "','" +cuid + "','" +sm+ "','" +q+ "');";

                        SqlCommand cmd = new SqlCommand(CmdString, con);
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Success fully Added details");

                        con.Close();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()); ;
                }



            }





        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            e1.clearText(txtId);
            e1.clearText(txtCategoryId);
            e1.clearText(txtCustomerID);
            e1.clearText(txtSalesAmmount);
            e1.clearText(txtQuantity);
           
        }


    }
}
