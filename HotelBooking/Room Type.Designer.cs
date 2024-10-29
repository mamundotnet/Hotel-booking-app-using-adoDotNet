namespace HotelBooking
{
    partial class Room_Type
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
            this.dataGridViewT = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTdelete = new System.Windows.Forms.Button();
            this.btnTUpdate = new System.Windows.Forms.Button();
            this.btnTInsert = new System.Windows.Forms.Button();
            this.txtTinsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTidinsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTIDupdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTupdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewT
            // 
            this.dataGridViewT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewT.Location = new System.Drawing.Point(34, 374);
            this.dataGridViewT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewT.Name = "dataGridViewT";
            this.dataGridViewT.RowHeadersWidth = 51;
            this.dataGridViewT.RowTemplate.Height = 24;
            this.dataGridViewT.Size = new System.Drawing.Size(782, 139);
            this.dataGridViewT.TabIndex = 35;
            this.dataGridViewT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewT_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(590, 97);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 28);
            this.label13.TabIndex = 34;
            this.label13.Text = "Edit/Delete";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(193, 97);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 28);
            this.label12.TabIndex = 33;
            this.label12.Text = "Entry";
            // 
            // btnTdelete
            // 
            this.btnTdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTdelete.Location = new System.Drawing.Point(716, 315);
            this.btnTdelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTdelete.Name = "btnTdelete";
            this.btnTdelete.Size = new System.Drawing.Size(100, 35);
            this.btnTdelete.TabIndex = 32;
            this.btnTdelete.Text = "Delete";
            this.btnTdelete.UseVisualStyleBackColor = false;
            this.btnTdelete.Click += new System.EventHandler(this.btnTdelete_Click);
            // 
            // btnTUpdate
            // 
            this.btnTUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnTUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTUpdate.Location = new System.Drawing.Point(543, 315);
            this.btnTUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTUpdate.Name = "btnTUpdate";
            this.btnTUpdate.Size = new System.Drawing.Size(137, 35);
            this.btnTUpdate.TabIndex = 31;
            this.btnTUpdate.Text = "Update";
            this.btnTUpdate.UseVisualStyleBackColor = false;
            this.btnTUpdate.Click += new System.EventHandler(this.btnTUpdate_Click);
            // 
            // btnTInsert
            // 
            this.btnTInsert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTInsert.Location = new System.Drawing.Point(176, 312);
            this.btnTInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTInsert.Name = "btnTInsert";
            this.btnTInsert.Size = new System.Drawing.Size(137, 40);
            this.btnTInsert.TabIndex = 30;
            this.btnTInsert.Text = "Insert";
            this.btnTInsert.UseVisualStyleBackColor = false;
            this.btnTInsert.Click += new System.EventHandler(this.btnGInsert_Click);
            // 
            // txtTinsert
            // 
            this.txtTinsert.Location = new System.Drawing.Point(125, 258);
            this.txtTinsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTinsert.Name = "txtTinsert";
            this.txtTinsert.Size = new System.Drawing.Size(262, 30);
            this.txtTinsert.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type";
            // 
            // txtTidinsert
            // 
            this.txtTidinsert.Location = new System.Drawing.Point(125, 183);
            this.txtTidinsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTidinsert.Name = "txtTidinsert";
            this.txtTidinsert.Size = new System.Drawing.Size(262, 30);
            this.txtTidinsert.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(346, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type Id";
            // 
            // txtTIDupdate
            // 
            this.txtTIDupdate.Location = new System.Drawing.Point(541, 183);
            this.txtTIDupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTIDupdate.Name = "txtTIDupdate";
            this.txtTIDupdate.Size = new System.Drawing.Size(273, 30);
            this.txtTIDupdate.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // txtTupdate
            // 
            this.txtTupdate.Location = new System.Drawing.Point(541, 249);
            this.txtTupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTupdate.Name = "txtTupdate";
            this.txtTupdate.Size = new System.Drawing.Size(273, 30);
            this.txtTupdate.TabIndex = 23;
            // 
            // Room_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 547);
            this.Controls.Add(this.dataGridViewT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTdelete);
            this.Controls.Add(this.btnTUpdate);
            this.Controls.Add(this.btnTInsert);
            this.Controls.Add(this.txtTupdate);
            this.Controls.Add(this.txtTinsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTIDupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTidinsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Room_Type";
            this.Text = "Room_Type";
            this.Load += new System.EventHandler(this.Room_Type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTdelete;
        private System.Windows.Forms.Button btnTUpdate;
        private System.Windows.Forms.Button btnTInsert;
        private System.Windows.Forms.TextBox txtTinsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTidinsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTIDupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTupdate;
    }
}