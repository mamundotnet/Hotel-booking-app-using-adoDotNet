using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class Room : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=F:\PROJECTADO.NET\HOTELBOOKING\HOTELBOOKING\BOOKINGDB.MDF;Integrated Security=True");
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadHotelBookingCombo();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Room", sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridViewR.DataSource = dt;
            sqlcon.Close();
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(roomNo),0)+1 FROM Room", sqlcon))
            {
                sqlcon.Open();
                int newId = (int)cmd.ExecuteScalar();
                txtRIDinsert.Text = newId.ToString();
                sqlcon.Close();
            }

        }           
        private void LoadHotelBookingCombo()
        {
            sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select typeId,typeName from RoomType", sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            DataRow newRow = ds.Tables[0].NewRow();
            newRow[0] = "-1";
            newRow[1] = "---Select Type---";
            ds.Tables[0].Rows.InsertAt(newRow, 0);
            cmbRinsert.DataSource = ds.Tables[0];
            cmbRinsert.DisplayMember = "typeName";
            cmbRinsert.ValueMember = "typeId";

            sqlcon.Close();

        }

        private void btnRInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtPicture.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                sqlcon.Open();


                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText =
                    @"insert into Room(roomNo,typeId,rent,roomPicture) values (@i,@t,@rn,@p)";
                sqlcmd.Parameters.AddWithValue("@i", txtRIDinsert.Text);
                sqlcmd.Parameters.AddWithValue("@t", cmbRinsert.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@rn", txtRentInsert.Text);
                sqlcmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary)
                { Value = ms.ToArray() });
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest Information Inserted SuccessFully !!", "Insert Message");
                LoadGrid();
               
                cmbRinsert.SelectedIndex = -1;
                txtRentInsert.Text = "";
                pictureBox1.Image = null;
                sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Valid Data!!\n" + ex.Message);
                sqlcon.Close();
            }
        }

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (txtPicture.Text != "")
            {
                Image img = Image.FromFile(txtPicture.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText =
                @"UPDATE Room SET roomNo=@i,typeId=@t,rent=@rn,roomPicture=@p WHERE roomNo=@i";
                sqlcmd.Parameters.AddWithValue("@i", txtRIDinsert.Text);
                sqlcmd.Parameters.AddWithValue("@t", cmbRinsert.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@rn", txtRentInsert.Text);
                sqlcmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary)
                { Value = ms.ToArray() });
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest Information Updated SuccessFully !!", "Update Message");
                LoadGrid();
                
                cmbRinsert.SelectedIndex = -1;
                txtRentInsert.Text = "";
                pictureBox1.Image = null;
                sqlcon.Close();
            }
            else
            {
                SqlCommand sqlcmd = new SqlCommand(@"UPDATE Room SET roomNo=@i,typeId=@t,rent=@rn WHERE roomNo=@i");
                sqlcmd.Parameters.AddWithValue("@i", txtRIDinsert.Text);
                sqlcmd.Parameters.AddWithValue("@t", cmbRinsert.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@rn", txtRentInsert.Text);
                
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest Information Updated SuccessFully !!", "Update Message");
                LoadGrid();
                
                cmbRinsert.SelectedIndex = -1;
                txtRentInsert.Text = "";
                pictureBox1.Image = null;
                sqlcon.Close();
            }
        }

        private void btnRdelete_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (txtPicture.Text != "")
            {
                Image img = Image.FromFile(txtPicture.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText =
                @"DELETE FROM Room WHERE roomNo=@i";
                sqlcmd.Parameters.AddWithValue("@i", txtRIDinsert.Text);
                sqlcmd.Parameters.AddWithValue("@t", cmbRinsert.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@rn", txtRentInsert.Text);
                sqlcmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary)
                { Value = ms.ToArray() });
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest Information Deleted SuccessFully !!", "Delete Message");
                LoadGrid();
                
                cmbRinsert.SelectedIndex = -1;
                txtRentInsert.Text = "";
                pictureBox1.Image = null;
                sqlcon.Close();
            }
            else
            {
                SqlCommand sqlcmd = new SqlCommand(@"DELETE FROM Room WHERE roomNo=@i");
                sqlcmd.Parameters.AddWithValue("@i", txtRIDinsert.Text);
                sqlcmd.Parameters.AddWithValue("@t", cmbRinsert.SelectedValue);
                sqlcmd.Parameters.AddWithValue("@rn", txtRentInsert.Text);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest Information Deleted SuccessFully !!", "Delete Message");
                LoadGrid();
                
                cmbRinsert.SelectedIndex = -1;
                txtRentInsert.Text = "";
                pictureBox1.Image = null;
                sqlcon.Close();
            }
        }

        private void dataGridViewR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewR.Rows[e.RowIndex].Cells[0].Value);
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select roomNo,typeId,rent,roomPicture from Room where roomNo=" + id + " ", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtRIDinsert.Text = dt.Rows[0][0].ToString();
                cmbRinsert.SelectedValue = dt.Rows[0][1].ToString();
                txtRentInsert.Text = dt.Rows[0][2].ToString();
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][3]);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;

            }
            sqlcon.Close();
        }

        private void btnPictureInsert_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
