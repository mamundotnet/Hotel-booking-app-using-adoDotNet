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
    public partial class MonthlyReport : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=F:\PROJECTADO.NET\HOTELBOOKING\HOTELBOOKING\BOOKINGDB.MDF;Integrated Security=True");
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ReportDocument rptCrystal = new ReportDocument();
            SqlDataAdapter sda = new SqlDataAdapter("select guestName, phone, typeName, rent, spentDays, (spentDays * rent) from Booking join Room  on Room.roomNo = Booking.roomNo join Guests on Guests.guestId = Booking.guestId\r\njoin RoomType  on RoomType.typeId = room.typeId", sqlcon);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Booking");
            rptCrystal.Load(@"F:\ProjectAlter\HotelBooking\HotelBooking.rpt");
            rptCrystal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptCrystal;
        }
    }
}
