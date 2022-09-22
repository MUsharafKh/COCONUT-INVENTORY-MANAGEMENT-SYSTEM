using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Coco_Master
{

    public partial class Login : Window
    {
        string pwd;
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            SqlConnection connection = DbConnection.SqlServerConnection();
            string query = "SELECT * FROM LoginInfo WHERE Username = '" + txtUserName.Text.Trim() + "' and Password = '" + txtPassword.Password.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MainWindow wd = new MainWindow();
                wd.txtUser.Text = txtUserName.Text;
                wd.Show();               
                this.Close();
                return;

            }
            else
            {
                txtHint.Text = "Invalid username or password";
            }
            Cursor = Cursors.Arrow;

        }
       
        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void createNewAccount_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection connection = DbConnection.SqlServerConnection();
            Cursor = Cursors.Wait;
            string query = "SELECT * FROM LoginInfo WHERE Password = '" + adminPassword.Password.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                string checkUsernameQ = "SELECT * FROM LoginInfo WHERE Username = '" + newUserName.Text.Trim() + "' ";
                SqlDataAdapter sda1 = new SqlDataAdapter(checkUsernameQ, connection);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);


                if (dt1.Rows.Count != 1)
                {
                    pwd = newPassword.Password;
                    if (pwd.Length >= 7)
                    {
                        if (confirmPassword.Password == newPassword.Password)
                        {
                            connection.Open();
                            string insertQuery = "INSERT INTO LoginInfo (Username,Password) VALUES ('" + newUserName.Text.Trim() + "','" + newPassword.Password.Trim() + "');";
                            SqlCommand cmd = new SqlCommand(insertQuery,connection);
                            cmd.ExecuteNonQuery();


                            MessageBoxResult result = MessageBox.Show("Account successfully created.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (result == MessageBoxResult.OK)
                            {
                                NewAccountGrid.Visibility = Visibility.Hidden;
                                loginGrid.Visibility = Visibility.Visible;
                            }
                            Cursor = Cursors.Arrow;
                            return;
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show("Something went wrong!. Please try again.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            if (result == MessageBoxResult.OK)
                            {
                                NewAccountGrid.Visibility = Visibility.Hidden;
                                loginGrid.Visibility = Visibility.Visible;
                            }
                        }
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Please try again.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        if (result == MessageBoxResult.OK)
                        {
                            clearData();
                        }

                    }
                    
                    return;
 

                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Please try again.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    if (result == MessageBoxResult.OK)
                    {
                        clearData();
                    }
                }
                
                return;

            }
            else if (adminPassword.Password == "")
            {
                AdminPasswordHint.Text = "Please enter the password for Admin account";
            }
            else
            {
                AdminPasswordHint.Text = "Invalid Admin password!";
            }

            connection.Close();


            Cursor = Cursors.Arrow;

        }

        public void clearData()
        {
            newUserName.Text = "";
            usernameHint.Text = "";
            newPassword.Password = "";
            passwordHint.Text = "";
            confirmPassword.Password = "";
            confirmPasswordHint.Text = "";
            adminPassword.Password = "";
            AdminPasswordHint.Text = "";

        }
     

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            NewAccountGrid.Visibility = Visibility.Hidden;
            loginGrid.Visibility = Visibility.Visible;
        }

        private void btnClose1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnNewAccount_Click(object sender, RoutedEventArgs e)
        {
            loginGrid.Visibility = Visibility.Hidden;
            NewAccountGrid.Visibility = Visibility.Visible;
        }






        private void newUserName_LostFocus(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = DbConnection.SqlServerConnection();
            string query = "SELECT * FROM LoginInfo WHERE Username = '" + newUserName.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                usernameHint.Text = "That username is taken. Try another.";
                return;

            }
            else if (newUserName.Text == "")
            {
                usernameHint.Text = "";
            }
        }

        private void newPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            pwd = newPassword.Password;
            if (pwd.Length <= 7)
            {
                passwordHint.Text = "Use 8 characters or more for your password.";
            }
        }

        private void confirmPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if(confirmPassword.Password != newPassword.Password)
            {
                confirmPasswordHint.Text = "Those passwords didn’t match. Try again.";
            }
            else if (confirmPassword.Password == "")
            {
                confirmPasswordHint.Text = "";
            }
        }

        private void newUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            usernameHint.Text = "";
        }

        private void newPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordHint.Text = "";
        }

        private void confirmPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            confirmPasswordHint.Text = "";
        }

        private void adminPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            AdminPasswordHint.Text = "";
        }

        private void txtUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtHint.Text = "";
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            txtHint.Text = "";
        }
    }
}
