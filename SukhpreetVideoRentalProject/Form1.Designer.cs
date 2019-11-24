namespace SukhpreetVideoRentalProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnLoadCustomer = new System.Windows.Forms.Button();
            this.CustomerGRP = new System.Windows.Forms.GroupBox();
            this.CDelete = new System.Windows.Forms.Button();
            this.CUpdate = new System.Windows.Forms.Button();
            this.CAdd = new System.Windows.Forms.Button();
            this.CAddress = new System.Windows.Forms.TextBox();
            this.CMobile = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoadRental = new System.Windows.Forms.Button();
            this.RentalGRP = new System.Windows.Forms.GroupBox();
            this.RentPK = new System.Windows.Forms.Label();
            this.MoviePK = new System.Windows.Forms.TextBox();
            this.CustomerPK = new System.Windows.Forms.TextBox();
            this.ReturnVideoDT = new System.Windows.Forms.DateTimePicker();
            this.IssueVideoDT = new System.Windows.Forms.DateTimePicker();
            this.RDelete = new System.Windows.Forms.Button();
            this.RReturn = new System.Windows.Forms.Button();
            this.RIssue = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MovieGrp = new System.Windows.Forms.GroupBox();
            this.Vcost = new System.Windows.Forms.TextBox();
            this.delVideo = new System.Windows.Forms.Button();
            this.updateVideo = new System.Windows.Forms.Button();
            this.VAdd = new System.Windows.Forms.Button();
            this.VGenre = new System.Windows.Forms.TextBox();
            this.VPlot = new System.Windows.Forms.TextBox();
            this.VCopies = new System.Windows.Forms.TextBox();
            this.VYear = new System.Windows.Forms.TextBox();
            this.VRatting = new System.Windows.Forms.TextBox();
            this.Vtitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Record = new System.Windows.Forms.DataGridView();
            this.btnCustomerRecord = new System.Windows.Forms.Button();
            this.btnRentalRecord = new System.Windows.Forms.Button();
            this.btnVideoRecord = new System.Windows.Forms.Button();
            this.btnBestCustomer = new System.Windows.Forms.Button();
            this.btnBestMovie = new System.Windows.Forms.Button();
            this.CustomerGRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.RentalGRP.SuspendLayout();
            this.MovieGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadCustomer
            // 
            this.btnLoadCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoadCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCustomer.ForeColor = System.Drawing.Color.White;
            this.btnLoadCustomer.Location = new System.Drawing.Point(12, 5);
            this.btnLoadCustomer.Name = "btnLoadCustomer";
            this.btnLoadCustomer.Size = new System.Drawing.Size(211, 38);
            this.btnLoadCustomer.TabIndex = 0;
            this.btnLoadCustomer.Text = "Customer Field";
            this.btnLoadCustomer.UseVisualStyleBackColor = false;
            this.btnLoadCustomer.Click += new System.EventHandler(this.btnLoadCustomer_Click);
            // 
            // CustomerGRP
            // 
            this.CustomerGRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CustomerGRP.Controls.Add(this.CDelete);
            this.CustomerGRP.Controls.Add(this.CUpdate);
            this.CustomerGRP.Controls.Add(this.CAdd);
            this.CustomerGRP.Controls.Add(this.CAddress);
            this.CustomerGRP.Controls.Add(this.CMobile);
            this.CustomerGRP.Controls.Add(this.CName);
            this.CustomerGRP.Controls.Add(this.label8);
            this.CustomerGRP.Controls.Add(this.label9);
            this.CustomerGRP.Controls.Add(this.label11);
            this.CustomerGRP.Location = new System.Drawing.Point(13, 50);
            this.CustomerGRP.Name = "CustomerGRP";
            this.CustomerGRP.Size = new System.Drawing.Size(303, 236);
            this.CustomerGRP.TabIndex = 1;
            this.CustomerGRP.TabStop = false;
            this.CustomerGRP.Text = "CustomerGRP";
            this.CustomerGRP.Visible = false;
            // 
            // CDelete
            // 
            this.CDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDelete.Location = new System.Drawing.Point(12, 185);
            this.CDelete.Name = "CDelete";
            this.CDelete.Size = new System.Drawing.Size(245, 45);
            this.CDelete.TabIndex = 125;
            this.CDelete.Text = "Delete";
            this.CDelete.UseVisualStyleBackColor = true;
            this.CDelete.Click += new System.EventHandler(this.CDelete_Click);
            // 
            // CUpdate
            // 
            this.CUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUpdate.Location = new System.Drawing.Point(132, 147);
            this.CUpdate.Name = "CUpdate";
            this.CUpdate.Size = new System.Drawing.Size(125, 32);
            this.CUpdate.TabIndex = 124;
            this.CUpdate.Text = "Update";
            this.CUpdate.UseVisualStyleBackColor = true;
            this.CUpdate.Click += new System.EventHandler(this.CUpdate_Click);
            // 
            // CAdd
            // 
            this.CAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAdd.Location = new System.Drawing.Point(10, 147);
            this.CAdd.Name = "CAdd";
            this.CAdd.Size = new System.Drawing.Size(104, 32);
            this.CAdd.TabIndex = 121;
            this.CAdd.Text = "Add";
            this.CAdd.UseVisualStyleBackColor = true;
            this.CAdd.Click += new System.EventHandler(this.CAdd_Click);
            // 
            // CAddress
            // 
            this.CAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAddress.Location = new System.Drawing.Point(132, 103);
            this.CAddress.Name = "CAddress";
            this.CAddress.Size = new System.Drawing.Size(125, 32);
            this.CAddress.TabIndex = 123;
            this.CAddress.Leave += new System.EventHandler(this.CAddress_Leave);
            // 
            // CMobile
            // 
            this.CMobile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMobile.Location = new System.Drawing.Point(132, 64);
            this.CMobile.Name = "CMobile";
            this.CMobile.Size = new System.Drawing.Size(125, 32);
            this.CMobile.TabIndex = 122;
            this.CMobile.Leave += new System.EventHandler(this.CMobile_Leave);
            // 
            // CName
            // 
            this.CName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.Location = new System.Drawing.Point(132, 26);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(125, 32);
            this.CName.TabIndex = 120;
            this.CName.Leave += new System.EventHandler(this.CName_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 119;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 118;
            this.label9.Text = "Phone No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 117;
            this.label11.Text = " Name";
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // btnLoadRental
            // 
            this.btnLoadRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoadRental.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRental.ForeColor = System.Drawing.Color.White;
            this.btnLoadRental.Location = new System.Drawing.Point(370, 2);
            this.btnLoadRental.Name = "btnLoadRental";
            this.btnLoadRental.Size = new System.Drawing.Size(211, 38);
            this.btnLoadRental.TabIndex = 2;
            this.btnLoadRental.Text = "Rental Field";
            this.btnLoadRental.UseVisualStyleBackColor = false;
            this.btnLoadRental.Click += new System.EventHandler(this.btnLoadRental_Click);
            // 
            // RentalGRP
            // 
            this.RentalGRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RentalGRP.Controls.Add(this.RentPK);
            this.RentalGRP.Controls.Add(this.MoviePK);
            this.RentalGRP.Controls.Add(this.CustomerPK);
            this.RentalGRP.Controls.Add(this.ReturnVideoDT);
            this.RentalGRP.Controls.Add(this.IssueVideoDT);
            this.RentalGRP.Controls.Add(this.RDelete);
            this.RentalGRP.Controls.Add(this.RReturn);
            this.RentalGRP.Controls.Add(this.RIssue);
            this.RentalGRP.Controls.Add(this.label12);
            this.RentalGRP.Controls.Add(this.label13);
            this.RentalGRP.Controls.Add(this.label14);
            this.RentalGRP.Controls.Add(this.label15);
            this.RentalGRP.Location = new System.Drawing.Point(317, 49);
            this.RentalGRP.Name = "RentalGRP";
            this.RentalGRP.Size = new System.Drawing.Size(338, 290);
            this.RentalGRP.TabIndex = 3;
            this.RentalGRP.TabStop = false;
            this.RentalGRP.Text = "RentalGRP";
            this.RentalGRP.Visible = false;
            // 
            // RentPK
            // 
            this.RentPK.AutoSize = true;
            this.RentPK.BackColor = System.Drawing.Color.Transparent;
            this.RentPK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentPK.ForeColor = System.Drawing.Color.White;
            this.RentPK.Location = new System.Drawing.Point(27, 246);
            this.RentPK.Name = "RentPK";
            this.RentPK.Size = new System.Drawing.Size(0, 24);
            this.RentPK.TabIndex = 140;
            this.RentPK.Visible = false;
            // 
            // MoviePK
            // 
            this.MoviePK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviePK.Location = new System.Drawing.Point(154, 52);
            this.MoviePK.Name = "MoviePK";
            this.MoviePK.Size = new System.Drawing.Size(154, 32);
            this.MoviePK.TabIndex = 139;
            this.MoviePK.Leave += new System.EventHandler(this.MoviePK_Leave);
            // 
            // CustomerPK
            // 
            this.CustomerPK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPK.Location = new System.Drawing.Point(154, 14);
            this.CustomerPK.Name = "CustomerPK";
            this.CustomerPK.Size = new System.Drawing.Size(154, 32);
            this.CustomerPK.TabIndex = 138;
            this.CustomerPK.Leave += new System.EventHandler(this.CustomerPK_Leave);
            // 
            // ReturnVideoDT
            // 
            this.ReturnVideoDT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideoDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnVideoDT.Location = new System.Drawing.Point(154, 128);
            this.ReturnVideoDT.Name = "ReturnVideoDT";
            this.ReturnVideoDT.Size = new System.Drawing.Size(154, 32);
            this.ReturnVideoDT.TabIndex = 137;
            // 
            // IssueVideoDT
            // 
            this.IssueVideoDT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueVideoDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueVideoDT.Location = new System.Drawing.Point(154, 90);
            this.IssueVideoDT.Name = "IssueVideoDT";
            this.IssueVideoDT.Size = new System.Drawing.Size(154, 32);
            this.IssueVideoDT.TabIndex = 136;
            // 
            // RDelete
            // 
            this.RDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDelete.Location = new System.Drawing.Point(21, 201);
            this.RDelete.Name = "RDelete";
            this.RDelete.Size = new System.Drawing.Size(274, 37);
            this.RDelete.TabIndex = 135;
            this.RDelete.Text = "Delete";
            this.RDelete.UseVisualStyleBackColor = true;
            this.RDelete.Click += new System.EventHandler(this.RDelete_Click);
            // 
            // RReturn
            // 
            this.RReturn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RReturn.Location = new System.Drawing.Point(141, 163);
            this.RReturn.Name = "RReturn";
            this.RReturn.Size = new System.Drawing.Size(154, 32);
            this.RReturn.TabIndex = 134;
            this.RReturn.Text = "Return";
            this.RReturn.UseVisualStyleBackColor = true;
            this.RReturn.Click += new System.EventHandler(this.RReturn_Click);
            // 
            // RIssue
            // 
            this.RIssue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RIssue.Location = new System.Drawing.Point(19, 163);
            this.RIssue.Name = "RIssue";
            this.RIssue.Size = new System.Drawing.Size(101, 32);
            this.RIssue.TabIndex = 133;
            this.RIssue.Text = "Issue";
            this.RIssue.UseVisualStyleBackColor = true;
            this.RIssue.Click += new System.EventHandler(this.RIssue_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 132;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 131;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 130;
            this.label14.Text = "Movie PK";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 24);
            this.label15.TabIndex = 129;
            this.label15.Text = "Customer PK";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(770, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Movie Field";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieGrp
            // 
            this.MovieGrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MovieGrp.Controls.Add(this.Vcost);
            this.MovieGrp.Controls.Add(this.delVideo);
            this.MovieGrp.Controls.Add(this.updateVideo);
            this.MovieGrp.Controls.Add(this.VAdd);
            this.MovieGrp.Controls.Add(this.VGenre);
            this.MovieGrp.Controls.Add(this.VPlot);
            this.MovieGrp.Controls.Add(this.VCopies);
            this.MovieGrp.Controls.Add(this.VYear);
            this.MovieGrp.Controls.Add(this.VRatting);
            this.MovieGrp.Controls.Add(this.Vtitle);
            this.MovieGrp.Controls.Add(this.label7);
            this.MovieGrp.Controls.Add(this.label6);
            this.MovieGrp.Controls.Add(this.label5);
            this.MovieGrp.Controls.Add(this.label4);
            this.MovieGrp.Controls.Add(this.label3);
            this.MovieGrp.Controls.Add(this.label2);
            this.MovieGrp.Controls.Add(this.label16);
            this.MovieGrp.Location = new System.Drawing.Point(655, 49);
            this.MovieGrp.Name = "MovieGrp";
            this.MovieGrp.Size = new System.Drawing.Size(363, 348);
            this.MovieGrp.TabIndex = 5;
            this.MovieGrp.TabStop = false;
            this.MovieGrp.Text = "VideoGRP";
            this.MovieGrp.Visible = false;
            // 
            // Vcost
            // 
            this.Vcost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vcost.Location = new System.Drawing.Point(126, 135);
            this.Vcost.Name = "Vcost";
            this.Vcost.Size = new System.Drawing.Size(154, 32);
            this.Vcost.TabIndex = 170;
            // 
            // delVideo
            // 
            this.delVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideo.Location = new System.Drawing.Point(190, 302);
            this.delVideo.Name = "delVideo";
            this.delVideo.Size = new System.Drawing.Size(85, 32);
            this.delVideo.TabIndex = 169;
            this.delVideo.Text = "Delete";
            this.delVideo.UseVisualStyleBackColor = true;
            this.delVideo.Click += new System.EventHandler(this.delVideo_Click);
            // 
            // updateVideo
            // 
            this.updateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideo.Location = new System.Drawing.Point(99, 302);
            this.updateVideo.Name = "updateVideo";
            this.updateVideo.Size = new System.Drawing.Size(85, 32);
            this.updateVideo.TabIndex = 168;
            this.updateVideo.Text = "Update";
            this.updateVideo.UseVisualStyleBackColor = true;
            this.updateVideo.Click += new System.EventHandler(this.updateVideo_Click);
            // 
            // VAdd
            // 
            this.VAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAdd.Location = new System.Drawing.Point(8, 302);
            this.VAdd.Name = "VAdd";
            this.VAdd.Size = new System.Drawing.Size(85, 32);
            this.VAdd.TabIndex = 167;
            this.VAdd.Text = "Add";
            this.VAdd.UseVisualStyleBackColor = true;
            this.VAdd.Click += new System.EventHandler(this.VAdd_Click);
            // 
            // VGenre
            // 
            this.VGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VGenre.Location = new System.Drawing.Point(126, 246);
            this.VGenre.Name = "VGenre";
            this.VGenre.Size = new System.Drawing.Size(154, 32);
            this.VGenre.TabIndex = 166;
            this.VGenre.Leave += new System.EventHandler(this.VGenre_Leave);
            // 
            // VPlot
            // 
            this.VPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VPlot.Location = new System.Drawing.Point(126, 210);
            this.VPlot.Name = "VPlot";
            this.VPlot.Size = new System.Drawing.Size(154, 32);
            this.VPlot.TabIndex = 165;
            this.VPlot.Leave += new System.EventHandler(this.VPlot_Leave);
            // 
            // VCopies
            // 
            this.VCopies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCopies.Location = new System.Drawing.Point(126, 172);
            this.VCopies.Name = "VCopies";
            this.VCopies.Size = new System.Drawing.Size(154, 32);
            this.VCopies.TabIndex = 164;
            this.VCopies.Leave += new System.EventHandler(this.VCopies_Leave);
            // 
            // VYear
            // 
            this.VYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VYear.Location = new System.Drawing.Point(126, 98);
            this.VYear.Name = "VYear";
            this.VYear.Size = new System.Drawing.Size(154, 32);
            this.VYear.TabIndex = 163;
            this.VYear.Leave += new System.EventHandler(this.VYear_Leave);
            // 
            // VRatting
            // 
            this.VRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VRatting.Location = new System.Drawing.Point(126, 60);
            this.VRatting.Name = "VRatting";
            this.VRatting.Size = new System.Drawing.Size(154, 32);
            this.VRatting.TabIndex = 162;
            this.VRatting.Leave += new System.EventHandler(this.VRatting_Leave);
            // 
            // Vtitle
            // 
            this.Vtitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vtitle.Location = new System.Drawing.Point(126, 22);
            this.Vtitle.Name = "Vtitle";
            this.Vtitle.Size = new System.Drawing.Size(154, 32);
            this.Vtitle.TabIndex = 161;
            this.Vtitle.Leave += new System.EventHandler(this.Vtitle_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 160;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 159;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 158;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 157;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 156;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 155;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(25, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 154;
            this.label16.Text = "Title";
            // 
            // Record
            // 
            this.Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record.Location = new System.Drawing.Point(25, 440);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(937, 167);
            this.Record.TabIndex = 6;
            this.Record.DoubleClick += new System.EventHandler(this.Record_DoubleClick);
            // 
            // btnCustomerRecord
            // 
            this.btnCustomerRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCustomerRecord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRecord.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRecord.Location = new System.Drawing.Point(12, 295);
            this.btnCustomerRecord.Name = "btnCustomerRecord";
            this.btnCustomerRecord.Size = new System.Drawing.Size(299, 38);
            this.btnCustomerRecord.TabIndex = 7;
            this.btnCustomerRecord.Text = "Customer Record";
            this.btnCustomerRecord.UseVisualStyleBackColor = false;
            this.btnCustomerRecord.Click += new System.EventHandler(this.btnCustomerRecord_Click);
            // 
            // btnRentalRecord
            // 
            this.btnRentalRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRentalRecord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalRecord.ForeColor = System.Drawing.Color.White;
            this.btnRentalRecord.Location = new System.Drawing.Point(333, 345);
            this.btnRentalRecord.Name = "btnRentalRecord";
            this.btnRentalRecord.Size = new System.Drawing.Size(299, 38);
            this.btnRentalRecord.TabIndex = 8;
            this.btnRentalRecord.Text = "Rental Record";
            this.btnRentalRecord.UseVisualStyleBackColor = false;
            this.btnRentalRecord.Click += new System.EventHandler(this.btnRentalRecord_Click);
            // 
            // btnVideoRecord
            // 
            this.btnVideoRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVideoRecord.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoRecord.ForeColor = System.Drawing.Color.White;
            this.btnVideoRecord.Location = new System.Drawing.Point(663, 396);
            this.btnVideoRecord.Name = "btnVideoRecord";
            this.btnVideoRecord.Size = new System.Drawing.Size(299, 38);
            this.btnVideoRecord.TabIndex = 9;
            this.btnVideoRecord.Text = "Video Record";
            this.btnVideoRecord.UseVisualStyleBackColor = false;
            this.btnVideoRecord.Click += new System.EventHandler(this.btnVideoRecord_Click);
            // 
            // btnBestCustomer
            // 
            this.btnBestCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBestCustomer.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestCustomer.ForeColor = System.Drawing.Color.White;
            this.btnBestCustomer.Location = new System.Drawing.Point(13, 351);
            this.btnBestCustomer.Name = "btnBestCustomer";
            this.btnBestCustomer.Size = new System.Drawing.Size(299, 38);
            this.btnBestCustomer.TabIndex = 10;
            this.btnBestCustomer.Text = "Best Customer";
            this.btnBestCustomer.UseVisualStyleBackColor = false;
            this.btnBestCustomer.Click += new System.EventHandler(this.btnBestCustomer_Click);
            // 
            // btnBestMovie
            // 
            this.btnBestMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBestMovie.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestMovie.ForeColor = System.Drawing.Color.White;
            this.btnBestMovie.Location = new System.Drawing.Point(333, 389);
            this.btnBestMovie.Name = "btnBestMovie";
            this.btnBestMovie.Size = new System.Drawing.Size(299, 38);
            this.btnBestMovie.TabIndex = 11;
            this.btnBestMovie.Text = "Best Movie";
            this.btnBestMovie.UseVisualStyleBackColor = false;
            this.btnBestMovie.Click += new System.EventHandler(this.btnBestMovie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1093, 637);
            this.Controls.Add(this.btnBestMovie);
            this.Controls.Add(this.btnBestCustomer);
            this.Controls.Add(this.btnVideoRecord);
            this.Controls.Add(this.btnRentalRecord);
            this.Controls.Add(this.btnCustomerRecord);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.MovieGrp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RentalGRP);
            this.Controls.Add(this.btnLoadRental);
            this.Controls.Add(this.CustomerGRP);
            this.Controls.Add(this.btnLoadCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CustomerGRP.ResumeLayout(false);
            this.CustomerGRP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.RentalGRP.ResumeLayout(false);
            this.RentalGRP.PerformLayout();
            this.MovieGrp.ResumeLayout(false);
            this.MovieGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Record)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCustomer;
        private System.Windows.Forms.GroupBox CustomerGRP;
        private System.Windows.Forms.Button CDelete;
        private System.Windows.Forms.Button CUpdate;
        private System.Windows.Forms.Button CAdd;
        private System.Windows.Forms.TextBox CAddress;
        private System.Windows.Forms.TextBox CMobile;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider Err;
        private System.Windows.Forms.Button btnLoadRental;
        private System.Windows.Forms.GroupBox RentalGRP;
        private System.Windows.Forms.TextBox MoviePK;
        private System.Windows.Forms.TextBox CustomerPK;
        private System.Windows.Forms.DateTimePicker ReturnVideoDT;
        private System.Windows.Forms.DateTimePicker IssueVideoDT;
        private System.Windows.Forms.Button RDelete;
        private System.Windows.Forms.Button RReturn;
        private System.Windows.Forms.Button RIssue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox MovieGrp;
        private System.Windows.Forms.TextBox Vcost;
        private System.Windows.Forms.Button delVideo;
        private System.Windows.Forms.Button updateVideo;
        private System.Windows.Forms.Button VAdd;
        private System.Windows.Forms.TextBox VGenre;
        private System.Windows.Forms.TextBox VPlot;
        private System.Windows.Forms.TextBox VCopies;
        private System.Windows.Forms.TextBox VYear;
        private System.Windows.Forms.TextBox VRatting;
        private System.Windows.Forms.TextBox Vtitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label RentPK;
        private System.Windows.Forms.DataGridView Record;
        private System.Windows.Forms.Button btnCustomerRecord;
        private System.Windows.Forms.Button btnRentalRecord;
        private System.Windows.Forms.Button btnVideoRecord;
        private System.Windows.Forms.Button btnBestCustomer;
        private System.Windows.Forms.Button btnBestMovie;
    }
}

