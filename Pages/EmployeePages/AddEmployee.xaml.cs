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
using System.Text.RegularExpressions;

namespace Coco_Master.Pages.EmployeePages
{
    /// <summary>
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        FocusEvent e1 = new FocusEvent();

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
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

        private void txtAddress_LostFocus(object sender,RoutedEventArgs e) {

            e1.lostFocus(txtAddress);
        }
        private void txtAddress_GotFocus(object sender, RoutedEventArgs e)
        {

            e1.gotFocus(txtAddress);
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            e1.clearText(txtId);
            e1.clearText(txtName);
            e1.clearText(txtSalary);
            e1.clearText(txtContact);
            e1.clearText(txtName);

            cmbType.SelectedItem = null;
            cmbType.BorderBrush = Brushes.Purple;

            txtAddress.Text = "";

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Employeee emp = new Employeee();
                if (txtId.Text == "" || txtId.Text == "*")
                {
                    MessageBox.Show("Enter the ID", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtId.Focus();
                    return;


                }
                else if (txtName.Text == "" || txtName.Text =="*" ) {
                    MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtName.Focus();
                    return;

                }
                else if (cmbType.SelectedItem.ToString() == "" || cmbType.SelectedItem.ToString() == "*")
                {
                    MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtName.Focus();
                    return;

                }

                else if (txtSalary.Text == "" || txtSalary.Text == "*" )
                {
                    MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtName.Focus();
                    return;

                }
                else if (txtContact.Text == "" || txtContact.Text == "*")
                {
                    MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtName.Focus();
                    return;

                }
                else if (txtAddress.Text == "" || txtName.Text == "*")
                {
                    MessageBox.Show("Enter the Address", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtName.Focus();
                    return;

                }


                else {
                    emp.EmpID1 = Convert.ToInt32(txtId.Text);
                    emp.EmpName1 = txtName.Text;
                    // emp.EmpType1 = cmbType.SelectedItem.ToString();
                    ComboBoxItem typeItem = (ComboBoxItem)cmbType.SelectedItem;
                    emp.EmpType1 = typeItem.Content.ToString();


                    emp.EmpSalary1 = Convert.ToDouble(txtSalary.Text);
                    emp.EmpContec1 = Convert.ToInt64(txtContact.Text);
                    emp.EmpAddress1 = txtAddress.Text;
                    emp.AddData();

                }
                
               
            
                
             





            } catch (Exception ex) { MessageBox.Show(ex.ToString()); }



        }

        private void txtId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");

            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtSalary_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
          
        }

        private void txtContact_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");

            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtId_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");

            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
