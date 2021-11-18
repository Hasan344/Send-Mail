using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sendMail
{
   public class History
    {
        public int id;
        public string to;
        public string from;
        public  string subject;
        public string message;
        public DateTime time;

        public static int idNo = 1;
        public History(string to, string from, string subject, string message)
        {
            this.id = idNo++;   
            this.to = to;
            this.from = from;
            this.subject = subject;
            this.message = message;
            this.time = DateTime.Now;
        }
    }
}
