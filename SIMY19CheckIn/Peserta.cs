using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SIMY19CheckIn
{
    public class Peserta
    {
        Connection conn = new Connection();
        public String pesertaID { get; set; }
        public String nama { get; set; }
        public String gender { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String jenisPeserta { get; set; }
        public String asalNegara { get; set; }
        public String university { get; set; }
        public String paket { get; set; }
        public String panel1 { get; set; }
        public String panel2 { get; set; }

        public Peserta()
        {

        }

        public void checkin(Peserta p, Session s)
        {
            if (conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            SqlCommand cmd = new SqlCommand("UPDATE checkin SET Status ='Checkedin',checkin='"+ DateTime.Now.ToString("HH:mm:ss") + "' WHERE pesertaid='"+p.pesertaID+"' and sessionid='"+s.sessionID+"'", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
            Console.WriteLine();
        }
    }


}
