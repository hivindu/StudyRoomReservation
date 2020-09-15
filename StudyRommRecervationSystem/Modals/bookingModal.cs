using StudyRommRecervationSystem.Controllors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRommRecervationSystem.Modals
{
    public class bookingModal
    {
        public int StdId { get; set; }
        public int locaation { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        bookingController bkc = new bookingController();


        public void add()
        {
            bkc.add(this);
        }
        public void update()
        {
            bkc.update(this);
        }
        public void delete() 
        {
            bkc.delete(this);
        }
    }
}
