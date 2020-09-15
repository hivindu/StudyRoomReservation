using MySql.Data.MySqlClient;
using StudyRommRecervationSystem.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRommRecervationSystem.Controllors
{
    public class bookingController :Conn
    {
        public void add(bookingModal bkm)
        {
            try
            {
                string Query = "insert into booking(StudentId,StrtTime,EndTime,studyRoomId) values('" + bkm.StdId + "','" + bkm.From + "','" + bkm.To + "','"+bkm.locaation+"');"; 
                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);
                MySqlDataReader MyReader2;
                cnn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                cnn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void update(bookingModal bkm)
        {
            try
            {
                string Query = "update booking set studyRoomId='" + bkm.locaation + "',StrtTime='" + bkm.From + "',EndTime ='"+bkm.To+ "'  where StudentId='" + bkm.StdId + "';";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);
                MySqlDataReader MyReader2;
                cnn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete(bookingModal bkm) 
        {
            try
            {
                
                string Query = "delete from booking where StudentId	='" + bkm.StdId + "';";
                
                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);
                MySqlDataReader MyReader2;
                cnn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
