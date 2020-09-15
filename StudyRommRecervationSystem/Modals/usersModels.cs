using StudyRommRecervationSystem.Controllors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRommRecervationSystem.Modals
{
    public class usersModels
    {
        public int uid { get; set; }
        public string UName { get; set; }
        public string Password { get; set; }

        usersController userc = new usersController();

        public void add()
        {
            userc.add(this); 
        }
        public void update()
        {
            userc.update(this);
        }
        public void delete() 
        {
            userc.delete(this);
        }
    }
}
