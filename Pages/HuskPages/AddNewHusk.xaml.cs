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

    public partial class AddNewHusk : Window
    {
        public AddNewHusk()
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

        private void txtStock_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtStock);
        }

        private void txtStock_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtStock);
        }

        private void txtunitPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtunitPrice);
        }

        private void txtunitPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtunitPrice);
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
            try
            {
               
                if (txtId.Text == "" || txtId.Text == "*")
                {
                    MessageBox.Show("Enter the ID", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtId.Focus();
                    return;
                    

                }
                else if (txtStock.Text == "" || txtStock.Text == "*")
                {
                    MessageBox.Show("Enter the Stokes details", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtStock.Focus();
                    return;

                }


                else if (txtunitPrice.Text == "" || txtunitPrice.Text == "*")
                {
                    MessageBox.Show("Enter the unit price !!", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtunitPrice.Focus();
                    return;

                }
                else if (txtQuantity.Text == "" || txtQuantity.Text == "*")
                {
                    MessageBox.Show("Enter the Quantity", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtQuantity.Focus();
                    return;

                }


                else {

                    try
                    {
                        string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                        string CmdString = string.Empty;

                        using (SqlConnection con = new SqlConnection(ConString))

                        {
                            int hid = Convert.ToInt32(txtId.Text);
                            int stk = Convert.ToInt32(txtStock.Text);
                            int uni = Convert.ToInt32(txtunitPrice.Text);
                            int qty = Convert.ToInt32(txtQuantity.Text);


                            CmdString = "insert into Husk(id,Stocks,unitPrice,Quantity) values('" + hid+ "','" + stk+ "','" + uni + "','" +qty+ "');";

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
            e1.clearText(txtStock);
            e1.clearText(txtunitPrice);
            e1.clearText(txtQuantity);
        }
    }
}
