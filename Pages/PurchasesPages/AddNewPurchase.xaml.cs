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

namespace Coco_Master.Pages.PurchasesPages
{

    public partial class AddNewPurchase : Window
    {
        public AddNewPurchase()
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

        private void txtSupleirId_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtSupleirId);
        }

        private void txtSupleirId_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtSupleirId);
        }

        private void txtCoconutCategoryID_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtCoconutCategoryID);
        }

        private void txtCoconutCategoryID_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtCoconutCategoryID);
        }

        private void txtPurchaseAmmount_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtPurchaseAmmount);
        }

        private void txtPurchaseAmmount_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtPurchaseAmmount);
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
                else if (txtSupleirId.Text == "" || txtSupleirId.Text == "*")
                {
                    MessageBox.Show("Enter the Suplier id please !!", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSupleirId.Focus();
                    return;

                }


                else if (txtCoconutCategoryID.Text == "" || txtCoconutCategoryID.Text == "*")
                {
                    MessageBox.Show("Enter the coconut catogory id please!!", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtCoconutCategoryID.Focus();
                    return;

                }

                else if (txtPurchaseAmmount.Text == "" || txtPurchaseAmmount.Text == "*")
                {
                    MessageBox.Show("Enter the address!! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtPurchaseAmmount.Focus();
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

                            CmdString = "insert into  Purchases(Id,SupleirId,CoconutCategoryID,PurchaseAmmount,Quantity) values('" + Convert.ToInt32(txtId.Text.Trim()) + "','" + Convert.ToInt32(txtSupleirId.Text.Trim()) + "','" + Convert.ToInt32(txtCoconutCategoryID.Text.Trim()) + "','" + Convert.ToInt32(txtPurchaseAmmount.Text.Trim()) + "','" + Convert.ToInt32(txtQuantity.Text.Trim()) + "');";

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
            e1.clearText(txtSupleirId);
            e1.clearText(txtCoconutCategoryID);
            e1.clearText(txtPurchaseAmmount);
            e1.clearText(txtQuantity);


        }
    }




        
}
