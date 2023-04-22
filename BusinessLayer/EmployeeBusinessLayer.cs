using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employees
        {
            get
            {
                // getting data from Web.config file, reading a connection string from Web.config file 
                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                // Listing (Reading ) from DB
                List<Employee> employees = new List<Employee>();

                // Sql Connection Object
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spgetAllEmployees", con); // Stored Procedure
         
                    cmd.CommandType = CommandType.StoredProcedure; //  Stored Procedure
                    con.Open(); //open connection
                    SqlDataReader rdr = cmd.ExecuteReader(); // 

                    while (rdr.Read()) // reading through each row
                    {
                        Employee employee = new Employee();
                        employee.ID = Convert.ToInt32(rdr["id"]);
                        employee.Name = rdr["name"].ToString();
                
                        employee.Gender = rdr["Gender"].ToString();
                        employee.City = rdr["City"].ToString();
                        employee.DateOfBirth = Convert.ToDateTime(rdr["dateofBirth"]);

                        employees.Add(employee); // Adding Employee object to the list 

                    }
                }
                return employees; // returning te list back to view
            } 

        }
    }
}
