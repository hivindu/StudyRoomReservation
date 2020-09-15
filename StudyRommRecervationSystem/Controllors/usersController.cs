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
    public class usersController :Conn
    {
        public void add(usersModels user)
        {
            try
            {
                string Query = "insert into users(UserId,UserName,Password) values('" + user.uid + "','" + user.UName + "','" + user.Password + "');";              
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

        public void update(usersModels user)
        {
            try
            {
                string Query = "update users set UserName='" + user.UName + "',Password='" + user.UName + "' where UserId='" + user.uid + "';";

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

        public void delete(usersModels user)
        {
            try
            {
                
                string Query = "delete from users where UserId='" + user.uid + "';";
                ;
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
