

using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        DatabaseConnectionClass dcc;

        public EmployeeRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertEmployee(Employee emp)
        {
            string query = "INSERT into employees VALUES('" + emp.Id + "', '" + emp.Name + "', '"+emp.PhnNumber+"', "+emp.Salary+", '"+emp.Designation+"')";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
                return true;

            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public bool DeleteEmployee(Employee emp)
        {
            string query = "DELETE FROM employees WHERE id = '" + emp.Id + "'";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public bool UpdateEmployee(Employee emp)
        {
            string query = "UPDATE employees SET name = '"+emp.Name+"', phonenumber = '"+emp.PhnNumber+"', salary = "+emp.Salary+", designation = '"+emp.Designation+"' WHERE id = '" + emp.Id + "'";
            try
            {
                dcc.ConnectWithDB();
                dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public Employee GetEmployee(string id)
        {
            Employee emp = null;

            string query = "SELECT * FROM employees WHERE id = '" + id + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr =  dcc.GetData(query);

            while (sdr.Read())
            {
                emp = new Employee();

                emp.Id = sdr["id"].ToString();
                emp.Name = sdr["name"].ToString();
                emp.PhnNumber = sdr["phonenumber"].ToString();
                emp.Salary = Convert.ToDouble(sdr["salary"]);
                emp.Designation = sdr["designation"].ToString();
            }
            dcc.CloseConnection();
            return emp;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listOfEmployee = new List<Employee>();
            string query = "SELECT * FROM employees";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Employee emp = new Employee();

                emp.Id = sdr["id"].ToString();
                emp.Name = sdr["name"].ToString();
                emp.PhnNumber = sdr["phonenumber"].ToString();
                emp.Salary = Convert.ToDouble(sdr["salary"]);
                emp.Designation = sdr["designation"].ToString();

                listOfEmployee.Add(emp);
            }
            dcc.CloseConnection();

            return listOfEmployee;
        }
    }
}
