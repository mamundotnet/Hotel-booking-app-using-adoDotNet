using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest fg = new Guest();
            fg.Show();

        }

        private void entryEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room_Type ft = new Room_Type();
            ft.Show();
            
        }

        private void entryEditDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Room fr = new Room();
            fr.Show();
            
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking fb = new Booking();
            fb.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void montlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyReport monthlyReport = new MonthlyReport();
            monthlyReport.Show();
        }

        private void typeWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomReport rt = new RoomReport();
            rt.Show();
        }
    }
}
