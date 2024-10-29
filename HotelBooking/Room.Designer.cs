namespace HotelBooking
{
    partial class Room
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
            this.dataGridViewR = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRdelete = new System.Windows.Forms.Button();
            this.btnRUpdate = new System.Windows.Forms.Button();
            this.btnRInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRIDinsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRentInsert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPictureInsert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRinsert = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPicture = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewR
            // 
            this.dataGridViewR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewR.Location = new System.Drawing.Point(63, 458);
            this.dataGridViewR.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.dataGridViewR.Name = "dataGridViewR";
            this.dataGridViewR.RowHeadersWidth = 51;
            this.dataGridViewR.RowTemplate.Height = 24;
            this.dataGridViewR.Size = new System.Drawing.Size(744, 175);
            this.dataGridViewR.TabIndex = 50;
            this.dataGridViewR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewR_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(253, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 28);
            this.label12.TabIndex = 48;
            this.label12.Text = "Entry";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnRdelete
            // 
            this.btnRdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRdelete.Location = new System.Drawing.Point(379, 384);
            this.btnRdelete.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRdelete.Name = "btnRdelete";
            this.btnRdelete.Size = new System.Drawing.Size(103, 47);
            this.btnRdelete.TabIndex = 47;
            this.btnRdelete.Text = "Delete";
            this.btnRdelete.UseVisualStyleBackColor = false;
            this.btnRdelete.Click += new System.EventHandler(this.btnRdelete_Click);
            // 
            // btnRUpdate
            // 
            this.btnRUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnRUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRUpdate.Location = new System.Drawing.Point(220, 384);
            this.btnRUpdate.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRUpdate.Name = "btnRUpdate";
            this.btnRUpdate.Size = new System.Drawing.Size(113, 47);
            this.btnRUpdate.TabIndex = 46;
            this.btnRUpdate.Text = "Update";
            this.btnRUpdate.UseVisualStyleBackColor = false;
            this.btnRUpdate.Click += new System.EventHandler(this.btnRUpdate_Click);
            // 
            // btnRInsert
            // 
            this.btnRInsert.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRInsert.Location = new System.Drawing.Point(63, 384);
            this.btnRInsert.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnRInsert.Name = "btnRInsert";
            this.btnRInsert.Size = new System.Drawing.Size(118, 47);
            this.btnRInsert.TabIndex = 45;
            this.btnRInsert.Text = "Insert";
            this.btnRInsert.UseVisualStyleBackColor = false;
            this.btnRInsert.Click += new System.EventHandler(this.btnRInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Room Type";
            // 
            // txtRIDinsert
            // 
            this.txtRIDinsert.Location = new System.Drawing.Point(163, 156);
            this.txtRIDinsert.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRIDinsert.Name = "txtRIDinsert";
            this.txtRIDinsert.Size = new System.Drawing.Size(319, 28);
            this.txtRIDinsert.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Room No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(421, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 44);
            this.label1.TabIndex = 36;
            this.label1.Text = "Room Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 38;
            this.label6.Text = "Rent";
            // 
            // txtRentInsert
            // 
            this.txtRentInsert.Location = new System.Drawing.Point(163, 251);
            this.txtRentInsert.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtRentInsert.Name = "txtRentInsert";
            this.txtRentInsert.Size = new System.Drawing.Size(319, 28);
            this.txtRentInsert.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Room Picture";
            // 
            // btnPictureInsert
            // 
            this.btnPictureInsert.Location = new System.Drawing.Point(200, 309);
            this.btnPictureInsert.Name = "btnPictureInsert";
            this.btnPictureInsert.Size = new System.Drawing.Size(75, 29);
            this.btnPictureInsert.TabIndex = 51;
            this.btnPictureInsert.Text = "...";
            this.btnPictureInsert.UseVisualStyleBackColor = true;
            this.btnPictureInsert.Click += new System.EventHandler(this.btnPictureInsert_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(554, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // cmbRinsert
            // 
            this.cmbRinsert.FormattingEnabled = true;
            this.cmbRinsert.Location = new System.Drawing.Point(163, 201);
            this.cmbRinsert.Name = "cmbRinsert";
            this.cmbRinsert.Size = new System.Drawing.Size(319, 30);
            this.cmbRinsert.TabIndex = 53;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(305, 311);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(177, 28);
            this.txtPicture.TabIndex = 54;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(862, 663);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.cmbRinsert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPictureInsert);
            this.Controls.Add(this.dataGridViewR);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnRdelete);
            this.Controls.Add(this.btnRUpdate);
            this.Controls.Add(this.btnRInsert);
            this.Controls.Add(this.txtRentInsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRIDinsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRdelete;
        private System.Windows.Forms.Button btnRUpdate;
        private System.Windows.Forms.Button btnRInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRIDinsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRentInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPictureInsert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbRinsert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPicture;
    }
}