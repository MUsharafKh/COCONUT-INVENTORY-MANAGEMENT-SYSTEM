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
    class Employeee 
    {
        private int EmpID;
        private string EmpName;
        private string EmpType;
        private long EmpContec;
        private double EmpSalary;
        private string EmpAddress;
        


        public int EmpID1 { get => EmpID; set => EmpID = value; }
        public string EmpName1 { get => EmpName; set => EmpName = value; }
        public string EmpType1 { get => EmpType; set => EmpType = value; }
        public long EmpContec1 { get => EmpContec; set => EmpContec = value; }
        public double EmpSalary1 { get => EmpSalary; set => EmpSalary = value; }
        public string EmpAddress1 { get => EmpAddress; set => EmpAddress = value; }

        public void AddData()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                string CmdString = string.Empty;

                using (SqlConnection con = new SqlConnection(ConString))

                {

                    CmdString = "insert into Employee(EmployeeId,EmployeeName,EmplyeeType,EmployeeContact,EmployeeSalary,EmployeeAddress) values('" + EmpID+"','" + EmpName + "','" + EmpType + "','"+EmpContec+"','"+EmpSalary+"','" + EmpAddress + "');";

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



        public void update() {


            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

                string CmdString = string.Empty;

                using (SqlConnection con = new SqlConnection(ConString))

                {

                    CmdString = "UPDATE Employee SET  EmployeeName= '"+EmpName+"',EmplyeeType ='"+EmpType+"',EmployeeContact ='"+EmpContec+"',EmployeeSalary='"+EmpSalary+"',EmployeeAddress='"+EmpAddress+"' WHERE EmployeeId ='"+EmpID+"' ; ";

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




        }


    }
}
