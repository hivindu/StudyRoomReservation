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
    public partial class User : Form
    {
        public User()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateData();

            usersModels um = new usersModels();
            um.uid = Convert.ToInt32(userId.Text);
            um.UName = UserName.Text;
            um.Password = textBox3.Text;
            um.add();
        }

        public void ValidateData()
        {
            if (userId.Text == null && UserName.Text == null && textBox3.Text == null)
            {
                MessageBox.Show("Please Fill all fields");
            }
            if(userId.Text == null)
            {
                MessageBox.Show("User Id Is required");
            }
            if (UserName.Text == null)
            {
                MessageBox.Show("User Name Is required");
            }
            if (textBox3.Text == null)
            {
                MessageBox.Show("Password Is required");
            }
            
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

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            string cnnString = "datasource=localhost; username=root;password=; database=studyroomrecervation;";
            MySqlConnection cnn = new MySqlConnection(cnnString);
            MySqlCommand cmd = new MySqlCommand("select * from users", cnn);
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValidateData();

            usersModels um = new usersModels();
            um.uid = Convert.ToInt32(userId.Text);
            um.UName = UserName.Text;
            um.Password = textBox3.Text;
            um.update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ValidateData();

            usersModels um = new usersModels();
            um.uid = Convert.ToInt32(userId.Text);
            um.UName = UserName.Text;
            um.Password = textBox3.Text;
            um.delete();
        }
    }
}
