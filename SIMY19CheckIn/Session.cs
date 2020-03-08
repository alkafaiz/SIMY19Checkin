using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMY19CheckIn
{    
    public class Session
    {
        public String sessionID { get; set; }
        public String name { get; set; }
        public String location { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public String status { get; set; }

    }
}
