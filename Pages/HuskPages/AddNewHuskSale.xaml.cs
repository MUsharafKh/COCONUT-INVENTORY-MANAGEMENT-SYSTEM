using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Coco_Master.Pages.HuskPages
{

    public partial class AddNewHuskSale : Window
    {
        public AddNewHuskSale()
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

        private void txtCustomerID_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtCustomerID);
        }

        private void txtCustomerID_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtCustomerID);
        }

        private void txtHuskId_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtHuskId);
        }

        private void txtHuskId_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtHuskId);
        }

        private void txtQuantity_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtQuantity);
        }

        private void txtQuantity_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtQuantity);
        }

        private void txtUnitPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtUnitPrice);
        }

        private void txtUnitPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtUnitPrice);
        }

        private void txtTotal_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtTotal);
        }

        private void txtTotal_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtTotal);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (txtId.Text == "" || txtId.Text == "*")
                {
                    MessageBox.Show("Enter the ID", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtId.Focus();
                    return;


                }
                else if (txtCustomerID.Text == "" || txtCustomerID.Text == "*")
                {
                    MessageBox.Show("Enter the customer id", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtCustomerID.Focus();
                    return;

                }


                else if (txtHuskId.Text == "" || txtHuskId.Text == "*")
                {
                    MessageBox.Show("Enter the Husk id", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtHuskId.Focus();
                    return;

                }

                else if (txtUnitPrice.Text == "" || txtUnitPrice.Text == "*")
                {
                    MessageBox.Show("Enter the unit price !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtUnitPrice.Focus();
                    return;

                }
                else if (txtQuantity.Text == "" || txtQuantity.Text == "*")
                {
                    MessageBox.Show("Enter the Quantity !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtQuantity.Focus();
                    return;

                }
                else if (txtTotal.Text == "" || txtTotal.Text == "*")
                {
                    MessageBox.Show("Enter the Total !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtTotal.Focus();
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

                           
                          






                            CmdString = "insert into HuskSales (id,CustomerID,HuskId,UnitPrice,Quantity,Total) values('" + Convert.ToInt32(txtId.Text.Trim())+ "','" + Convert.ToInt32(txtCustomerID.Text.Trim()) + "','" +Convert.ToInt32(txtHuskId.Text.Trim())+ "','"+Convert.ToInt32(txtUnitPrice.Text.Trim()) + "','"+Convert.ToInt32(txtQuantity.Text.Trim()) + "','" + Convert.ToInt32(txtTotal.Text.Trim()) + "');";

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
            catch (Exception ex) { MessageBox.Show(ex.ToString()); ; }




        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            e1.clearText(txtId);
            e1.clearText(txtCustomerID);
            e1.clearText(txtHuskId);
            e1.clearText(txtQuantity);
            e1.clearText(txtUnitPrice);
            e1.clearText(txtTotal);
        }
    }
}
