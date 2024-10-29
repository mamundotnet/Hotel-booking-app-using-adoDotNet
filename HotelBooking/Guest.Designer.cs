namespace HotelBooking
{
    partial class Guest
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
            this.txtGIDinsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGNameinsert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGPhoneinsert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGNIDinsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerInsert = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGIDupdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGNameupdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGPhoneupdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGNIDupdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnGInsert = new System.Windows.Forms.Button();
            this.btnGUpdate = new System.Windows.Forms.Button();
            this.btnGdelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(427, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guest Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest Id ";
            // 
            // txtGIDinsert
            // 
            this.txtGIDinsert.Location = new System.Drawing.Point(163, 148);
            this.txtGIDinsert.Name = "txtGIDinsert";
            this.txtGIDinsert.Size = new System.Drawing.Size(261, 30);
            this.txtGIDinsert.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // txtGNameinsert
            // 
            this.txtGNameinsert.Location = new System.Drawing.Point(163, 196);
            this.txtGNameinsert.Name = "txtGNameinsert";
            this.txtGNameinsert.Size = new System.Drawing.Size(261, 30);
            this.txtGNameinsert.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone";
            // 
            // txtGPhoneinsert
            // 
            this.txtGPhoneinsert.Location = new System.Drawing.Point(163, 248);
            this.txtGPhoneinsert.Name = "txtGPhoneinsert";
            this.txtGPhoneinsert.Size = new System.Drawing.Size(261, 30);
            this.txtGPhoneinsert.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "NID";
            // 
            // txtGNIDinsert
            // 
            this.txtGNIDinsert.Location = new System.Drawing.Point(163, 303);
            this.txtGNIDinsert.Name = "txtGNIDinsert";
            this.txtGNIDinsert.Size = new System.Drawing.Size(261, 30);
            this.txtGNIDinsert.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "DateOfBirth";
            // 
            // dateTimePickerInsert
            // 
            this.dateTimePickerInsert.Location = new System.Drawing.Point(163, 356);
            this.dateTimePickerInsert.Name = "dateTimePickerInsert";
            this.dateTimePickerInsert.Size = new System.Drawing.Size(261, 30);
            this.dateTimePickerInsert.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Guest Id ";
            // 
            // txtGIDupdate
            // 
            this.txtGIDupdate.Location = new System.Drawing.Point(636, 148);
            this.txtGIDupdate.Name = "txtGIDupdate";
            this.txtGIDupdate.Size = new System.Drawing.Size(261, 30);
            this.txtGIDupdate.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            // 
            // txtGNameupdate
            // 
            this.txtGNameupdate.Location = new System.Drawing.Point(636, 196);
            this.txtGNameupdate.Name = "txtGNameupdate";
            this.txtGNameupdate.Size = new System.Drawing.Size(261, 30);
            this.txtGNameupdate.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Phone";
            // 
            // txtGPhoneupdate
            // 
            this.txtGPhoneupdate.Location = new System.Drawing.Point(636, 248);
            this.txtGPhoneupdate.Name = "txtGPhoneupdate";
            this.txtGPhoneupdate.Size = new System.Drawing.Size(261, 30);
            this.txtGPhoneupdate.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 308);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "NID";
            // 
            // txtGNIDupdate
            // 
            this.txtGNIDupdate.Location = new System.Drawing.Point(636, 303);
            this.txtGNIDupdate.Name = "txtGNIDupdate";
            this.txtGNIDupdate.Size = new System.Drawing.Size(261, 30);
            this.txtGNIDupdate.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(517, 361);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "DateOfBirth";
            // 
            // dateTimePickerUpdate
            // 
            this.dateTimePickerUpdate.Location = new System.Drawing.Point(636, 356);
            this.dateTimePickerUpdate.Name = "dateTimePickerUpdate";
            this.dateTimePickerUpdate.Size = new System.Drawing.Size(261, 30);
            this.dateTimePickerUpdate.TabIndex = 8;
            // 
            // btnGInsert
            // 
            this.btnGInsert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGInsert.Location = new System.Drawing.Point(214, 407);
            this.btnGInsert.Name = "btnGInsert";
            this.btnGInsert.Size = new System.Drawing.Size(120, 34);
            this.btnGInsert.TabIndex = 4;
            this.btnGInsert.Text = "Insert";
            this.btnGInsert.UseVisualStyleBackColor = false;
            this.btnGInsert.Click += new System.EventHandler(this.btnGInsert_Click);
            // 
            // btnGUpdate
            // 
            this.btnGUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnGUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGUpdate.Location = new System.Drawing.Point(636, 409);
            this.btnGUpdate.Name = "btnGUpdate";
            this.btnGUpdate.Size = new System.Drawing.Size(104, 32);
            this.btnGUpdate.TabIndex = 5;
            this.btnGUpdate.Text = "Update";
            this.btnGUpdate.UseVisualStyleBackColor = false;
            this.btnGUpdate.Click += new System.EventHandler(this.btnGUpdate_Click);
            // 
            // btnGdelete
            // 
            this.btnGdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGdelete.Location = new System.Drawing.Point(802, 409);
            this.btnGdelete.Name = "btnGdelete";
            this.btnGdelete.Size = new System.Drawing.Size(95, 32);
            this.btnGdelete.TabIndex = 6;
            this.btnGdelete.Text = "Delete";
            this.btnGdelete.UseVisualStyleBackColor = false;
            this.btnGdelete.Click += new System.EventHandler(this.btnGdelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 28);
            this.label12.TabIndex = 7;
            this.label12.Text = "Entry";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(691, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 28);
            this.label13.TabIndex = 7;
            this.label13.Text = "Edit/Delete";
            // 
            // dataGridViewG
            // 
            this.dataGridViewG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewG.Location = new System.Drawing.Point(49, 460);
            this.dataGridViewG.Name = "dataGridViewG";
            this.dataGridViewG.RowHeadersWidth = 51;
            this.dataGridViewG.RowTemplate.Height = 24;
            this.dataGridViewG.Size = new System.Drawing.Size(848, 191);
            this.dataGridViewG.TabIndex = 8;
            this.dataGridViewG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewG_CellContentClick);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(960, 680);
            this.Controls.Add(this.dataGridViewG);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGdelete);
            this.Controls.Add(this.btnGUpdate);
            this.Controls.Add(this.btnGInsert);
            this.Controls.Add(this.dateTimePickerUpdate);
            this.Controls.Add(this.dateTimePickerInsert);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGNIDupdate);
            this.Controls.Add(this.txtGNIDinsert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGPhoneupdate);
            this.Controls.Add(this.txtGPhoneinsert);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGNameupdate);
            this.Controls.Add(this.txtGNameinsert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGIDupdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGIDinsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Guest";
            this.Text = "Guest";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGIDinsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGNameinsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGPhoneinsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGNIDinsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGIDupdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGNameupdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGPhoneupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGNIDupdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpdate;
        private System.Windows.Forms.Button btnGInsert;
        private System.Windows.Forms.Button btnGUpdate;
        private System.Windows.Forms.Button btnGdelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewG;
    }
}