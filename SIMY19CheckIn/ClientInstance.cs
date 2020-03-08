using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMY19CheckIn
{
    public class ClientInstance
    {
        public String ClientKey { get; set; }
        public String Password { get; set; }
        public String SessionID { get; set; }
        public String Status { get; set; }

        public ClientInstance()
        {

        }        
    }
}
