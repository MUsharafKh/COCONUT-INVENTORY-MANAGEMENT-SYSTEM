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

namespace Coco_Master.Pages.EmployeePages
{
    public partial class UpdateEmployee : Window
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }


        FocusEvent e1 = new FocusEvent();


      

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
        private void txtSalary_GotFocus(object sender, RoutedEventArgs e)
        {

            e1.gotFocus(txtSalary);
        }

        private void txtSalary_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtSalary);
        }

        private void txtContact_GotFocus(object sender, RoutedEventArgs e)
        {

            e1.gotFocus(txtContact);
        }

        private void txtContact_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtContact);
        }



        private void cmbType_LostFocus(object sender, RoutedEventArgs e)
        {
            if (cmbType.SelectedItem == null)
            {
                cmbType.BorderBrush = Brushes.Red;
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void txtAddress_LostFocus(object sender, RoutedEventArgs e)
        {

            e1.lostFocus(txtAddress);
        }
        private void txtAddress_GotFocus(object sender, RoutedEventArgs e)
        {

            e1.gotFocus(txtAddress);
        }








        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            cmbType.Text = "";
            txtSalary.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
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
                        MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        txtName.Focus();
                        return;

                    }
                    else if (cmbType.SelectedItem.ToString() == "" || cmbType.SelectedItem.ToString() == "*")
                    {
                        MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        txtName.Focus();
                        return;

                    }

                    else if (txtSalary.Text == "" || txtSalary.Text == "*")
                    {
                        MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        txtName.Focus();
                        return;

                    }
                    else if (txtContact.Text == "" || txtContact.Text == "*")
                    {
                        MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        txtName.Focus();
                        return;

                    }
                    else if (txtAddress.Text == "" || txtName.Text == "*")
                    {
                        MessageBox.Show("Enter the Address", "REMAINDER", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        txtName.Focus();
                        return;

                    }


                    else
                    {

                        Employeee emp = new Employeee();
                        emp.EmpID1 = Convert.ToInt32(txtId.Text);
                        emp.EmpName1 = txtName.Text;
                        // emp.EmpType1 = cmbType.SelectedItem.ToString();
                        ComboBoxItem typeItem = (ComboBoxItem)cmbType.SelectedItem;
                        emp.EmpType1 = typeItem.Content.ToString();


                        emp.EmpSalary1 = Convert.ToDouble(txtSalary.Text);
                        emp.EmpContec1 = Convert.ToInt64(txtContact.Text);
                        emp.EmpAddress1 = txtAddress.Text;
                        emp.update();


                    }





                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }







            


        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            string CmdString = string.Empty;

            using (SqlConnection con = new SqlConnection(ConString))
            {
                if (txtId.Text != "")
                {


                    con.Open();
                    CmdString = "SELECT EmployeeName,EmplyeeType,EmployeeContact,EmployeeSalary,EmployeeAddress FROM Employee WHERE EmployeeId = @EmployeeId";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    cmd.Parameters.AddWithValue("@EmployeeId", txtId.Text);
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        txtName.Text = da.GetValue(0).ToString();
                        cmbType.Text = da.GetValue(1).ToString();
                        txtContact.Text = da.GetValue(2).ToString();
                        txtSalary.Text = da.GetValue(3).ToString();
                        txtAddress.Text = da.GetValue(4).ToString();
                    }

                    con.Close();
                }
            }
        }
    }
}
