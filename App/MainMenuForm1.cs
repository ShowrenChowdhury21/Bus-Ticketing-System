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
    
    public partial class MainMenuForm1 : Form
    {
        Login l;
        BusRepo br;
        CustomerRepo cr=null;
        PlacesRepo pr;
        int count = 0;
        string tablebusname = "";
        string tabledate = "";
        string tabletime = "";
        string tableavailableseats = "";
        string tablefare = "";
        string tablebusid = "";
        string s = "";
        List<string> seatlist = new List<string>();
       
        

        public MainMenuForm1(Login l)
        {
            InitializeComponent();
            this.l = l;

            br = new BusRepo();
            cr = new CustomerRepo();
            pr = new PlacesRepo();

            seatlist.Clear();

            //nonacseatpanel.Refresh();
            //acseatpanel.Refresh();
        }
        private void logoutbtn_CLick(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Visible = true;
            this.Visible = false;
        }
        private void flightbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This part is under Development");
        }

        private void trainbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This part is under Development");
        }

        private void busbtn_Click(object sender, EventArgs e)
        {
            FromToPanel.Visible = true;
            WelcomePanel.Visible = false;
            BusTablePanel.Visible = false;
            CustomerDetailsPanel.Visible = false;
            acseatpanel.Visible = false;
            BusManageBtn.Visible = true;
            EmpManageBtn.Visible = true;
            CustomerDetailsBtn.Visible = true;
            List<Places> listofplaces = new List<Places>();
            listofplaces = pr.GetAllPlaces();
        }

        private void CustomerDetailsBtn_Click(object sender, EventArgs e)
        {
            CustomerDetails cm = new CustomerDetails(l);
            cm.Visible = true;
            this.Visible = false;
        }

        private void formclosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchBusbtn_Click(object sender, EventArgs e)
        {
            SeatBookBtn.Enabled = false;
            string from = FromCbox.Text;
            string to = ToCbox.Text;
            string date = DateTimePicker1.Text;
            string type = null;

            if (AcRbtn.Checked == true)
            {
                type = "Ac";
            }
            else if (NonAcRbtn.Checked == true)
            {
                type = "Non-Ac";
            }
            else { }

            int flag = 0;

            BusTable.Rows.Clear();

            List<Bus> listOfBus = null; ;
            listOfBus = br.GetAllBus(from, to, date, type);
            if (from != null && to != null && date != null && type != null)
            {
                for (int a = 0; a < listOfBus.Count; a++)
                {
                    BusTable.Rows.Add();
                    BusTable.Rows[a].Cells[0].Value = listOfBus[a].BusId;
                    BusTable.Rows[a].Cells[1].Value = listOfBus[a].BusName;
                    BusTable.Rows[a].Cells[2].Value = listOfBus[a].Date;
                    BusTable.Rows[a].Cells[3].Value = listOfBus[a].Time;
                    BusTable.Rows[a].Cells[4].Value = listOfBus[a].NumberOfSeats;
                    BusTable.Rows[a].Cells[5].Value = listOfBus[a].Fare;
                }

                flag = 1;

                if (flag == 1)
                {
                    BusTablePanel.Visible = true;
                    FromToPanel.Visible = false;
                    WelcomePanel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("oops! something is missing. Please check again!");
            } 
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FromToPanel.Visible = true;
            BusTablePanel.Visible = false;
            WelcomePanel.Visible = false;
        }
        
        private void SeatBookBtn_Click(object sender, EventArgs e)
        {
            br = new BusRepo();
            CustomerDetailsPanel.Visible = true;
            FromToPanel.Visible = false;
            WelcomePanel.Visible = false;
            BusTablePanel.Visible = false;
            Bus b = new Bus();
            b = br.GetBus(tablebusid, tablebusname, tabledate, tabletime, tableavailableseats, tablefare);
            if (b.Type == "AC")
            {
                acseatpanel.Visible = true;
                nonacseatpanel.Visible = false;
                if (b.A1 == 1) { A1btn.Enabled = false; } else { A1btn.Enabled = true; }
                if (b.A2 == 1) { A2btn.Enabled = false; } else { A2btn.Enabled = true; }
                if (b.A3 == 1) { A3btn.Enabled = false; } else { A3btn.Enabled = true; }
                //if (b.A4 == 1) { A4btn.Enabled = false; } else { A4btn.Enabled = true; }
                if (b.B1 == 1) { B1btn.Enabled = false; } else { B1btn.Enabled = true; }
                if (b.B2 == 1) { B2btn.Enabled = false; } else { B2btn.Enabled = true; }
                if (b.B3 == 1) { B3btn.Enabled = false; } else { B3btn.Enabled = true; }
                //if (b.B4 == 1) { B4btn.Enabled = false; } else { B4btn.Enabled = true; }
                if (b.C1 == 1) { C1btn.Enabled = false; } else { C1btn.Enabled = true; }
                if (b.C2 == 1) { C2btn.Enabled = false; } else { C2btn.Enabled = true; }
                if (b.C3 == 1) { C3btn.Enabled = false; } else { C3btn.Enabled = true; }
                //if (b.C4 == 1) { C4btn.Enabled = false; } else { C4btn.Enabled = true; }
                if (b.D1 == 1) { D1btn.Enabled = false; } else { D1btn.Enabled = true; }
                if (b.D2 == 1) { D2btn.Enabled = false; } else { D2btn.Enabled = true; }
                if (b.D3 == 1) { D3btn.Enabled = false; } else { D3btn.Enabled = true; }
                //if (b.D4 == 1) { D4btn.Enabled = false; } else { D4btn.Enabled = true; }
                if (b.E1 == 1) { E1btn.Enabled = false; } else { E1btn.Enabled = true; }
                if (b.E2 == 1) { E2btn.Enabled = false; } else { E2btn.Enabled = true; }
                if (b.E3 == 1) { E3btn.Enabled = false; } else { E3btn.Enabled = true; }
                //if (b.E4 == 1) { E4btn.Enabled = false; } else { E4btn.Enabled = true; }
                if (b.F1 == 1) { F1btn.Enabled = false; } else { F1btn.Enabled = true; }
                if (b.F2 == 1) { F2btn.Enabled = false; } else { F2btn.Enabled = true; }
                if (b.F3 == 1) { F3btn.Enabled = false; } else { F3btn.Enabled = true; }
                //if (b.F4 == 1) { F4btn.Enabled = false; } else { F4btn.Enabled = true; }
                if (b.G1 == 1) { G1btn.Enabled = false; } else { G1btn.Enabled = true; }
                if (b.G2 == 1) { G2btn.Enabled = false; } else { G2btn.Enabled = true; }
                if (b.G3 == 1) { G3btn.Enabled = false; } else { G3btn.Enabled = true; }
                //if (b.G4 == 1) { G4btn.Enabled = false; } else { G4btn.Enabled = true; }
                if (b.H1 == 1) { H1btn.Enabled = false; } else { H1btn.Enabled = true; }
                if (b.H2 == 1) { H2btn.Enabled = false; } else { H2btn.Enabled = true; }
                if (b.H3 == 1) { H3btn.Enabled = false; } else { H3btn.Enabled = true; }
                //if (b.H4 == 1) { H4btn.Enabled = false; } else { H4btn.Enabled = true; }
            }
            else if (b.Type == "Non-AC")
            {
                acseatpanel.Visible = false;
                nonacseatpanel.Visible = true;
                if (b.A1 == 1) { A1Button.Enabled = false; } else { A1Button.Enabled = true; }
                if (b.A2 == 1) { A2Button.Enabled = false; } else { A2Button.Enabled = true; }
                if (b.A3 == 1) { A3Button.Enabled = false; } else { A3Button.Enabled = true; }
                if (b.A4 == 1) { A4Button.Enabled = false; } else { A4Button.Enabled = true; }
                if (b.B1 == 1) { B1Button.Enabled = false; } else { B1Button.Enabled = true; }
                if (b.B2 == 1) { B2Button.Enabled = false; } else { B2Button.Enabled = true; }
                if (b.B3 == 1) { B3Button.Enabled = false; } else { B3Button.Enabled = true; }
                if (b.B4 == 1) { B4Button.Enabled = false; } else { B4Button.Enabled = true; }
                if (b.C1 == 1) { C1Button.Enabled = false; } else { C1Button.Enabled = true; }
                if (b.C2 == 1) { C2Button.Enabled = false; } else { C2Button.Enabled = true; }
                if (b.C3 == 1) { C3Button.Enabled = false; } else { C3Button.Enabled = true; }
                if (b.C4 == 1) { C4Button.Enabled = false; } else { C4Button.Enabled = true; }
                if (b.D1 == 1) { D1Button.Enabled = false; } else { D1Button.Enabled = true; }
                if (b.D2 == 1) { D2Button.Enabled = false; } else { D2Button.Enabled = true; }
                if (b.D3 == 1) { D3Button.Enabled = false; } else { D3Button.Enabled = true; }
                if (b.D4 == 1) { D4Button.Enabled = false; } else { D4Button.Enabled = true; }
                if (b.E1 == 1) { E1Button.Enabled = false; } else { E1Button.Enabled = true; }
                if (b.E2 == 1) { E2Button.Enabled = false; } else { E2Button.Enabled = true; }
                if (b.E3 == 1) { E3Button.Enabled = false; } else { E3Button.Enabled = true; }
                if (b.E4 == 1) { E4Button.Enabled = false; } else { E4Button.Enabled = true; }
                if (b.F1 == 1) { F1Button.Enabled = false; } else { F1Button.Enabled = true; }
                if (b.F2 == 1) { F2Button.Enabled = false; } else { F2Button.Enabled = true; }
                if (b.F3 == 1) { F3Button.Enabled = false; } else { F3Button.Enabled = true; }
                if (b.F4 == 1) { F4Button.Enabled = false; } else { F4Button.Enabled = true; }
                if (b.G1 == 1) { G1Button.Enabled = false; } else { G1Button.Enabled = true; }
                if (b.G2 == 1) { G2Button.Enabled = false; } else { G2Button.Enabled = true; }
                if (b.G3 == 1) { G3Button.Enabled = false; } else { G3Button.Enabled = true; }
                if (b.G4 == 1) { G4Button.Enabled = false; } else { G4Button.Enabled = true; }
                if (b.H1 == 1) { H1Button.Enabled = false; } else { H1Button.Enabled = true; }
                if (b.H2 == 1) { H2Button.Enabled = false; } else { H2Button.Enabled = true; }
                if (b.H3 == 1) { H3Button.Enabled = false; } else { H3Button.Enabled = true; }
                if (b.H4 == 1) { H4Button.Enabled = false; } else { H4Button.Enabled = true; }
            }
        }

        private void GoBack2_Click(object sender, EventArgs e)
        {
            BusTablePanel.Visible = true;
            WelcomePanel.Visible = false;
            FromToPanel.Visible = false;
            CustomerDetailsPanel.Visible = false;
            acseatpanel.Visible = false;
            nonacseatpanel.Visible = false;
            NameTb.Text = "";
            PhoneNumberTb.Text = "";
            count = 0;
            s = "";
            seatlist.Clear();
        }

        private void bustablecellclick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n = BusTable.CurrentCell.RowIndex;
                tablebusid = BusTable.Rows[n].Cells[0].FormattedValue.ToString();
                tablebusname = BusTable.Rows[n].Cells[1].FormattedValue.ToString();
                tabledate = BusTable.Rows[n].Cells[2].FormattedValue.ToString();
                tabletime = BusTable.Rows[n].Cells[3].FormattedValue.ToString();
                tableavailableseats = BusTable.Rows[n].Cells[4].FormattedValue.ToString();
                tablefare = BusTable.Rows[n].Cells[5].FormattedValue.ToString();
                SeatBookBtn.Enabled = true;
            }
            catch(Exception exp)
            {
                MessageBox.Show("Invalid Input!!");
            }
            
        }

        //public int a { get; set; }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text != "" && PhoneNumberTb.Text != "" && seatlist.Count != 0)
            {
                Bus b = new Bus();
                b = br.GetBus(tablebusid, tablebusname, tabledate, tabletime, tableavailableseats, tablefare);

                Customer c = new Customer();

                c.Name = NameTb.Text;
                try
                {
                    int phn = Convert.ToInt32(PhoneNumberTb.Text);
                    c.PhoneNumber = phn + "";
                }
                catch (Exception exp)
                {
                    MessageBox.Show("invalid phone number");
                }

                c.From = b.From;
                c.To = b.To;
                c.BusId = b.BusId;
                c.Date = b.Date;
                c.Time = b.Time;
                c.Type = b.Type;
                c.Fare = b.Fare * count;
                foreach (string item in seatlist)
                {
                    s = s + item + ",";
                }
                c.SeatNumber = s;

                if (cr.InsertCustomer(c))
                {
                    MessageBox.Show("seat booked. THANK YOU!");
                }
                else
                {
                    MessageBox.Show("Can Not Book: " + c.Name);
                }
                for (int i = 0; i < seatlist.Count; i++)
                {
                    br.UpdateSeat(b, seatlist[i]);
                }
                b.NumberOfSeats = b.NumberOfSeats - count;
                br.UpdateNumberSeat(b);


                PrintTicket p = new PrintTicket(c);
                p.Visible = true;
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Please fillup Name, Phone number and Seats");
            }
        }

        private void EmpManageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (l.Role == 1)
                {
                    EmployeeManagement em = new EmployeeManagement(l);
                    em.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Access Denied!!");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("...");
            }
        }

        private void BusManageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(l.Role == 1)
                {
                    BusManagemenet bm = new BusManagemenet(l);
                    bm.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Access Denied!!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("...");
            }

        }

        private void SeatBtn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Bus bb = new Bus();
            bb = br.GetBus(tablebusid, tablebusname, tabledate, tabletime, tableavailableseats, tablefare);
            if(b.BackColor.Equals(Color.FromArgb(20,20,20)))
            {
                b.BackColor = Color.FromArgb(145,189,58);
                count++;
                seatlist.Add(b.Text);
            }
            else if (b.BackColor.Equals(Color.FromArgb(145, 189, 58)))
            {
                b.BackColor = Color.FromArgb(20,20,20);
                count--;
                seatlist.Remove(b.Text);
            }
            Amount.Text = "" +(bb.Fare * count);

        }


    }
}
