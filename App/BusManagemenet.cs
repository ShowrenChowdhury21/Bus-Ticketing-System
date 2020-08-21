using Entity;
using Interfaces;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class BusManagemenet : Form
    {
        Login l;
        BusRepo br;
        LoginRepo lr;
        public BusManagemenet(Login l)
        {
            InitializeComponent();
            BusTable2.AutoGenerateColumns = false;
            this.l = l;

            br = new BusRepo();
            lr = new LoginRepo();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenuForm1 m1 = new MainMenuForm1(l);
            m1.Visible = true;
            this.Visible = false;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Visible = true;
            this.Visible = false;
        }

        private void Formclosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Bus b = new Bus();

            b.BusId = this.BusIdTb.Text;
            b.BusName = this.BusNameTb.Text;
            b.From = this.FromTb.Text;
            b.To = this.ToTb.Text;
            b.Date = DateTime.Parse(this.BusDateTime.Value.ToString()).ToString("MM/dd/yyyy");
            b.Time = this.TimeTb.Text;
            b.Type = this.TypeTb.Text;
            b.NumberOfSeats = Convert.ToInt32(this.SeatsTb.Text);
            b.Fare = Convert.ToDouble(this.FareTb.Text);

            if (br.UpdateBus(b))
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
            List<Bus> listOfBus = br.GetAllBus();
            this.BusTable2.DataSource = listOfBus;

            for (int a = 0; a < listOfBus.Count; a++)
            {
                BusTable2.Rows[a].Cells[0].Value = listOfBus[a].BusId;
                BusTable2.Rows[a].Cells[1].Value = listOfBus[a].BusName;
                BusTable2.Rows[a].Cells[2].Value = listOfBus[a].From;
                BusTable2.Rows[a].Cells[3].Value = listOfBus[a].To;
                BusTable2.Rows[a].Cells[4].Value = listOfBus[a].Date;
                BusTable2.Rows[a].Cells[5].Value = listOfBus[a].Time;
                BusTable2.Rows[a].Cells[6].Value = listOfBus[a].Type;
                BusTable2.Rows[a].Cells[7].Value = listOfBus[a].NumberOfSeats;
                BusTable2.Rows[a].Cells[8].Value = listOfBus[a].Fare;
            }

        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Bus b = new Bus(); 

                b.BusId = this.BusIdTb.Text;
                b.BusName = this.BusNameTb.Text;
                b.From = this.FromTb.Text;
                b.To = this.ToTb.Text;
                b.Date = this.BusDateTime.Text; 
                b.Time = this.TimeTb.Text;
                b.Type = this.TypeTb.Text;
                b.NumberOfSeats = Convert.ToInt32(this.SeatsTb.Text);
                b.Fare = Convert.ToDouble(this.FareTb.Text);

                b.A1 = 0;
                b.A2 = 0;
                b.A3 = 0;
                b.A4 = 0;
                b.B1 = 0;
                b.B2 = 0;
                b.B3 = 0;
                b.B4 = 0;
                b.C1 = 0;
                b.C2 = 0;
                b.C3 = 0;
                b.C4 = 0;
                b.D1 = 0;
                b.D2 = 0;
                b.D3 = 0;
                b.D4 = 0;
                b.E1 = 0;
                b.E2 = 0;
                b.E3 = 0;
                b.E4 = 0;
                b.F1 = 0;
                b.F2 = 0;
                b.F3 = 0;
                b.F4 = 0;
                b.G1 = 0;
                b.G2 = 0;
                b.G3 = 0;
                b.G4 = 0;
                b.H1 = 0;
                b.H2 = 0;
                b.H3 = 0;
                b.H4 = 0;


                if (br.InsertBus(b))
                {
                    MessageBox.Show("Bus Added. Id : " + b.BusId + " & Name : " + b.BusName + " & From : " + b.From+" & To :" +b.To);
                    this.RefreshBtn_Click(sender, e);
                    this.ShowAllBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Can Not Add: " + b.BusId);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data");
            }

            DeleteBtn.Enabled = true;
            UpdateBtn.Enabled = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Bus b = new Bus();

            b.BusId = this.BusIdTb.Text;

            if (br.DeleteBus(b))
            {
                MessageBox.Show("Deleted");
                this.RefreshBtn_Click(sender, e);
                this.ShowAllBtn_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Can Not Delete");
            }
            InsertBtn.Enabled = true;
            DeleteBtn.Enabled = true;
            UpdateBtn.Enabled = true;
        }

        /*private void LoadBtn_Click(object sender, EventArgs e)
        {
            string from = FromTb.Text;
            string to = ToTb.Text;
            string date = BusDateTime.Text;
            string type = TypeTb.Text;


            Bus b = new Bus();

            b = br.GetBus(from,to,date,type);
            try
            {
                if (b == null)
                {
                    MessageBox.Show("Invalid Input!!");
                    this.RefreshBtn_Click(sender, e);
                }
                else
                {
                    this.BusIdTb.Text = b.BusId;
                    this.BusNameTb.Text = b.BusName;
                    this.FromTb.Text = b.From;
                    this.ToTb.Text = b.To;
                    this.BusDateTime.Value = Convert.ToDateTime(b.Date.Substring(0, 10));
                    this.TimeTb.Text = b.Time;
                    this.TypeTb.Text = b.Type;
                    this.SeatsTb.Text = b.NumberOfSeats + "";
                    this.FareTb.Text = b.Fare + "";

                    this.RefreshBtn.Enabled = true;
                    this.LoadBtn.Enabled = false;
                    this.InsertBtn.Enabled = false;
                    this.UpdateBtn.Enabled = true;
                    this.DeleteBtn.Enabled = true;

                    this.BusIdTb.Enabled = false;
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Please try again!!");
            }
            
        }*/

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.BusIdTb.Text = "";
            this.BusNameTb.Text = "";
            this.FromTb.Text = "";
            this.ToTb.Text = "";
            this.BusDateTime.Text = "";
            this.TimeTb.Text = "";
            this.TypeTb.Text = "";
            this.SeatsTb.Text = "";
            this.FareTb.Text = "";

            this.RefreshBtn.Enabled = false;       
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;

            this.BusIdTb.Enabled = true;
        }


        private void busmanagementtableclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.BusIdTb.Text = BusTable2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                this.BusNameTb.Text = BusTable2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                this.FromTb.Text = BusTable2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                this.ToTb.Text = BusTable2.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                //string date = BusTable2.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                this.BusDateTime.Value = DateTime.ParseExact(BusTable2.Rows[e.RowIndex].Cells[4].FormattedValue.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                this.TimeTb.Text = BusTable2.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                this.TypeTb.Text = BusTable2.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                this.SeatsTb.Text = BusTable2.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                this.FareTb.Text = BusTable2.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Invalid input!!");
            }
            
        }

        private void SearchTb_TextChanged_1(object sender, EventArgs e)
        {
            List<Bus> listOfBus = br.GetAllBus();
            string keyword = SearchTb.Text.ToLower();
            List<Bus> searchedList = listOfBus.FindAll(x => ((x.BusName.ToLower()).Contains(keyword)) || ((x.From.ToLower()).Contains(keyword)) || ((x.To.ToLower()).Contains(keyword)) || ((x.Type.ToLower()).Contains(keyword)));

            this.BusTable2.DataSource = searchedList;

            for (int a = 0; a < searchedList.Count; a++)
            {
                BusTable2.Rows[a].Cells[0].Value = searchedList[a].BusId;
                BusTable2.Rows[a].Cells[1].Value = searchedList[a].BusName;
                BusTable2.Rows[a].Cells[2].Value = searchedList[a].From;
                BusTable2.Rows[a].Cells[3].Value = searchedList[a].To;
                BusTable2.Rows[a].Cells[4].Value = searchedList[a].Date;
                BusTable2.Rows[a].Cells[5].Value = searchedList[a].Time;
                BusTable2.Rows[a].Cells[6].Value = searchedList[a].Type;
                BusTable2.Rows[a].Cells[7].Value = searchedList[a].NumberOfSeats;
                BusTable2.Rows[a].Cells[8].Value = searchedList[a].Fare;
            }
        }
    }
}
