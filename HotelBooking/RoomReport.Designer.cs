namespace HotelBooking
{
    partial class RoomReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.btnShowRoom = new System.Windows.Forms.Button();
            this.RptRoom = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new HotelBooking.CrystalReport1();
            this.CrystalReport12 = new HotelBooking.CrystalReport1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type wise Booking Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = " Room Type :";
            // 
            // comboRoom
            // 
            this.comboRoom.ForeColor = System.Drawing.Color.Red;
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(344, 78);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(211, 31);
            this.comboRoom.TabIndex = 2;
            // 
            // btnShowRoom
            // 
            this.btnShowRoom.Location = new System.Drawing.Point(628, 78);
            this.btnShowRoom.Name = "btnShowRoom";
            this.btnShowRoom.Size = new System.Drawing.Size(102, 31);
            this.btnShowRoom.TabIndex = 3;
            this.btnShowRoom.Text = "Show";
            this.btnShowRoom.UseVisualStyleBackColor = true;
            this.btnShowRoom.Click += new System.EventHandler(this.btnShowRoom_Click);
            // 
            // RptRoom
            // 
            this.RptRoom.ActiveViewIndex = 0;
            this.RptRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptRoom.Location = new System.Drawing.Point(12, 134);
            this.RptRoom.Name = "RptRoom";
            this.RptRoom.ReportSource = this.CrystalReport12;
            this.RptRoom.Size = new System.Drawing.Size(899, 522);
            this.RptRoom.TabIndex = 4;
            // 
            // RoomReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(923, 668);
            this.Controls.Add(this.RptRoom);
            this.Controls.Add(this.btnShowRoom);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomReport";
            this.Text = "Room Report";
            this.Load += new System.EventHandler(this.RoomReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Button btnShowRoom;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptRoom;
        private CrystalReport1 CrystalReport11;
        private CrystalReport1 CrystalReport12;
    }
}