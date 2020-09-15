using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRommRecervationSystem
{
    public partial class BookingHistory : Form
    {
        public BookingHistory()
        {
            InitializeComponent();
        }

        private void studyRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SRoom sr = new SRoom();
            this.Hide();
            sr.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.Show();

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            this.Hide();
            book.Show();
        }

        private void bookingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingHistory bh = new BookingHistory();
            this.Hide();
            bh.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookingHistory_Load(object sender, EventArgs e)
        {
            string cnnString = "datasource=localhost; username=root;password=; database=studyroomrecervation;";
            MySqlConnection cnn = new MySqlConnection(cnnString);
            MySqlCommand cmd = new MySqlCommand("select * from booking", cnn);
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
        }

        private void studyRoomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SRoom sr = new SRoom();
            this.Hide();
            sr.Show();
        }

        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.Show();
        }

        private void bookingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Booking book = new Booking();
            this.Hide();
            book.Show();
        }

        private void bookingHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BookingHistory bh = new BookingHistory();
            this.Hide();
            bh.Show();
        }
    }
}
