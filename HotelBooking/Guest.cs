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
    public partial class Guest : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=F:\PROJECTADO.NET\HOTELBOOKING\HOTELBOOKING\BOOKINGDB.MDF;Integrated Security=True");
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Guests", sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridViewG.DataSource = dt;
            sqlcon.Close();
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(guestId),0)+1 FROM Guests", sqlcon))
            {
                sqlcon.Open();
                int newId = (int)cmd.ExecuteScalar();
                txtGIDinsert.Text = newId.ToString();
                sqlcon.Close();
            }
        }

        private void btnGInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "INSERT INTO Guests (guestId,guestName,phone,NID,birthday) VALUES (" + txtGIDinsert.Text + ",'" + txtGNameinsert.Text + "','"+ txtGPhoneinsert.Text + "','"+ txtGNIDinsert.Text + "','"+ dateTimePickerInsert.Value.Date + "')";
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest Information Inserted SuccessFully !!", "Insert Message");
                LoadGrid();
                
                txtGNameinsert.Text = "";
                txtGPhoneinsert.Text = "";
                txtGNIDinsert.Text = "";
                dateTimePickerInsert.Value = DateTime.Today;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Valid Data!!\n" + ex.Message);
                sqlcon.Close();
            }
        }


        private void btnGUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "UPDATE Guests SET guestName='" + txtGNameupdate.Text + "',phone='" + txtGPhoneupdate.Text + "',NID='" + txtGNIDupdate.Text + "',birthday='" + dateTimePickerUpdate.Value.Date + "'WHERE guestId="+ txtGIDupdate.Text+"";
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest Information Updated SuccessFully !!", "Update Message");
                LoadGrid();
                
                txtGNameupdate.Text = "";
                txtGPhoneupdate.Text = "";
                txtGNIDupdate.Text = "";
                dateTimePickerUpdate.Value = DateTime.Today;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Valid Data!!\n" + ex.Message);
                sqlcon.Close();
            }
        }

        private void btnGdelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "DELETE FROM Guests WHERE guestId=" + txtGIDupdate.Text + "";
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Guest info Delete SuccessFull !!", "Delete Message");
                LoadGrid();
                
                txtGNameupdate.Text = "";
                txtGPhoneupdate.Text = "";
                txtGNIDupdate.Text = "";
                dateTimePickerUpdate.Value = DateTime.Today;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Valid Data!!\n" + ex.Message);
                sqlcon.Close();
            }

        }

        private void dataGridViewG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewG.Rows[e.RowIndex].Cells[0].Value);
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select guestId,guestName,phone,NID,birthday from Guests where guestId=" + id + " ", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtGIDupdate.Text = dt.Rows[0][0].ToString();
                txtGNameupdate.Text = dt.Rows[0][1].ToString();
                txtGPhoneupdate.Text= dt.Rows[0][2].ToString();
                txtGNIDupdate.Text= dt.Rows[0][3].ToString();
                dateTimePickerUpdate.Text= dt.Rows[0][4].ToString();
            }
            sqlcon.Close();

        }
    }
}

