using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.InteropServices;

namespace SIMY19CheckIn
{
    class Internet
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public bool isConnected = false;

        public Internet()
        {
            checkcon();
        }

        private void checkcon()
        {
            int desc;
            isConnected = InternetGetConnectedState(out desc, 0);
            
        }

    }
}
