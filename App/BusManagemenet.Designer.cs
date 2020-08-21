namespace App
{
    partial class BusManagemenet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BusTable2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.BusIdTb = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.BusManagementLabel = new System.Windows.Forms.Label();
            this.BusNameTb = new System.Windows.Forms.TextBox();
            this.ToTb = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimeTb = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TypeTb = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SeatsTb = new System.Windows.Forms.TextBox();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.BusDateTime = new System.Windows.Forms.DateTimePicker();
            this.FareTb = new System.Windows.Forms.TextBox();
            this.FareLabel = new System.Windows.Forms.Label();
            this.FromTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BusTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BusTable2
            // 
            this.BusTable2.AllowUserToAddRows = false;
            this.BusTable2.AllowUserToDeleteRows = false;
            this.BusTable2.AllowUserToResizeColumns = false;
            this.BusTable2.AllowUserToResizeRows = false;
            this.BusTable2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BusTable2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BusTable2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BusTable2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BusTable2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BusTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusTable2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.from,
            this.to,
            this.date,
            this.time,
            this.type,
            this.seats,
            this.fare});
            this.BusTable2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.BusTable2.Location = new System.Drawing.Point(326, 127);
            this.BusTable2.Margin = new System.Windows.Forms.Padding(2);
            this.BusTable2.Name = "BusTable2";
            this.BusTable2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("BankGothic Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BusTable2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BusTable2.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("BankGothic Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.BusTable2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.BusTable2.RowTemplate.Height = 24;
            this.BusTable2.Size = new System.Drawing.Size(473, 318);
            this.BusTable2.TabIndex = 97;
            this.BusTable2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.busmanagementtableclick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            // 
            // seats
            // 
            this.seats.HeaderText = "Seats Available";
            this.seats.Name = "seats";
            // 
            // fare
            // 
            this.fare.HeaderText = "Fare";
            this.fare.Name = "fare";
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.Searchlabel.Location = new System.Drawing.Point(323, 82);
            this.Searchlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(122, 17);
            this.Searchlabel.TabIndex = 96;
            this.Searchlabel.Text = "Search Here";
            // 
            // SearchTb
            // 
            this.SearchTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SearchTb.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.SearchTb.Location = new System.Drawing.Point(466, 77);
            this.SearchTb.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(335, 27);
            this.SearchTb.TabIndex = 95;
            this.SearchTb.TextChanged += new System.EventHandler(this.SearchTb_TextChanged_1);
            // 
            // BusIdTb
            // 
            this.BusIdTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BusIdTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.BusIdTb.Location = new System.Drawing.Point(124, 127);
            this.BusIdTb.Margin = new System.Windows.Forms.Padding(2);
            this.BusIdTb.Name = "BusIdTb";
            this.BusIdTb.Size = new System.Drawing.Size(174, 22);
            this.BusIdTb.TabIndex = 94;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.IDLabel.Location = new System.Drawing.Point(20, 132);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(22, 14);
            this.IDLabel.TabIndex = 93;
            this.IDLabel.Text = "Id";
            // 
            // BusManagementLabel
            // 
            this.BusManagementLabel.AutoSize = true;
            this.BusManagementLabel.Font = new System.Drawing.Font("BankGothic Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusManagementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.BusManagementLabel.Location = new System.Drawing.Point(308, 18);
            this.BusManagementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BusManagementLabel.Name = "BusManagementLabel";
            this.BusManagementLabel.Size = new System.Drawing.Size(217, 23);
            this.BusManagementLabel.TabIndex = 92;
            this.BusManagementLabel.Text = "Bus Management";
            // 
            // BusNameTb
            // 
            this.BusNameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BusNameTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.BusNameTb.Location = new System.Drawing.Point(124, 162);
            this.BusNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.BusNameTb.Name = "BusNameTb";
            this.BusNameTb.Size = new System.Drawing.Size(174, 22);
            this.BusNameTb.TabIndex = 91;
            // 
            // ToTb
            // 
            this.ToTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ToTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.ToTb.Location = new System.Drawing.Point(124, 234);
            this.ToTb.Margin = new System.Windows.Forms.Padding(2);
            this.ToTb.Name = "ToTb";
            this.ToTb.Size = new System.Drawing.Size(174, 22);
            this.ToTb.TabIndex = 89;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.DateLabel.Location = new System.Drawing.Point(20, 271);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(45, 14);
            this.DateLabel.TabIndex = 87;
            this.DateLabel.Text = "Date";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.ToLabel.Location = new System.Drawing.Point(20, 237);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(26, 14);
            this.ToLabel.TabIndex = 86;
            this.ToLabel.Text = "To";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.FromLabel.Location = new System.Drawing.Point(20, 201);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(46, 14);
            this.FromLabel.TabIndex = 85;
            this.FromLabel.Text = "From";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.NameLabel.Location = new System.Drawing.Point(20, 166);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 14);
            this.NameLabel.TabIndex = 84;
            this.NameLabel.Text = "Name";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(495, 469);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 38);
            this.UpdateBtn.TabIndex = 82;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(612, 469);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(110, 38);
            this.RefreshBtn.TabIndex = 81;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(379, 469);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(110, 38);
            this.DeleteBtn.TabIndex = 80;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.InsertBtn.FlatAppearance.BorderSize = 0;
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(261, 469);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(110, 38);
            this.InsertBtn.TabIndex = 79;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.ShowAllBtn.FlatAppearance.BorderSize = 0;
            this.ShowAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllBtn.Font = new System.Drawing.Font("BankGothic Md BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllBtn.Location = new System.Drawing.Point(94, 469);
            this.ShowAllBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(160, 38);
            this.ShowAllBtn.TabIndex = 78;
            this.ShowAllBtn.Text = "Show All";
            this.ShowAllBtn.UseVisualStyleBackColor = false;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // Back
            // 
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("BankGothic Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.Back.Location = new System.Drawing.Point(9, 73);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 38);
            this.Back.TabIndex = 77;
            this.Back.Text = "Go back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(79, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 1);
            this.panel3.TabIndex = 76;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackgroundImage = global::App.Properties.Resources._006_logout;
            this.Logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.Location = new System.Drawing.Point(768, 18);
            this.Logoutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(33, 38);
            this.Logoutbtn.TabIndex = 75;
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::App.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // TimeTb
            // 
            this.TimeTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TimeTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.TimeTb.Location = new System.Drawing.Point(124, 306);
            this.TimeTb.Margin = new System.Windows.Forms.Padding(2);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(174, 22);
            this.TimeTb.TabIndex = 99;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.TimeLabel.Location = new System.Drawing.Point(20, 307);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(40, 14);
            this.TimeLabel.TabIndex = 98;
            this.TimeLabel.Text = "Time";
            // 
            // TypeTb
            // 
            this.TypeTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TypeTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.TypeTb.Location = new System.Drawing.Point(124, 342);
            this.TypeTb.Margin = new System.Windows.Forms.Padding(2);
            this.TypeTb.Name = "TypeTb";
            this.TypeTb.Size = new System.Drawing.Size(174, 22);
            this.TypeTb.TabIndex = 101;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.TypeLabel.Location = new System.Drawing.Point(20, 344);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(42, 14);
            this.TypeLabel.TabIndex = 100;
            this.TypeLabel.Text = "Type";
            // 
            // SeatsTb
            // 
            this.SeatsTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SeatsTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.SeatsTb.Location = new System.Drawing.Point(124, 379);
            this.SeatsTb.Margin = new System.Windows.Forms.Padding(2);
            this.SeatsTb.Name = "SeatsTb";
            this.SeatsTb.Size = new System.Drawing.Size(174, 22);
            this.SeatsTb.TabIndex = 103;
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.SeatLabel.Location = new System.Drawing.Point(20, 381);
            this.SeatLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(83, 14);
            this.SeatLabel.TabIndex = 102;
            this.SeatLabel.Text = "Seats Av.";
            // 
            // BusDateTime
            // 
            this.BusDateTime.CalendarFont = new System.Drawing.Font("BankGothic Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusDateTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.BusDateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BusDateTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BusDateTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.BusDateTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.BusDateTime.CustomFormat = "MM/dd/yyyy";
            this.BusDateTime.Font = new System.Drawing.Font("BankGothic Md BT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BusDateTime.Location = new System.Drawing.Point(124, 271);
            this.BusDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.BusDateTime.Name = "BusDateTime";
            this.BusDateTime.Size = new System.Drawing.Size(174, 18);
            this.BusDateTime.TabIndex = 105;
            this.BusDateTime.Value = new System.DateTime(2019, 12, 20, 0, 0, 0, 0);
            // 
            // FareTb
            // 
            this.FareTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FareTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FareTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.FareTb.Location = new System.Drawing.Point(124, 416);
            this.FareTb.Margin = new System.Windows.Forms.Padding(2);
            this.FareTb.Name = "FareTb";
            this.FareTb.Size = new System.Drawing.Size(174, 22);
            this.FareTb.TabIndex = 107;
            // 
            // FareLabel
            // 
            this.FareLabel.AutoSize = true;
            this.FareLabel.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FareLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.FareLabel.Location = new System.Drawing.Point(20, 418);
            this.FareLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FareLabel.Name = "FareLabel";
            this.FareLabel.Size = new System.Drawing.Size(43, 14);
            this.FareLabel.TabIndex = 106;
            this.FareLabel.Text = "Fare";
            // 
            // FromTb
            // 
            this.FromTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FromTb.Font = new System.Drawing.Font("BankGothic Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(55)))));
            this.FromTb.Location = new System.Drawing.Point(124, 198);
            this.FromTb.Margin = new System.Windows.Forms.Padding(2);
            this.FromTb.Name = "FromTb";
            this.FromTb.Size = new System.Drawing.Size(174, 22);
            this.FromTb.TabIndex = 90;
            // 
            // BusManagemenet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.FareTb);
            this.Controls.Add(this.FareLabel);
            this.Controls.Add(this.BusDateTime);
            this.Controls.Add(this.SeatsTb);
            this.Controls.Add(this.SeatLabel);
            this.Controls.Add(this.TypeTb);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TimeTb);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BusTable2);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.BusIdTb);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.BusManagementLabel);
            this.Controls.Add(this.BusNameTb);
            this.Controls.Add(this.FromTb);
            this.Controls.Add(this.ToTb);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BusManagemenet";
            this.Text = "BusManagemenet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formclosed);
            ((System.ComponentModel.ISupportInitialize)(this.BusTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BusTable2;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.TextBox BusIdTb;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label BusManagementLabel;
        private System.Windows.Forms.TextBox BusNameTb;
        private System.Windows.Forms.TextBox ToTb;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TimeTb;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TypeTb;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox SeatsTb;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.DateTimePicker BusDateTime;
        private System.Windows.Forms.TextBox FareTb;
        private System.Windows.Forms.Label FareLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn fare;
        private System.Windows.Forms.TextBox FromTb;
    }
}