namespace HotelBooking
{
    partial class Booking
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
            this.cmbGb = new System.Windows.Forms.ComboBox();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGb
            // 
            this.cmbGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGb.FormattingEnabled = true;
            this.cmbGb.Location = new System.Drawing.Point(174, 213);
            this.cmbGb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbGb.Name = "cmbGb";
            this.cmbGb.Size = new System.Drawing.Size(294, 37);
            this.cmbGb.TabIndex = 77;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(480, 155);
            this.dataGridViewB.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersWidth = 51;
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.Size = new System.Drawing.Size(595, 308);
            this.dataGridViewB.TabIndex = 72;
            this.dataGridViewB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewB_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(275, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 28);
            this.label12.TabIndex = 70;
            this.label12.Text = "Entry";
            // 
            // btnBInsert
            // 
            this.btnBInsert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBInsert.Location = new System.Drawing.Point(174, 404);
            this.btnBInsert.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.btnBInsert.Name = "btnBInsert";
            this.btnBInsert.Size = new System.Drawing.Size(113, 59);
            this.btnBInsert.TabIndex = 67;
            this.btnBInsert.Text = "Insert";
            this.btnBInsert.UseVisualStyleBackColor = false;
            this.btnBInsert.Click += new System.EventHandler(this.btnGInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Guest";
            // 
            // txtBID
            // 
            this.txtBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.Location = new System.Drawing.Point(174, 155);
            this.txtBID.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(289, 34);
            this.txtBID.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "Booking Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(418, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 88);
            this.label1.TabIndex = 54;
            this.label1.Text = "Booking ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Room No";
            // 
            // cmbRb
            // 
            this.cmbRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRb.FormattingEnabled = true;
            this.cmbRb.Location = new System.Drawing.Point(174, 275);
            this.cmbRb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbRb.Name = "cmbRb";
            this.cmbRb.Size = new System.Drawing.Size(294, 37);
            this.cmbRb.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Spent Days";
            // 
            // txtSp
            // 
            this.txtSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSp.Location = new System.Drawing.Point(174, 344);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(292, 34);
            this.txtSp.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Spent Days";
            // 
            // txtSD
            // 
            this.txtSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSD.Location = new System.Drawing.Point(174, 344);
            this.txtSD.Name = "txtSD";
            this.txtSD.Size = new System.Drawing.Size(292, 34);
            this.txtSD.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(663, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 79;
            this.label7.Text = "Detail Info";
            // 
            // btnBdel
            // 
            this.btnBdel.BackColor = System.Drawing.Color.Red;
            this.btnBdel.Location = new System.Drawing.Point(349, 404);
            this.btnBdel.Name = "btnBdel";
            this.btnBdel.Size = new System.Drawing.Size(114, 59);
            this.btnBdel.TabIndex = 80;
            this.btnBdel.Text = "Delete";
            this.btnBdel.UseVisualStyleBackColor = false;
            this.btnBdel.Click += new System.EventHandler(this.btnBdel_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1091, 487);
            this.Controls.Add(this.btnBdel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSD);
            this.Controls.Add(this.txtSp);
            this.Controls.Add(this.cmbRb);
            this.Controls.Add(this.cmbGb);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGb;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBdel;
    }
}