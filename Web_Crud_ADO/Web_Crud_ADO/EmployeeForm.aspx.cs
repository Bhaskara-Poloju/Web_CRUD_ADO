using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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