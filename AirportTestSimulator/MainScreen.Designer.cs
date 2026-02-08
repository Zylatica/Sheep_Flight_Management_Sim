namespace AirportTestSimulator
{
    partial class MainScreen
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
            this.BtnAddF = new System.Windows.Forms.Button();
            this.BtnEditF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddF
            // 
            this.BtnAddF.Location = new System.Drawing.Point(87, 596);
            this.BtnAddF.Name = "BtnAddF";
            this.BtnAddF.Size = new System.Drawing.Size(413, 78);
            this.BtnAddF.TabIndex = 0;
            this.BtnAddF.Text = "Add Flight";
            this.BtnAddF.UseVisualStyleBackColor = true;
            this.BtnAddF.Click += new System.EventHandler(this.BtnAddF_Click);
            // 
            // BtnEditF
            // 
            this.BtnEditF.Location = new System.Drawing.Point(688, 596);
            this.BtnEditF.Name = "BtnEditF";
            this.BtnEditF.Size = new System.Drawing.Size(413, 78);
            this.BtnEditF.TabIndex = 1;
            this.BtnEditF.Text = "Edit Flight Details";
            this.BtnEditF.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.BtnEditF);
            this.Controls.Add(this.BtnAddF);
            this.Name = "MainScreen";
            this.Text = "All Flights";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddF;
        private System.Windows.Forms.Button BtnEditF;
    }
}