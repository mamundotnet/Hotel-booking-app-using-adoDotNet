using CrystalDecisions.CrystalReports.Engine;
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
    public partial class RoomReport : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=Data Source=DESKTOP-OARO31P;Initial Catalog=HotelBooking;Integrated Security=True");
        public RoomReport()
        {
            InitializeComponent();
        }

        private void RoomReport_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
        private void LoadCombo()
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM RoomType", sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            comboRoom.DataSource = ds.Tables[0];
            comboRoom.DisplayMember = "typeName";
            comboRoom.ValueMember = "typeId";
            sqlcon.Close();
        }

        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            ReportDocument rptCrystal = new ReportDocument();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Booking JOIN Room ON Room.roomNo=Booking.roomNo JOIN RoomType ON RoomType.typeId=Room.typeId WHERE bookingId =" + comboRoom.SelectedValue + "", sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Booking");
            rptCrystal.Load(@"F:\ProjectADO.NET\HotelBooking\HotelBooking\BookingReport.rpt");
            rptCrystal.SetDataSource(ds);
            RptRoom.ReportSource = rptCrystal;

        }
    }
}
