using Entity;
using Interfaces;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class EmployeeManagement : Form
    {
        Login l;
        LoginRepo lr;
        EmployeeRepo er;

        public EmployeeManagement(Login l)
        {
            InitializeComponent();

            EmployeeTable.AutoGenerateColumns = false;
            this.l = l;

            er = new EmployeeRepo();
            lr = new LoginRepo();

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Visible = true;
            this.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenuForm1 m1 = new MainMenuForm1(l);
            m1.Visible = true;
            this.Visible = false;
        }

        private void Formclosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            emp.Id = this.IdTb.Text;
            emp.Name = this.NameTb.Text;
            int phn = Convert.ToInt32(this.PhoneNumberTb.Text);
            emp.PhnNumber = phn + "";
            double sal = Convert.ToDouble(this.SalaryTb.Text);
            emp.Salary = sal;
            emp.Designation = this.DesignationTb.Text;

            if (er.UpdateEmployee(emp))
            {
                MessageBox.Show("Update Done");

                this.RefreshBtn_Click(sender, e);
                this.ShowAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Update NOT Done");
            }
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            List<Employee> listOfEmployee = er.GetAllEmployees();
            this.EmployeeTable.DataSource = listOfEmployee;

            for(int a = 0; a < listOfEmployee.Count; a++)
            {
                EmployeeTable.Rows[a].Cells[0].Value = listOfEmployee[a].Id;
                EmployeeTable.Rows[a].Cells[1].Value = listOfEmployee[a].Name;
                EmployeeTable.Rows[a].Cells[2].Value = listOfEmployee[a].PhnNumber;
                EmployeeTable.Rows[a].Cells[3].Value = listOfEmployee[a].Salary;
                EmployeeTable.Rows[a].Cells[4].Value = listOfEmployee[a].Designation;
            }

        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Employee emp = new Employee();

            int p = new Random().Next(99999999) + 10000000;
            try
            {
                l.Id = this.IdTb.Text;
                l.Password = p + "";

                emp.Id = this.IdTb.Text;
                emp.Name = this.NameTb.Text;
                int phn = Convert.ToInt32(this.PhoneNumberTb.Text);
                emp.PhnNumber = phn + "";
                double sal = Convert.ToDouble(this.SalaryTb.Text);
                emp.Salary = sal;
                emp.Designation = this.DesignationTb.Text;

                if ((emp.Designation.ToLower()).Equals("manager"))
                {
                    l.Role = 1;
                }
                else if ((emp.Designation.ToLower()).Equals("cashier"))
                {
                    l.Role = 2;
                }
                else
                {
                    l.Role = 3;
                }

                if (lr.InsertUser(l))
                {
                    if (er.InsertEmployee(emp))
                    {
                        MessageBox.Show("Employee Added. Id : " + emp.Id + " & Password : " + l.Password);
                        this.ShowAllBtn_Click(sender, e);
                        this.RefreshBtn_Click(sender,e);
                    }
                }
                else
                {
                    MessageBox.Show("Can Not Add" + l.Id);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }
            InsertBtn.Enabled = true;
            DeleteBtn.Enabled = true;
            UpdateBtn.Enabled = true;
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Employee emp = new Employee();

            emp.Id = this.IdTb.Text;

                if (lr.DeleteUser(l))
                {
                    if (er.DeleteEmployee(emp))
                    {
                        MessageBox.Show("Deleted");
                        this.RefreshBtn_Click(sender, e);
                        this.ShowAllBtn_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Can Not Delete");
                }
            
            InsertBtn.Enabled = true;
            DeleteBtn.Enabled = true;
            UpdateBtn.Enabled = true;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string id = IdTb.Text;

            Employee emp = er.GetEmployee(id);

            if (emp == null)
            {
                MessageBox.Show("Invalid Id");
                this.RefreshBtn_Click(sender, e);
            }
            else
            {
                this.NameTb.Text = emp.Name;
                this.PhoneNumberTb.Text = emp.PhnNumber;
                this.SalaryTb.Text = emp.Salary + "";
                this.DesignationTb.Text = emp.Designation;

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.IdTb.Enabled = false;
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.IdTb.Text = "";
            this.NameTb.Text = "";
            this.PhoneNumberTb.Text = "";
            this.SalaryTb.Text = "";
            this.DesignationTb.Text = "";

            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.IdTb.Enabled = true;
        }

        private void EmployeeTableCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.IdTb.Text = EmployeeTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.NameTb.Text = EmployeeTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.PhoneNumberTb.Text = EmployeeTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.SalaryTb.Text = EmployeeTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.DesignationTb.Text = EmployeeTable.Rows[e.RowIndex].Cells[4].Value.ToString();

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.IdTb.Enabled = false;
            }
            catch(Exception exp)
            {
                MessageBox.Show("Invalid Input!!");
            }
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            List<Employee> listOfEmployee = er.GetAllEmployees();
            string keyword = SearchTb.Text.ToLower();

            List<Employee> searchedList = listOfEmployee.FindAll(x => ((x.Id.ToLower()).Contains(keyword)) || ((x.Name.ToLower()).Contains(keyword)) || ((x.PhnNumber.ToLower()).Contains(keyword)) || ((x.Designation.ToLower()).Contains(keyword)));

            this.EmployeeTable.DataSource = searchedList;

            for (int a = 0; a < searchedList.Count; a++)
            {
                EmployeeTable.Rows[a].Cells[0].Value = searchedList[a].Id;
                EmployeeTable.Rows[a].Cells[1].Value = searchedList[a].Name;
                EmployeeTable.Rows[a].Cells[2].Value = searchedList[a].PhnNumber;
                EmployeeTable.Rows[a].Cells[3].Value = searchedList[a].Salary;
                EmployeeTable.Rows[a].Cells[4].Value = searchedList[a].Designation;
            }
        }

    }
}
