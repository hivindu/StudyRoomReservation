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
    public class studyroomsController : Conn
    {
       
        public void add(studyroomsModal std)
        {
            try
            {
                string Query = "insert into studyrooms(Name) values('" + std.Name + "');"; 
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
        public void update(studyroomsModal std)
        {
            try
            {
                string Query = "update studyrooms set Name='" + std.Name + "' where id='" + std.id + "';";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);
                MySqlDataReader MyReader2;
                cnn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                cnn.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete(studyroomsModal std) 
        {
            try
            {
                
                string Query = "delete from studyrooms where id='" + std.id + "';";
                
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
