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

namespace Coco_Master.Pages.SupplierPages
{

    public partial class AddSuplier : Window
    {
        public string hint = "*";
        public AddSuplier()
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

        private void txtId_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtId);

        }

        private void txtId_GotFocus(object sender, RoutedEventArgs e)
        {
            
            e1.gotFocus(txtId);
        }

        private void txtName_GotFocus(object sender, RoutedEventArgs e)
        {
            
            e1.gotFocus(txtName);
        }

        public void txtName_LostFocus(object sender, RoutedEventArgs e)
        {
            
            e1.lostFocus(txtName);
        }

        private void txtContact_GotFocus(object sender, RoutedEventArgs e)
        {
           
            e1.gotFocus(txtContact);
        }

        private void txtContact_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtContact);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            e1.clearText(txtId);
            e1.clearText(txtName);
            e1.clearText(txtContact);
            e1.clearText(txtName);

            txtAddress.Text = "";
            
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
                else if (txtName.Text == "" || txtName.Text == "*")
                {
                    MessageBox.Show("Enter the Suplier Name please !!", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtName.Focus();
                    return;

                }


                else if (txtAddress.Text == "" || txtAddress.Text == "*")
                {
                    MessageBox.Show("Enter the Address  please!!", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtAddress.Focus();
                    return;

                }

                else if (txtContact.Text == "" || txtContact.Text == "*")
                {
                    MessageBox.Show("Enter the contact number please !! ", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtContact.Focus();
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

                            CmdString = "insert into  Supplier(SupplierID,SupplierName,SupplierAddress,SupplierContact) values('" + Convert.ToInt32(txtId.Text.Trim()) + "','" + txtName.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + Convert.ToInt32(txtContact.Text.Trim()) + "');";

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
    }
}
