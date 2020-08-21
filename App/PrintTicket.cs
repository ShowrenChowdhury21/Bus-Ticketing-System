using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using Entity;



namespace App
{
    public partial class PrintTicket : Form
    {
        Customer c;
        MainMenuForm1 mf;

        public PrintTicket(Customer c)
        {
            InitializeComponent();
            //c= new Customer();

            dateTextBox.Text = c.Date;
            idTextBox.Text = c.BusId;
            nameTextBox.Text = c.Name;
            mobileTextBox.Text = c.PhoneNumber;
            fromTextBox.Text = c.From;
            toTextBox.Text = c.To;
            seatnumberTextBox.Text = c.SeatNumber;
            totalfareTextBox.Text = c.Fare+"";
        }

        private void pdfbutton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
              {
                  if (sfd.ShowDialog() == DialogResult.OK)
                  {


                      iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 100f, 100f, 100f, 20f);
                        
                      

                      try
                      {
                          PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                          doc.Open();

                          iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance("D:/C#/Project Full And Final/New folder/App/Resources/Untitled.png");
                          jpg.ScaleToFit(400f, 380f);
                          jpg.SpacingBefore = 10f;
                          jpg.SpacingAfter = 50f;
                          jpg.Alignment = Element.ALIGN_CENTER;


                          //iTextSharp.text.Image jpgAC = iTextSharp.text.Image.GetInstance("E:/Project/App/Resources/AC.png");
                          //jpgAC.ScaleToFit(300f, 280f);
                          //jpgAC.SpacingBefore = 10f;
                          //jpgAC.SpacingAfter = 1f;
                          //jpgAC.Alignment = Element.ALIGN_CENTER;

                          iTextSharp.text.Font paraFont1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 18, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
                          iTextSharp.text.Font paraFont2 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 15, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE);
                          iTextSharp.text.Font paraFont3 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);


                          

                         // chunk.SetUnderline(0.5f, -1.5f);

                          Paragraph p = new iTextSharp.text.Paragraph(" ",paraFont3);


                          Paragraph ps = new iTextSharp.text.Paragraph(" Authority Signeture ", paraFont3);

                          Phrase date_phrase = new Phrase();
                          Chunk chunk1 = new Chunk("Date :   ", paraFont2);
                          Chunk chunk2 = new Chunk(dateTextBox.Text, paraFont1);
                          chunk2.SetUnderline(1.2f, -1.5f);

                          date_phrase.Add(chunk1);
                          date_phrase.Add(chunk2);

                          Phrase id_phrase = new Phrase();
                          Chunk chunk3 = new Chunk("Bus ID :   ", paraFont2);
                          Chunk chunk4 = new Chunk(idTextBox.Text, paraFont1);
                          id_phrase.Add(chunk3);
                          id_phrase.Add(chunk4);

                          Phrase customerName_phrase = new Phrase();
                          Chunk chunk5 = new Chunk("Customer Name :   ", paraFont2);
                          Chunk chunk6 = new Chunk(nameTextBox.Text, paraFont1);
                          customerName_phrase.Add(chunk5);
                          customerName_phrase.Add(chunk6);

                          Phrase mobile_phrase = new Phrase();
                          Chunk chunk7 = new Chunk("Mobile Number :   ", paraFont2);
                          Chunk chunk8 = new Chunk(mobileTextBox.Text, paraFont1);
                          mobile_phrase.Add(chunk7);
                          mobile_phrase.Add(chunk8);

                          Phrase fromto_phrase = new Phrase();
                          Chunk chunk9 = new Chunk("From :   ", paraFont2);
                          Chunk chunk10 = new Chunk(fromTextBox.Text, paraFont1);
                          Chunk chunk0 = new Chunk("        ", paraFont1);

                          Chunk chunk11 = new Chunk("To :   ", paraFont2);
                          Chunk chunk12 = new Chunk(toTextBox.Text, paraFont1);

                          fromto_phrase.Add(chunk9);
                          fromto_phrase.Add(chunk10);
                          fromto_phrase.Add(chunk0);
                          fromto_phrase.Add(chunk11);
                          fromto_phrase.Add(chunk12);

                          Phrase seat_phrase = new Phrase();
                          Chunk chunk13 = new Chunk("Seat Number :   ", paraFont2);
                          Chunk chunk14 = new Chunk(seatnumberTextBox.Text, paraFont1);
                          chunk14.SetUnderline(1.2f, -1.5f);

                          seat_phrase.Add(chunk13);
                          seat_phrase.Add(chunk14);

                          Phrase total_phrase = new Phrase();
                          Chunk chunk15 = new Chunk("Total Fare :   ", paraFont2);
                          Chunk chunk16 = new Chunk(totalfareTextBox.Text, paraFont1);
                          total_phrase.Add(chunk15);
                          total_phrase.Add(chunk16);

                          Paragraph p1 = new iTextSharp.text.Paragraph(date_phrase);
                          Paragraph p2 = new iTextSharp.text.Paragraph(id_phrase);
                          Paragraph p3 = new iTextSharp.text.Paragraph(customerName_phrase);
                          Paragraph p4 = new iTextSharp.text.Paragraph(mobile_phrase);
                          Paragraph p5 = new iTextSharp.text.Paragraph(fromto_phrase);
                          Paragraph p6 = new iTextSharp.text.Paragraph(seat_phrase);
                          Paragraph p7 = new iTextSharp.text.Paragraph(total_phrase);

                          doc.Add(jpg);
                          for (int i = 0; i < 5; i++)
                          {
                              doc.Add(p);
                          }
                              
                          doc.Add(p1);
                          doc.Add(p);
                          doc.Add(p2);
                          doc.Add(p);
                          doc.Add(p3);
                          doc.Add(p);
                          doc.Add(p4);
                          doc.Add(p);
                          doc.Add(p5);
                          doc.Add(p);
                          doc.Add(p6);
                          doc.Add(p);
                          doc.Add(p7);
                          for (int i = 0; i < 7; i++)
                          {
                              doc.Add(p);
                          }
                          doc.Add(ps);
                          //doc.Add(jpgAC);
                          
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                      finally
                      {
                          doc.Close();
                      }

                  }
              }
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bookanother_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.mf = new MainMenuForm1(l); 
            mf.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Visible = true;
            this.Visible = false;
        }

















        public Login l { get; set; }
    }
}
