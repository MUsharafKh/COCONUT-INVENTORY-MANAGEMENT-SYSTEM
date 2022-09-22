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
using System.Text.RegularExpressions;

namespace Coco_Master.Pages.CoconutPages
{

    public partial class AddNewCoconutCategory : Window
    {
        public AddNewCoconutCategory()
        {
            InitializeComponent();
        }

        FocusEvent e1 = new FocusEvent();

        private void txtId_GotFocus(object sender, RoutedEventArgs e)
        {
           e1.gotFocus(txtId);
        }

        private void txtId_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtId);
        }

        private void txtCategoryName_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtCategoryName);
        }

        private void txtCategoryName_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtCategoryName);
        }

        private void txtStock_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtStock);
        }

        private void txtStock_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtStock);
        }

        private void txtUnitPrice_GotFocus(object sender, RoutedEventArgs e)
        {
            e1.gotFocus(txtUnitPrice);
        }

        private void txtUnitPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            e1.lostFocus(txtUnitPrice);
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
                else if (txtCategoryName.Text == "" || txtCategoryName.Text == "*")
                {
                    MessageBox.Show("Enter the Name", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtCategoryName.Focus();
                    return;

                }
                

                else if (txtStock.Text == "" || txtStock.Text == "*")
                {
                    MessageBox.Show("Enter the Stokes", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtStock.Focus();
                    return;

                }
                else if (txtUnitPrice.Text == "" || txtUnitPrice.Text == "*")
                {
                    MessageBox.Show("Enter the UNIT PRICE", "REMAINDER", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtUnitPrice.Focus();
                    return;

                }
             


                else
                {
                    CoconutCat cc = new CoconutCat();
                    cc.CocoId = Convert.ToInt32(txtId.Text);
                    cc.CocoName = txtCategoryName.Text;
                    cc.CocoStoke = Convert.ToDouble(txtStock.Text);
                    cc.CocoUnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                    cc.AddData();
                     

                }


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            e1.clearText(txtId);
            e1.clearText(txtCategoryName);
            e1.clearText(txtStock);
            e1.clearText(txtUnitPrice);
 
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void txtId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");

            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
