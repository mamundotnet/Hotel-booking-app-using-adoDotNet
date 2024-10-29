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
    public partial class Room_Type : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=F:\PROJECTADO.NET\HOTELBOOKING\HOTELBOOKING\BOOKINGDB.MDF;Integrated Security=True");
        public Room_Type()
        {
            InitializeComponent();
        }

        private void Room_Type_Load(object sender, EventArgs e)
        {
            LoadGrid(); 
        }
        private void LoadGrid()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from RoomType", sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridViewT.DataSource = dt;
            sqlcon.Close();
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(typeId),0)+1 FROM RoomType", sqlcon))
            {
                sqlcon.Open();
                int newId = (int)cmd.ExecuteScalar();
                txtTidinsert.Text = newId.ToString();
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
                sqlcmd.CommandText = "INSERT INTO RoomType (typeId,typeName) VALUES (" + txtTidinsert.Text + ",'" + txtTinsert.Text + "')";
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Information Inserted SuccessFully !!", "Insert Message");
                LoadGrid();
                
                txtTinsert.Text = "";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Valid Data!!\n" + ex.Message);
                sqlcon.Close();
            }
        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "UPDATE RoomType SET typeName='" + txtTupdate.Text + "'WHERE typeId="+ txtTIDupdate.Text+"";
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Information Updated SuccessFully !!", "Insert Message");
                LoadGrid();
                txtTIDupdate.Text = "";
                txtTupdate.Text = "";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data!!\n" + ex.Message);
                sqlcon.Close();
            }
        }

        private void btnTdelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "DELETE FROM RoomType WHERE typeId=" + txtTIDupdate.Text + "";
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Information Deleted SuccessFully !!", "Insert Message");
                LoadGrid();
                txtTIDupdate.Text = "";
                txtTupdate.Text = "";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data!!\n" + ex.Message);
                sqlcon.Close();
            }
        }

        private void dataGridViewT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewT.Rows[e.RowIndex].Cells[0].Value);
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select typeId,typeName from RoomType where typeId=" + id + " ", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtTIDupdate.Text = dt.Rows[0][0].ToString();
                txtTupdate.Text = dt.Rows[0][1].ToString();
            }
            sqlcon.Close();
        }
    }
}
