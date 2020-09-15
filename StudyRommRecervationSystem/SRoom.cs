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
    public partial class SRoom : Form
    {
        String name;
        int idd;
        public SRoom()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = RoomNumber.Text;
            if (name == null)
            {
                MessageBox.Show("Please Enter Room Name!");
            }
            studyroomsModal stm = new studyroomsModal();
            stm.Name = name;
            stm.add();
        }

        private void SRoom_Load(object sender, EventArgs e)
        {
            string cnnString = "datasource=localhost; username=root;password=; database=studyroomrecervation;";
            MySqlConnection cnn = new MySqlConnection(cnnString);
            MySqlCommand cmd = new MySqlCommand("select * from studyrooms", cnn);
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                name = row.Cells["Name"].Value.ToString();
                idd = Convert.ToInt32(row.Cells["id"].Value.ToString().Trim());

                RoomNumber.Text = name;

            }


        }

        private void update_Click(object sender, EventArgs e)
        {
            string name1 = RoomNumber.Text;
            if (name == null)
            {
                MessageBox.Show("Please Enter Room Name!");
            }
            studyroomsModal stm = new studyroomsModal();
            stm.id = idd;
            stm.Name = name1;
            stm.update();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string name1 = RoomNumber.Text;
            if (name1 == null)
            {
                MessageBox.Show("Please Select a row!");
            }
            studyroomsModal stm = new studyroomsModal();
            stm.id = idd;
            stm.delete();
        }
    }
}
