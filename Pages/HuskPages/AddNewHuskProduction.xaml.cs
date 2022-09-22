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

    public partial class AddNewHuskProduction : Window
    {
        public AddNewHuskProduction()
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

        private void txtEmployeeId_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtEmployeeId);
        }

        private void txtEmployeeId_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtEmployeeId);
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

        private void txtRate_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtRate);
        }

        private void txtRate_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtRate);
        }

        private void txtSales_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtSales);
        }

        private void txtSales_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtSales);
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
                else if (txtEmployeeId.Text == "" || txtEmployeeId.Text == "*")
                {
                    MessageBox.Show("Enter the Employee id", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtEmployeeId.Focus();
                    return;

                }


                else if (txtHuskId.Text == "" || txtHuskId.Text == "*")
                {
                    MessageBox.Show("Enter the Husk id", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtHuskId.Focus();
                    return;

                }

                else if (txtHuskId.Text == "" || txtHuskId.Text == "*")
                {
                    MessageBox.Show("Enter the unit price !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtHuskId.Focus();
                    return;

                }
                else if (txtQuantity.Text == "" || txtQuantity.Text == "*")
                {
                    MessageBox.Show("Enter the Quantity !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtQuantity.Focus();
                    return;

                }
                else if (txtRate.Text == "" || txtRate.Text == "*")
                {
                    MessageBox.Show("Enter the Rate !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtRate.Focus();
                    return;

                }
                else if (txtSales.Text == "" || txtSales.Text == "*")
                {
                    MessageBox.Show("Enter the sales !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSales.Focus();
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









                            CmdString = "insert into HuskProduction (id,EmployeeId,HuskId,Quantity,Rate,Sates) values('" + Convert.ToInt32(txtId.Text.Trim()) + "','" + Convert.ToInt32(txtEmployeeId.Text.Trim()) + "','" + Convert.ToInt32(txtHuskId.Text.Trim()) + "','" + Convert.ToInt32(txtQuantity.Text.Trim()) + "','" + Convert.ToInt32(txtSales.Text.Trim()) + "','" + Convert.ToInt32(txtSales.Text.Trim()) + "');";

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
            e1.clearText(txtEmployeeId);
            e1.clearText(txtHuskId);
            e1.clearText(txtQuantity);
            e1.clearText(txtRate);
            e1.clearText(txtSales);
        }
    }
}
