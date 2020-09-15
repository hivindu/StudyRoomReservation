using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudyRommRecervationSystem
{
    public class Conn
    {
        public MySqlConnection cnn;
        public String cnnString;
        public Conn() 
        {
            cnnString = "datasource=localhost; username=root;password=; database=studyroomrecervation;";
            cnn = new MySqlConnection(cnnString);
        }
    }
}
