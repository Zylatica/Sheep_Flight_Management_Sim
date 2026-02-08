namespace AirportTestSimulator
{
    partial class AddFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlight));
            this.lbFlightList = new System.Windows.Forms.ListBox();
            this.btnAddNewFlight = new System.Windows.Forms.Button();
            this.cmbDestinationList = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.btnOpenEditScreen = new System.Windows.Forms.Button();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.lblSelectedFlight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAddFlight = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBanner = new System.Windows.Forms.PictureBox();
            this.gbAddFlight.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFlightList
            // 
            this.lbFlightList.FormattingEnabled = true;
            this.lbFlightList.ItemHeight = 25;
            this.lbFlightList.Location = new System.Drawing.Point(81, 271);
            this.lbFlightList.Name = "lbFlightList";
            this.lbFlightList.Size = new System.Drawing.Size(468, 454);
            this.lbFlightList.TabIndex = 0;
            // 
            // btnAddNewFlight
            // 
            this.btnAddNewFlight.Location = new System.Drawing.Point(15, 160);
            this.btnAddNewFlight.Name = "btnAddNewFlight";
            this.btnAddNewFlight.Size = new System.Drawing.Size(496, 101);
            this.btnAddNewFlight.TabIndex = 1;
            this.btnAddNewFlight.Text = "Add New Flight";
            this.btnAddNewFlight.UseVisualStyleBackColor = true;
            this.btnAddNewFlight.Click += new System.EventHandler(this.btnAddNewFlight_Click);
            // 
            // cmbDestinationList
            // 
            this.cmbDestinationList.AllowDrop = true;
            this.cmbDestinationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinationList.FormattingEnabled = true;
            this.cmbDestinationList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDestinationList.Items.AddRange(new object[] {
            "Baath",
            "Bleating Hill",
            "Cardigan",
            "Ewesbury",
            "High Jumpery",
            "Lambsville",
            "Rammington",
            "Shearsborough",
            "Sheeptown",
            "Woolsworth"});
            this.cmbDestinationList.Location = new System.Drawing.Point(15, 60);
            this.cmbDestinationList.Name = "cmbDestinationList";
            this.cmbDestinationList.Size = new System.Drawing.Size(238, 33);
            this.cmbDestinationList.Sorted = true;
            this.cmbDestinationList.TabIndex = 2;
            // 
            // cmbHour
            // 
            this.cmbHour.AllowDrop = true;
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHour.Location = new System.Drawing.Point(284, 60);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(98, 33);
            this.cmbHour.Sorted = true;
            this.cmbHour.TabIndex = 3;
            // 
            // cmbMinute
            // 
            this.cmbMinute.AllowDrop = true;
            this.cmbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMinute.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cmbMinute.Location = new System.Drawing.Point(413, 60);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(98, 33);
            this.cmbMinute.Sorted = true;
            this.cmbMinute.TabIndex = 4;
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.BackColor = System.Drawing.SystemColors.Window;
            this.lblConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConfirmation.Location = new System.Drawing.Point(15, 107);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(496, 40);
            this.lblConfirmation.TabIndex = 5;
            this.lblConfirmation.Text = "Waiting for new flight...";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenEditScreen
            // 
            this.btnOpenEditScreen.Location = new System.Drawing.Point(15, 34);
            this.btnOpenEditScreen.Name = "btnOpenEditScreen";
            this.btnOpenEditScreen.Size = new System.Drawing.Size(496, 101);
            this.btnOpenEditScreen.TabIndex = 6;
            this.btnOpenEditScreen.Text = "Edit Flight";
            this.btnOpenEditScreen.UseVisualStyleBackColor = true;
            this.btnOpenEditScreen.Click += new System.EventHandler(this.btnOpenEditScreen_Click);
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblSelectedTitle.Location = new System.Drawing.Point(10, 148);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(177, 25);
            this.lblSelectedTitle.TabIndex = 7;
            this.lblSelectedTitle.Text = "Currently Editing:";
            // 
            // lblSelectedFlight
            // 
            this.lblSelectedFlight.BackColor = System.Drawing.SystemColors.Window;
            this.lblSelectedFlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedFlight.Location = new System.Drawing.Point(15, 182);
            this.lblSelectedFlight.Name = "lblSelectedFlight";
            this.lblSelectedFlight.Size = new System.Drawing.Size(496, 92);
            this.lblSelectedFlight.TabIndex = 8;
            this.lblSelectedFlight.Text = "Please Select a Flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Destination:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(279, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Departure Time:";
            // 
            // gbAddFlight
            // 
            this.gbAddFlight.Controls.Add(this.btnAddNewFlight);
            this.gbAddFlight.Controls.Add(this.label2);
            this.gbAddFlight.Controls.Add(this.cmbDestinationList);
            this.gbAddFlight.Controls.Add(this.label1);
            this.gbAddFlight.Controls.Add(this.cmbHour);
            this.gbAddFlight.Controls.Add(this.cmbMinute);
            this.gbAddFlight.Controls.Add(this.lblConfirmation);
            this.gbAddFlight.Location = new System.Drawing.Point(576, 262);
            this.gbAddFlight.Name = "gbAddFlight";
            this.gbAddFlight.Size = new System.Drawing.Size(530, 279);
            this.gbAddFlight.TabIndex = 11;
            this.gbAddFlight.TabStop = false;
            this.gbAddFlight.Text = "Add a New Flight";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenEditScreen);
            this.groupBox1.Controls.Add(this.lblSelectedTitle);
            this.groupBox1.Controls.Add(this.lblSelectedFlight);
            this.groupBox1.Location = new System.Drawing.Point(576, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 303);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit an Existing Flight";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(81, 760);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(468, 61);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh Page";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBanner
            // 
            this.pictureBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBanner.BackgroundImage")));
            this.pictureBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBanner.Location = new System.Drawing.Point(136, 12);
            this.pictureBanner.Name = "pictureBanner";
            this.pictureBanner.Size = new System.Drawing.Size(897, 244);
            this.pictureBanner.TabIndex = 14;
            this.pictureBanner.TabStop = false;
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 877);
            this.Controls.Add(this.pictureBanner);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddFlight);
            this.Controls.Add(this.lbFlightList);
            this.Name = "AddFlight";
            this.Text = "Add Flights";
            this.gbAddFlight.ResumeLayout(false);
            this.gbAddFlight.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFlightList;
        private System.Windows.Forms.Button btnAddNewFlight;
        private System.Windows.Forms.ComboBox cmbDestinationList;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Button btnOpenEditScreen;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.Label lblSelectedFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAddFlight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBanner;
    }
}

