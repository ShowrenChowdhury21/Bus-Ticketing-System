namespace App
{
    partial class PrintTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button pdfbutton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintTicket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.busid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookanother = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.totalfareTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seatnumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            pdfbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfbutton
            // 
            pdfbutton.BackColor = System.Drawing.Color.Gainsboro;
            pdfbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pdfbutton.BackgroundImage")));
            pdfbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pdfbutton.CausesValidation = false;
            pdfbutton.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pdfbutton.ForeColor = System.Drawing.SystemColors.ControlLight;
            pdfbutton.Location = new System.Drawing.Point(228, 521);
            pdfbutton.Name = "pdfbutton";
            pdfbutton.Size = new System.Drawing.Size(127, 122);
            pdfbutton.TabIndex = 31;
            pdfbutton.UseVisualStyleBackColor = false;
            pdfbutton.Click += new System.EventHandler(this.pdfbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::App.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(308, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 93);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 105);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackgroundImage = global::App.Properties.Resources._006_logout;
            this.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Location = new System.Drawing.Point(675, 31);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(44, 47);
            this.logoutbtn.TabIndex = 44;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.name.Location = new System.Drawing.Point(243, 270);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 16);
            this.name.TabIndex = 26;
            this.name.Text = "Name:";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.from.Location = new System.Drawing.Point(244, 344);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(61, 16);
            this.from.TabIndex = 27;
            this.from.Text = "From:";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.to.Location = new System.Drawing.Point(269, 376);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(36, 16);
            this.to.TabIndex = 28;
            this.to.Text = "To:";
            // 
            // busid
            // 
            this.busid.AutoSize = true;
            this.busid.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.busid.Location = new System.Drawing.Point(228, 238);
            this.busid.Name = "busid";
            this.busid.Size = new System.Drawing.Size(84, 16);
            this.busid.TabIndex = 29;
            this.busid.Text = "Bus ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(245, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Date: ";
            // 
            // bookanother
            // 
            this.bookanother.BackColor = System.Drawing.Color.Gainsboro;
            this.bookanother.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookanother.BackgroundImage")));
            this.bookanother.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookanother.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookanother.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.bookanother.Location = new System.Drawing.Point(402, 521);
            this.bookanother.Name = "bookanother";
            this.bookanother.Size = new System.Drawing.Size(133, 122);
            this.bookanother.TabIndex = 32;
            this.bookanother.Text = "Book Another";
            this.bookanother.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bookanother.UseVisualStyleBackColor = false;
            this.bookanother.Click += new System.EventHandler(this.bookanother_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(335, 238);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(237, 17);
            this.idTextBox.TabIndex = 33;
            this.idTextBox.Text = " ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(335, 270);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(237, 17);
            this.nameTextBox.TabIndex = 34;
            this.nameTextBox.Text = " ";
            // 
            // fromTextBox
            // 
            this.fromTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(335, 336);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.Size = new System.Drawing.Size(237, 17);
            this.fromTextBox.TabIndex = 35;
            this.fromTextBox.Text = " ";
            // 
            // toTextBox
            // 
            this.toTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextBox.Location = new System.Drawing.Point(335, 371);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.ReadOnly = true;
            this.toTextBox.Size = new System.Drawing.Size(237, 17);
            this.toTextBox.TabIndex = 36;
            this.toTextBox.Text = " ";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(335, 206);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(236, 17);
            this.dateTextBox.TabIndex = 37;
            this.dateTextBox.Text = " ";
            // 
            // totalfareTextBox
            // 
            this.totalfareTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalfareTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalfareTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfareTextBox.Location = new System.Drawing.Point(335, 438);
            this.totalfareTextBox.Name = "totalfareTextBox";
            this.totalfareTextBox.ReadOnly = true;
            this.totalfareTextBox.Size = new System.Drawing.Size(237, 17);
            this.totalfareTextBox.TabIndex = 39;
            this.totalfareTextBox.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(189, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Total Fare:";
            // 
            // seatnumberTextBox
            // 
            this.seatnumberTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seatnumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seatnumberTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatnumberTextBox.Location = new System.Drawing.Point(335, 405);
            this.seatnumberTextBox.Name = "seatnumberTextBox";
            this.seatnumberTextBox.ReadOnly = true;
            this.seatnumberTextBox.Size = new System.Drawing.Size(237, 17);
            this.seatnumberTextBox.TabIndex = 41;
            this.seatnumberTextBox.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(170, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Seat Number:";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mobileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobileTextBox.Font = new System.Drawing.Font("BankGothic Md BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Location = new System.Drawing.Point(335, 302);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.ReadOnly = true;
            this.mobileTextBox.Size = new System.Drawing.Size(237, 17);
            this.mobileTextBox.TabIndex = 43;
            this.mobileTextBox.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(229, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mobile:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Booking Details";
            // 
            // PrintTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(734, 744);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seatnumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalfareTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.bookanother);
            this.Controls.Add(pdfbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busid);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.name);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("BankGothic Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PrintTicket";
            this.Text = "PrintTicket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label busid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bookanother;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox totalfareTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seatnumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label5;
    }
}