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


namespace Coco_Master
{
    class CoconutCat
    {

        private int cocoId;
        private string cocoName;
        private double cocoStoke;
        private double cocoUnitPrice;

        public int CocoId { get => cocoId; set => cocoId = value; }
        public string CocoName { get => cocoName; set => cocoName = value; }
        public double CocoStoke { get => cocoStoke; set => cocoStoke = value; }
        public double CocoUnitPrice { get => cocoUnitPrice; set => cocoUnitPrice = value; }

        public void AddData()
        {


            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                string CmdString = string.Empty;

                using (SqlConnection con = new SqlConnection(ConString))

                {

                    CmdString = "insert into CoconutCategory(Id,Name,Stocks,UnitPrice) values('" + cocoId + "','" + CocoName + "','" + cocoStoke + "','" + cocoUnitPrice + "');";

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



        public void update()
        {

/*
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                string CmdString = string.Empty;

                using (SqlConnection con = new SqlConnection(ConString))

                {

                    CmdString = "UPDATE Employee SET  EmployeeName= '" + EmpName + "',EmplyeeType ='" + EmpType + "',EmployeeContact ='" + EmpContec + "',EmployeeSalary='" + EmpSalary + "',EmployeeAddress='" + EmpAddress + "' WHERE EmployeeId ='" + EmpID + "' ; ";

                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("update fully Added details");

                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); ;
            }


            */

        }


    }
}
