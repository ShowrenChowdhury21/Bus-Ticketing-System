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
   
    public partial class CustomerDetails : Form
    {
        Login l;
        Bus b;
        CustomerRepo cr;
        string tablefrom = "";
        string tableto = "";
        string tablebusid = "";
        string tabledate = "";
        string tabletime = "";
        string tabletype = "";
        string tableseatnumber = "";
        string tablefare = "";
        public CustomerDetails(Login l)
        {
            InitializeComponent();
            CustomerTable.AutoGenerateColumns = false;

            cr = new CustomerRepo();
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            List<Customer> listOfCustomer = cr.GetAllCustomer();
            this.CustomerTable.DataSource = listOfCustomer;

            for (int a = 0; a < listOfCustomer.Count; a++)
            {
                CustomerTable.Rows[a].Cells[0].Value = listOfCustomer[a].Name;
                CustomerTable.Rows[a].Cells[1].Value = listOfCustomer[a].PhoneNumber;
                CustomerTable.Rows[a].Cells[2].Value = listOfCustomer[a].From;
                CustomerTable.Rows[a].Cells[3].Value = listOfCustomer[a].To;
                CustomerTable.Rows[a].Cells[4].Value = listOfCustomer[a].BusId;
                CustomerTable.Rows[a].Cells[5].Value = listOfCustomer[a].Date;
                CustomerTable.Rows[a].Cells[6].Value = listOfCustomer[a].Time;
                CustomerTable.Rows[a].Cells[7].Value = listOfCustomer[a].Type;
                CustomerTable.Rows[a].Cells[8].Value = listOfCustomer[a].SeatNumber;
                CustomerTable.Rows[a].Cells[9].Value = listOfCustomer[a].Fare;

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Customer cm = new Customer();

            cm.Name = this.CustomerNameTb.Text;
            cm.PhoneNumber = this.PhoneTB.Text;
            cm.From = tablefrom;
            cm.To = tableto;
            cm.BusId = tablebusid;
            cm.Date = tabledate;
            cm.Time = tabletime;
            cm.Type = tabletype;
            cm.SeatNumber = tableseatnumber;
            cm.Fare = Convert.ToInt32(tablefare);
            string []seatnumbers = tableseatnumber.Split(',');


                if (cr.DeleteCustomer(cm))
                {
                    MessageBox.Show("Deleted");
                    this.ShowAllBtn_Click(sender, e);
                    int i = 0;
                    Bus b = new Bus();
                    BusRepo br = new BusRepo();
                    while (seatnumbers[i] != "")
                    {
                        b = br.GetBus(tablebusid, tabledate, tabletime);
                        br.updatefordelete(b, seatnumbers[i]);
                        i++;
                    }
                    //MessageBox.Show(b.NumberOfSeats + " " + seatnumbers.Length);
                    b.NumberOfSeats = (b.NumberOfSeats + seatnumbers.Length - 1);
                    br.UpdateNumberSeat(b);

                }

                else
                {
                    MessageBox.Show("Can Not Delete");
                }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenuForm1 m1 = new MainMenuForm1(l);
            m1.Visible = true;
            this.Visible = false;
        }

        private void customertablecellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CustomerNameTb.Text = CustomerTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                PhoneTB.Text = CustomerTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                tablefrom = CustomerTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                tableto = CustomerTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                tablebusid = CustomerTable.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                tabledate = CustomerTable.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                tabletime = CustomerTable.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                tabletype = CustomerTable.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                tableseatnumber = CustomerTable.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                tablefare = CustomerTable.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            }
           
            catch(Exception exp)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void onformclosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            List<Customer> listOfCustomer = cr.GetAllCustomer();
            string keyword = SearchTb.Text.ToLower();
            List<Customer> searchedList = listOfCustomer.FindAll(x => ((x.Name.ToLower()).Contains(keyword)) || ((x.From.ToLower()).Contains(keyword)) || ((x.To.ToLower()).Contains(keyword)) || ((x.BusId.ToLower()).Contains(keyword)) || ((x.Type.ToLower()).Contains(keyword)) || ((x.PhoneNumber).Contains(keyword)));

            this.CustomerTable.DataSource = searchedList;

            for (int a = 0; a < searchedList.Count; a++)
            {
                CustomerTable.Rows[a].Cells[0].Value = searchedList[a].Name;
                CustomerTable.Rows[a].Cells[1].Value = searchedList[a].PhoneNumber;
                CustomerTable.Rows[a].Cells[2].Value = searchedList[a].From;
                CustomerTable.Rows[a].Cells[3].Value = searchedList[a].To;
                CustomerTable.Rows[a].Cells[4].Value = searchedList[a].BusId;
                CustomerTable.Rows[a].Cells[5].Value = searchedList[a].Date;
                CustomerTable.Rows[a].Cells[6].Value = searchedList[a].Time;
                CustomerTable.Rows[a].Cells[7].Value = searchedList[a].Type;
                CustomerTable.Rows[a].Cells[8].Value = searchedList[a].SeatNumber;
                CustomerTable.Rows[a].Cells[9].Value = listOfCustomer[a].Fare;

            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Visible = true;
            this.Visible = false;
        }
    }
}
