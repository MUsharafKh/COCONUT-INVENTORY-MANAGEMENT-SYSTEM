using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Coco_Master.Pages.CustomerPages
{

    public partial class AddCustomer : Window
    {
        public string hint = "*";
        public AddCustomer()
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

        private void cmbType_GotFocus(object sender, RoutedEventArgs e)
        {
            cmbType.BorderBrush = Brushes.Purple;
        }

        private void cmbType_LostFocus(object sender, RoutedEventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                cmbType.BorderBrush = Brushes.Red;
            }
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

            cmbType.SelectedItem = null;
            cmbType.BorderBrush = Brushes.Purple;

            txtAddress.Text = "";

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                if (txtId.Text == "" || txtId.Text == "*")
                {
                    MessageBox.Show("Enter the ID", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    txtId.Focus();
                    return;


                }
                else if (txtName.Text == "" || txtName.Text == "*")
                {
                    MessageBox.Show("Enter the customer name", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    txtName.Focus();
                    return;

                }


                else if (cmbType.SelectedItem.ToString() == "" || cmbType.SelectedItem.ToString() == "*")
                {
                    MessageBox.Show("Enter the type  !!", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    cmbType.Focus();
                    return;

                }
                else if (txtContact.Text == "" || txtContact.Text == "*")
                {
                    MessageBox.Show("Enter the contect number", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    txtContact.Focus();
                    return;

                }

                else if (txtAddress.Text == "" || txtAddress.Text == "*")
                {
                    MessageBox.Show("Enter the address!! ", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    txtAddress.Focus();
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
                            
                            ComboBoxItem typeItem = (ComboBoxItem)cmbType.SelectedItem;
                            string type = typeItem.Content.ToString();
                            int id = Convert.ToInt32(txtId.Text.Trim());
                            string cusName = txtName.Text.Trim();
                            int cuscan = Convert.ToInt32(txtContact.Text.Trim());
                            string ads = txtAddress.Text.Trim();






                            CmdString = "insert into Customer (CustomerId,CustomerName,CustomerType,CustomerAddress,CustomerContact) values('" + id + "','" + cusName + "','" +type+ "','" + ads + "','"+cuscan+"');";

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

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");

            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtContact_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");

            e.Handled = regex.IsMatch(e.Text);

        }
    }
}
