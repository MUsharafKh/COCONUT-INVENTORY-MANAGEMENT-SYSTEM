using Coco_Master.Pages.CoconutPages;
using Coco_Master.Pages.CustomerPages;
using Coco_Master.Pages.EmployeePages;
using Coco_Master.Pages.HuskPages;
using Coco_Master.Pages.PurchasesPages;
using Coco_Master.Pages.SupplierPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coco_Master
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            
        }

        

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Employees();
            Cursor = Cursors.Arrow;


        }
        

        private void btnSuppliers_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Suppliers();
            Cursor = Cursors.Arrow;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            //MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems
            rr.Visibility = Visibility.Visible;
            Cursor = Cursors.Wait;
            main.Content = "";
            Cursor = Cursors.Arrow;
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Customers();
            Cursor = Cursors.Arrow;
        }

        private void btnCoconutCategory_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Coconut_Categories();
            Cursor = Cursors.Arrow;
        }

        private void btnCoconutSales_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Coconut_Sales();
            Cursor = Cursors.Arrow;

        }

        private void btnHusk_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Husk();
            Cursor = Cursors.Arrow;
        }

        private void btnHuskProduction_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Husk_Production();
            Cursor = Cursors.Arrow;
        }

        private void btnHuskSales_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Husk_Sales();
            Cursor = Cursors.Arrow;
        }

        private void btnPurchases_Click(object sender, RoutedEventArgs e)
        {
            rr.Visibility = Visibility.Hidden;
            Cursor = Cursors.Wait;
            main.Content = new Purchases();
            Cursor = Cursors.Arrow;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("You are about to logout, are you sure", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                Cursor = Cursors.Wait;
                new Login().Show();
                this.Close();
                Cursor = Cursors.Arrow;
            }
                
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                border.BorderThickness = new Thickness(0);
            }
            else if (WindowState == WindowState.Normal)
            {
                border.BorderThickness = new Thickness(0,0,0,6);
            }
        }

        private void btnAbout_Click_1(object sender, RoutedEventArgs e)
        {

   
            MessageBox.Show("This is our GUI project this made for manage all the works in coconut industry we work hard and make this software. IN our group there are five Members.they are **Musharaf khan** **Sadun** **junaid** **Nipun** **Silila**  thank you all !!!!", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
