using ConsoleApp_OOPs.OOPs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
//using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Crud_ADO
{
    public partial class EmployeeForm : System.Web.UI.Page
    {
        public string Title = "Employee Grid";
        protected void Page_Load(object sender, EventArgs e)
        {
            //klkljflasjflkjas
            GetEmployeeData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-J1A95C0\SQLEXPRESS;Initial Catalog=HRDB;Persist Security Info=True;User ID=sa;Password=Srirama@18");

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.employees (first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id) VALUES('" + txt_firstName.Text + "','" + txt_lastName.Text + "','" + txt_Email.Text + "','" + txt_phoneNumber.Text + "','" + txt_hireDate.Text + "','" + txt_jobId.Text + "','" + txt_salary.Text + "','"+txt_managerId.Text+"','"+txt_deptId.Text+"')", cn);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        //Get Employee Data from DB
        private void GetEmployeeData()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1A95C0\SQLEXPRESS;Initial Catalog=HRDB;Persist Security Info=True;User ID=sa;Password=Srirama@18"))
            {
                SqlDataAdapter sde = new SqlDataAdapter("Select * from Employees", con);
                DataSet ds = new DataSet();
                sde.Fill(ds);
                Employee_Grid.DataSource = ds;
                Employee_Grid.DataBind();
            }
        }

        //Update Employee Data
        private void UpdateEmployeeData()
        {
            //Work in progress
        }

        //Add Employee Record -- POST
        private void AddEmployeeRecord()
        {
            //In progress
        }


        //Delete record
        private void DeleteEmployee()
        {
            //In progress..
        }
    }
}