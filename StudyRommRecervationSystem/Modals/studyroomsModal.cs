using StudyRommRecervationSystem.Controllors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRommRecervationSystem.Modals
{
    public class studyroomsModal
    { 
        public string Name { get; set; }
        public int id { get; set; }

        studyroomsController src = new studyroomsController();

        public void add()
        {
            src.add(this);
        }
        public void update()
        {
            src.update(this);
        }
        public void delete() 
        {
            src.delete(this);
        }
    }
}
