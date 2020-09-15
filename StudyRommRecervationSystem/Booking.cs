using MySql.Data.MySqlClient;
using StudyRommRecervationSystem.Modals;
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
    public partial class Booking : Form
    {
        int id;
        string start;
        string over;
        int roomid;

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            ComboData();
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

        public void ComboData()
        {
            DataRow dr;

            string cnnString = "datasource=localhost; username=root;password=; database=studyroomrecervation;";
            MySqlConnection cnn = new MySqlConnection(cnnString);
            cnn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from studyrooms", cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Study Room--" };
            dt.Rows.InsertAt(dr, 0);

            comboBox1.ValueMember = "id";

            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = dt;

            cnn.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
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

        private void addBooking_Click(object sender, EventArgs e)
        {
            string from = textBox2.Text.ToString();
            string to = textBox3.Text.ToString();
            int Id = Convert.ToInt32(textBox1.Text.ToString());
            int index = comboBox1.SelectedIndex;

            bookingModal bm = new bookingModal();
            bm.StdId = Id;
            bm.From = from;
            bm.To = to;
            bm.locaation = index;
            bm.add();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string from = textBox2.Text.ToString();
            string to = textBox3.Text.ToString();
            int Id = Convert.ToInt32(textBox1.Text.ToString());
            int index = comboBox1.SelectedIndex;

            bookingModal bm = new bookingModal();
            bm.StdId = Id;
            bm.From = from;
            bm.To = to;
            bm.locaation = index;
            bm.update();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string from = textBox2.Text.ToString();
            string to = textBox3.Text.ToString();
            int Id = Convert.ToInt32(textBox1.Text.ToString());
            int index = comboBox1.SelectedIndex;

            bookingModal bm = new bookingModal();
            bm.StdId = Id;
            
            bm.delete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                textBox2.Text = row.Cells["StrtTime"].Value.ToString();
                textBox1.Text = row.Cells["StudentId"].Value.ToString();
                textBox3.Text = row.Cells["EndTime"].Value.ToString();
                int index = comboBox1.FindString(row.Cells["studyRoomId"].Value.ToString());
                comboBox1.SelectedIndex = index;
            }
        }
    }
}
