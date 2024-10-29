using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class Booking : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelBooking;Integrated Security=True");
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadRoomCombo();
            LoadGuestCombo();
            
        }
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select bookingId, guestName,phone,typeName, rent,spentDays,(spentDays*rent) As Total_Rent from Booking join Room  on Room.roomNo=Booking.roomNo join Guests on Guests.guestId=Booking.guestId join RoomType  on RoomType.typeId=room.typeId", sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridViewB.DataSource = dt;
            sqlcon.Close();
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(bookingId),0)+1 FROM Booking", sqlcon))
            {
                
                sqlcon.Open();
                int newId = (int)cmd.ExecuteScalar();
                txtBID.Text = newId.ToString();
                sqlcon.Close();
            }
            
        }
        private void LoadGuestCombo()
        {
            sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select guestId,guestName,phone,NID,birthday from Guests", sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            DataRow newRow = ds.Tables[0].NewRow();
            newRow[0] = "-1";
            newRow[1] = "---Select Guest---";
            ds.Tables[0].Rows.InsertAt(newRow, 0);
            cmbGb.DataSource = ds.Tables[0];
            cmbGb.DisplayMember = "guestName";
            cmbGb.ValueMember = "guestId";

            sqlcon.Close();

        }
        private void LoadRoomCombo()
        {
            sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select roomNo,typeId,rent,roomPicture from Room", sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            DataRow newRow = ds.Tables[0].NewRow();
            newRow[0] = "0000";
            newRow[1] =0;
            ds.Tables[0].Rows.InsertAt(newRow, 0);
            cmbRb.DataSource = ds.Tables[0];
            cmbRb.DisplayMember = "roomNo";
            cmbRb.ValueMember = "roomNo";

            sqlcon.Close();

        }

        private void btnGInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "INSERT INTO Booking (bookingID,guestId,roomNo,spentDays) VALUES (" + txtBID.Text + ",'" + cmbGb.SelectedValue + "','" + cmbRb.SelectedValue + "','" + txtSD.Text+ "')";
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Information Inserted SuccessFully !!", "Insert Message");
                LoadGrid();
                
                
                cmbGb.SelectedIndex =-1;
                cmbRb.SelectedIndex = -1;
                txtSD.Text = "";
                sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Valid Data!!\n" + ex.Message);
                sqlcon.Close();
            }
        }

        private void btnBUpdate_Click(object sender, EventArgs e)
        {
        //    try
        //    {
        //        sqlcon.Open();
        //        SqlCommand sqlcmd = new SqlCommand();
        //        sqlcmd.Connection = sqlcon;
        //        sqlcmd.CommandText = "UPDATE Booking SET bookingID=" + txtBID.Text + ",guestId='" + cmbGb.SelectedValue + "',roomNo='" + cmbRb.SelectedValue + "',spentDays='" + txtSp.Text + "' WHERE bookingId= " + txtBID.Text + "";
        //        sqlcmd.ExecuteNonQuery();
        //        MessageBox.Show("Information Updated SuccessFully !!", "Update Message");
        //        LoadGrid();
        //        txtBID.Text = "";
        //        cmbGb.SelectedIndex = -1;
        //        cmbRb.SelectedIndex = -1;
        //        txtSp.Text = "";
                
        //        sqlcon.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Insert Valid Data!!\n" + ex.Message);
        //        sqlcon.Close();
        //    }
        }

        private void btnBclear_Click(object sender, EventArgs e)
        {

            txtBID.Clear();
            cmbGb.SelectedIndex = -1;
            cmbRb.SelectedIndex = -1;
            txtSp.Clear();

        }

        private void dataGridViewB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewB.Rows[e.RowIndex].Cells[0].Value);
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select bookingID,guestId,roomNo,spentDays from Booking where bookingID=" + id + " ", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtBID.Text = dt.Rows[0][0].ToString();
                cmbGb.SelectedValue = dt.Rows[0][1].ToString();
                cmbRb.SelectedValue = dt.Rows[0][2].ToString();
                txtSD.Text = dt.Rows[0][3].ToString();


            }
            sqlcon.Close();
        }

        private void btnBdel_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = @"DELETE FROM Booking WHERE bookingId=@i";
            sqlcmd.Parameters.AddWithValue("@i", txtBID.Text);
            sqlcmd.Parameters.AddWithValue("@t", cmbGb.SelectedValue);
            sqlcmd.Parameters.AddWithValue("@r", cmbRb.SelectedValue);
            sqlcmd.Parameters.AddWithValue("@s", txtSD.Text);

            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Guest Information Deleted SuccessFully !!", "Delete Message");
            LoadGrid();
            
            cmbGb.SelectedIndex= -1;
            cmbRb.SelectedIndex = -1;
            txtSD.Text= "";
            sqlcon.Close();
        }
    }
}
