namespace AirportTestSimulator
{
    partial class EditFlight
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
            this.lblShowDestination = new System.Windows.Forms.Label();
            this.lblShowHr = new System.Windows.Forms.Label();
            this.lblShowMin = new System.Windows.Forms.Label();
            this.lblShowCancelled = new System.Windows.Forms.Label();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCancelled = new System.Windows.Forms.Label();
            this.cmbNewHr = new System.Windows.Forms.ComboBox();
            this.cmbNewMin = new System.Windows.Forms.ComboBox();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbEditPanel = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.gbEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShowDestination
            // 
            this.lblShowDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowDestination.Location = new System.Drawing.Point(63, 72);
            this.lblShowDestination.Name = "lblShowDestination";
            this.lblShowDestination.Size = new System.Drawing.Size(186, 33);
            this.lblShowDestination.TabIndex = 0;
            this.lblShowDestination.Text = "Destination";
            this.lblShowDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowHr
            // 
            this.lblShowHr.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowHr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowHr.Location = new System.Drawing.Point(63, 146);
            this.lblShowHr.Name = "lblShowHr";
            this.lblShowHr.Size = new System.Drawing.Size(90, 33);
            this.lblShowHr.TabIndex = 1;
            this.lblShowHr.Text = "Hour";
            this.lblShowHr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowMin
            // 
            this.lblShowMin.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowMin.Location = new System.Drawing.Point(159, 146);
            this.lblShowMin.Name = "lblShowMin";
            this.lblShowMin.Size = new System.Drawing.Size(90, 33);
            this.lblShowMin.TabIndex = 2;
            this.lblShowMin.Text = "Minute";
            this.lblShowMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShowCancelled
            // 
            this.lblShowCancelled.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowCancelled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowCancelled.Location = new System.Drawing.Point(63, 221);
            this.lblShowCancelled.Name = "lblShowCancelled";
            this.lblShowCancelled.Size = new System.Drawing.Size(186, 33);
            this.lblShowCancelled.TabIndex = 3;
            this.lblShowCancelled.Text = "Active";
            this.lblShowCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(319, 191);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(186, 72);
            this.btnUpdateDetails.TabIndex = 4;
            this.btnUpdateDetails.Text = "Update Flight Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // lblDest
            // 
            this.lblDest.BackColor = System.Drawing.Color.Transparent;
            this.lblDest.Location = new System.Drawing.Point(58, 42);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(186, 30);
            this.lblDest.TabIndex = 5;
            this.lblDest.Text = "Destination:";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(58, 116);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(186, 30);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Departure Time:";
            // 
            // lblCancelled
            // 
            this.lblCancelled.BackColor = System.Drawing.SystemColors.Control;
            this.lblCancelled.Location = new System.Drawing.Point(58, 191);
            this.lblCancelled.Name = "lblCancelled";
            this.lblCancelled.Size = new System.Drawing.Size(186, 30);
            this.lblCancelled.TabIndex = 7;
            this.lblCancelled.Text = "Flight Status:";
            // 
            // cmbNewHr
            // 
            this.cmbNewHr.AllowDrop = true;
            this.cmbNewHr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewHr.FormattingEnabled = true;
            this.cmbNewHr.Items.AddRange(new object[] {
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
            this.cmbNewHr.Location = new System.Drawing.Point(319, 72);
            this.cmbNewHr.Name = "cmbNewHr";
            this.cmbNewHr.Size = new System.Drawing.Size(90, 33);
            this.cmbNewHr.TabIndex = 8;
            // 
            // cmbNewMin
            // 
            this.cmbNewMin.AllowDrop = true;
            this.cmbNewMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewMin.FormattingEnabled = true;
            this.cmbNewMin.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cmbNewMin.Location = new System.Drawing.Point(415, 72);
            this.cmbNewMin.Name = "cmbNewMin";
            this.cmbNewMin.Size = new System.Drawing.Size(90, 33);
            this.cmbNewMin.TabIndex = 9;
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.AllowDrop = true;
            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.FormattingEnabled = true;
            this.cmbNewStatus.Items.AddRange(new object[] {
            "Active",
            "Delayed",
            "Cancelled"});
            this.cmbNewStatus.Location = new System.Drawing.Point(319, 148);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Size = new System.Drawing.Size(186, 33);
            this.cmbNewStatus.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(314, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Change Status:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(314, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Change Time:";
            // 
            // gbEditPanel
            // 
            this.gbEditPanel.Controls.Add(this.btnUpdateDetails);
            this.gbEditPanel.Controls.Add(this.label2);
            this.gbEditPanel.Controls.Add(this.lblShowDestination);
            this.gbEditPanel.Controls.Add(this.label1);
            this.gbEditPanel.Controls.Add(this.lblShowHr);
            this.gbEditPanel.Controls.Add(this.cmbNewStatus);
            this.gbEditPanel.Controls.Add(this.lblShowMin);
            this.gbEditPanel.Controls.Add(this.cmbNewMin);
            this.gbEditPanel.Controls.Add(this.lblShowCancelled);
            this.gbEditPanel.Controls.Add(this.cmbNewHr);
            this.gbEditPanel.Controls.Add(this.lblDest);
            this.gbEditPanel.Controls.Add(this.lblCancelled);
            this.gbEditPanel.Controls.Add(this.lblTime);
            this.gbEditPanel.Location = new System.Drawing.Point(28, 107);
            this.gbEditPanel.Name = "gbEditPanel";
            this.gbEditPanel.Size = new System.Drawing.Size(560, 297);
            this.gbEditPanel.TabIndex = 13;
            this.gbEditPanel.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(91, 429);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(442, 53);
            this.btnFinish.TabIndex = 14;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // EditFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 521);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.gbEditPanel);
            this.Name = "EditFlight";
            this.Text = "EditFlight";
            this.gbEditPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShowDestination;
        private System.Windows.Forms.Label lblShowHr;
        private System.Windows.Forms.Label lblShowMin;
        private System.Windows.Forms.Label lblShowCancelled;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCancelled;
        private System.Windows.Forms.ComboBox cmbNewHr;
        private System.Windows.Forms.ComboBox cmbNewMin;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbEditPanel;
        private System.Windows.Forms.Button btnFinish;
    }
}