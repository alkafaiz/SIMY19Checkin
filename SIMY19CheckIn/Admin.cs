using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SIMY19CheckIn
{
    class Admin
    {
        Connection conn = new Connection();
        public Admin()
        {

        }

        public List<Session> getSession()
        {
            List<Session> sessions = new List<Session>();
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Session", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Session s = new Session();
                s.sessionID = dr[0].ToString();
                s.name = dr[1].ToString();
                s.location = dr[2].ToString();
                s.date = Convert.ToDateTime(dr[3].ToString());
                s.startTime = Convert.ToDateTime(dr[4].ToString());
                if (dr[5].ToString() != "") { s.endTime = Convert.ToDateTime(dr[5].ToString()); }                
                s.status = dr[6].ToString();
                sessions.Add(s);                
            }
            dr.Close();
            conn.getConnected.Close();
            return sessions;
        }

        public void createClientInstance(String key, String pw, String sesID, String Status)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ClientServer (ClientKey, Password, SessionID, Status) 
                VALUES('" + key +
                    "', '" + pw +
                    "','" + sesID +
                    "','" + Status +                    
                    "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public void DeleteClientInstance(String key)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"Delete From ClientServer where ClientKey='" +key+"' ", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public void updateStatusClient(String stat, String key)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ClientServer SET Status ='" + stat +
                "' WHERE (ClientKey='" + key + "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public bool authorizeCLient(String key, String pw)
        {
            bool tr = false;
            //Console.WriteLine(key+pw);
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select ClientKey,Password from ClientServer Where ClientKey = '" + key + "' and Password ='" + pw + "' ", conn.getConnected);
            //SqlDataAdapter sda = new SqlDataAdapter("Select clientkey,password from clientserver where clientkey='" +key+"' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Console.WriteLine(dt.Rows.Count);
            if (dt.Rows.Count == 1)
            {
                tr = true;
                
            }            
            conn.getConnected.Close();
            return tr;
        }
        
        public bool isClientActive(String clientkey)
        {
            bool stat = false;
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select status from ClientServer Where ClientKey = '" + clientkey + "' ", conn.getConnected);            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0].ToString() == "Active") { stat = true; }                
            }
            conn.getConnected.Close();
            return stat;
        }

        public ClientInstance getClientInstance(String clientkey)
        {
            ClientInstance cl = new ClientInstance();
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select * from ClientServer Where ClientKey = '" + clientkey + "' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                cl.ClientKey = dt.Rows[0][0].ToString();
                cl.Password = dt.Rows[0][1].ToString();
                cl.SessionID = dt.Rows[0][2].ToString();
                cl.Status = dt.Rows[0][3].ToString();
            }
            conn.getConnected.Close();
            return cl;
        }

        public Session getSession(String Clientkey)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("SELECT session.sessionID, name, location,session.date, starttime,endtime,session.status FROM Session inner join clientserver on session.sessionID = clientserver.sessionID WHERE clientserver.clientkey = '"+ Clientkey + "' ", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            Session s = new Session();
            while (dr.Read())
            {                
                s.sessionID = dr[0].ToString();
                s.name = dr[1].ToString();
                s.location = dr[2].ToString();
                s.date = Convert.ToDateTime(dr[3].ToString());
                s.startTime = Convert.ToDateTime(dr[4].ToString());
                if (dr[5].ToString() != "") { s.endTime = Convert.ToDateTime(dr[5].ToString()); }
                s.status = dr[6].ToString();                
            }
            dr.Close();
            conn.getConnected.Close();
            return s;
        }

        public String getIDpesByEmail(String email)
        {
            String id = "";
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select pesertaid from Peserta Where email = '" + email + "' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Console.WriteLine(dt.Rows.Count);
            if (dt.Rows.Count == 1)
            {
                id += dt.Rows[0][0].ToString();
            }
            conn.getConnected.Close();
            return id;
        }

        public bool Checkin(String email, String sesID)
        {
            bool eligible = false;
            String id = getIDpesByEmail(email);
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select * from checkin Where pesertaid = '" + id + "' and sessionid='"+sesID+"' and status='Expected' ", conn.getConnected);            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Console.WriteLine(dt.Rows.Count);
            if (dt.Rows.Count == 1)
            {
                eligible = true;

            }
            conn.getConnected.Close();
            return eligible;
        }

        public String CheckStatusCheckin(String email, String sesID)
        {
            String status = "";
            String id = getIDpesByEmail(email);
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select status from checkin Where pesertaid = '" + id + "' and sessionid='" + sesID + "' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Console.WriteLine(dt.Rows.Count);
            if (dt.Rows.Count == 1)
            {
                status += dt.Rows[0][0].ToString();

            }
            conn.getConnected.Close();
            return status;
        }

        public Peserta getPeserta(String pesertaID)
        {
            Peserta p = new Peserta();
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlCommand cmd = new SqlCommand("SELECT * from Peserta where pesertaID= '"+pesertaID+"' ", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();            
            while (dr.Read())
            {
                p.pesertaID = dr[0].ToString();
                p.nama = dr[1].ToString();
                p.gender = dr[2].ToString();
                p.email = dr[3].ToString();
                p.phone = dr[4].ToString();
                p.jenisPeserta = dr[5].ToString(); 
                p.asalNegara = dr[6].ToString();
                p.university = dr[7].ToString();
                p.paket = dr[8].ToString();
                p.panel1 = dr[9].ToString();
                p.panel2 = dr[10].ToString();
            }
            dr.Close();
            conn.getConnected.Close();
            return p;
        }

        public String getPesertaID(String email)
        {
            String ID = "";
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("SELECT PesertaID from Peserta where email= '" + email + "' ", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID = dr[0].ToString();           
            }
            dr.Close();
            conn.getConnected.Close();
            return ID;
        }

        public void updateStatusSession(String stat, String ID)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Session SET status ='" + stat +
                "' WHERE (sessionID='" + ID + "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }
        public void DeleteSession(String ID)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"Delete From Session where sessionID='" + ID + "' ", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }

        public void createSession(Session s)
        {
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Session (sessionID, name, location, date,startTime,endTime,status) 
                VALUES('" + s.sessionID +
                    "', '" + s.name +
                    "','" + s.location +
                    "','" + s.date +
                    "','" + s.startTime +
                    "','" + s.endTime +
                    "','" + s.status +
                    "')", conn.getConnected);
            cmd.ExecuteNonQuery();
            conn.getConnected.Close();
        }
        public List<Peserta> getPesertaAssign(String sessionID)
        {
            List<Peserta> peser = new List<Peserta>();
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand("select * from peserta where not exists (select sessionid from checkin where checkin.pesertaid=peserta.pesertaid and sessionid='"+sessionID+" ') ", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Peserta p = new Peserta();
                p.pesertaID = dr[0].ToString();
                p.nama = dr[1].ToString();
                p.gender = dr[2].ToString();
                p.email = dr[3].ToString();
                p.phone = dr[4].ToString();
                p.jenisPeserta = dr[5].ToString();
                p.asalNegara = dr[6].ToString();
                p.university = dr[7].ToString();
                p.paket = dr[8].ToString();
                p.panel1 = dr[9].ToString();
                p.panel2 = dr[10].ToString();
                peser.Add(p);
            }
            dr.Close();
            conn.getConnected.Close();
            return peser;
        }

        public void loadSessionCheckin(System.Windows.Forms.DataGridView dgv)
        {
            List<Session> ses = getSession();
            //conn.getConnected.Open();            
            //SqlCommand cmd = new SqlCommand(@"select sessionid, name from session", conn.getConnected);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Session s = new Session();             
            //    s.sessionID = dr[0].ToString();
            //    s.name = dr[1].ToString();
            //    ses.Add(s);
                
            //}
            //dr.Close();
            //conn.getConnected.Close();
            Console.WriteLine(ses.Count);
            for (int i = 0; i < ses.Count; i++)
            {
                List<int> data = getSessionCheckin(ses[i].sessionID);     
                dgv.Rows.Add(ses[i].sessionID, ses[i].name,data[0],data[1]);
            }
        }

        public void AssignPeserta(String SessionID, List<String> pesertaID, String Status)
        {
            conn.getConnected.Open();
            foreach (String id in pesertaID)
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Checkin (sessionID, pesertaID, Status) 
                VALUES('" + SessionID +
                    "', '" + id +                  
                    "','" + Status +
                    "')", conn.getConnected);
                cmd.ExecuteNonQuery();
            }
            
            conn.getConnected.Close();
        }

        public List<int> getSessionCheckin(String sessionID)
        {
            List<int> n = new List<int>();
            conn.getConnected.Open();
            //foreach (Session s in ses)
            //{

            //}
            SqlCommand cmd = new SqlCommand(@"select count(case checkin.status when 'Expected' then 1 else null end), count(case checkin.status when 'Checkedin' then 1 else null end) from checkin where sessionid='"+sessionID+"'", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int expected = Convert.ToInt32(dr[0].ToString());
                int checkin = Convert.ToInt32(dr[1].ToString());
                n.Add(expected);
                n.Add(checkin);
            }
            dr.Close();
            conn.getConnected.Close();
            return n;
        }

        public String getSessionStatus(String sessionID)
        {
            String st = "";
            conn.getConnected.Open();           
            SqlCommand cmd = new SqlCommand(@"select status from session where sessionid='"+sessionID+"' ", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                st = dr[0].ToString();
            }
            dr.Close();
            conn.getConnected.Close();
            return st;
        }

        public String getPesertaCheckinStatus(String sessionID,String pesertaid)
        {
            String st = "";
            conn.getConnected.Open();
            SqlCommand cmd = new SqlCommand(@"select status from checkin where pesertaid='"+pesertaid+"' and sessionid='"+sessionID+"'", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                st = dr[0].ToString();
            }
            dr.Close();
            conn.getConnected.Close();
            return st;
        }

        public String getPesertaTimestamp(String sessionID, String pesertaid)
        {
            String st = "";
            conn.getConnected.Open();            
            SqlDataAdapter sda = new SqlDataAdapter(@"select checkin from checkin where pesertaid='" + pesertaid + "' and sessionid='" + sessionID + "'", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);            
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    st += dt.Rows[i][0].ToString();
                }
            }
            catch (Exception)
            {              
            }            
            conn.getConnected.Close();
            return st;
        }



        public void loadPesertaCheckin(System.Windows.Forms.DataGridView dgv, String sessionID)
        {
            List<String> pesertaids = new List<string>();
            if (conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            SqlCommand cmd = new SqlCommand(@"select pesertaid from checkin where sessionid='"+sessionID+"'", conn.getConnected);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pesertaids.Add(dr[0].ToString());                
            }
            dr.Close();
            conn.getConnected.Close();
            if (dgv.RowCount > 0) { dgv.Rows.Clear(); }
            for (int i = 0; i < pesertaids.Count; i++)
            {
                Peserta p = getPeserta(pesertaids[i]);
                String status = getPesertaCheckinStatus(sessionID, p.pesertaID);
                dgv.Rows.Add(getPesertaTimestamp(sessionID, p.pesertaID), status,  p.nama, p.email, p.jenisPeserta,p.asalNegara,p.university,p.paket);
                int n = dgv.RowCount;
                n -= 1;
                dgv.Rows[n].Cells[1].Style.ForeColor = System.Drawing.Color.White;
                if (status == "Checkedin")
                {
                    dgv.Rows[n].Cells[1].Style.BackColor = System.Drawing.Color.Green;                    
                }
                else { dgv.Rows[n].Cells[1].Style.BackColor = System.Drawing.Color.Navy; }
                
                
            }
        }

        public List<Peserta> loadPesertaCheckin2(String sessionID)
        {
            List<Peserta> pesertas = new List<Peserta>();
            if (conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter(@"select pesertaid from checkin where sessionid='" + sessionID + "'", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pesertas.Add(getPeserta(dt.Rows[i][0].ToString()));
            }            
            conn.getConnected.Close();
            return pesertas;            
        }

        public DataTable loadPesertaCheckin3(String sessionID)
        {
            //List<Peserta> pesertas = new List<Peserta>();
            if (conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter(@"select pesertaid from checkin where sessionid='" + sessionID + "'", conn.getConnected);
            DataTable dat = new DataTable();
            sda.Fill(dat);
            DataTable dt = new DataTable();
            dt.Columns.Add("Timestamp");
            dt.Columns.Add("Status");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Email");
            dt.Columns.Add("Jenis Peserta");
            dt.Columns.Add("Asal Negara");
            dt.Columns.Add("University");
            dt.Columns.Add("Paket");
            for (int i = 0; i < dat.Rows.Count; i++)
            {
                Peserta p= getPeserta(dat.Rows[i][0].ToString());
                DataRow row = dt.NewRow();
                row["Timestamp"] = getPesertaTimestamp(sessionID, p.pesertaID);
                row["Status"] = getPesertaCheckinStatus(sessionID, p.pesertaID);
                row["Nama"] = p.nama;
                row["Email"] = p.email;
                row["Jenis Peserta"] = p.jenisPeserta;
                row["Asal Negara"] = p.asalNegara;
                row["University"] = p.university;
                row["Paket"] = p.paket;
                dt.Rows.Add(row);
            }
            conn.getConnected.Close();
            return dt;
        }

        public DataTable loadPesertaCheckin4(String sessionID)
        {
            //List<Peserta> pesertas = new List<Peserta>();
            if (conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter(@"select checkin.checkin,checkin.status,peserta.nama,peserta.email,peserta.jenispeserta,peserta.asalnegara,peserta.university,peserta.paket from checkin join peserta on checkin.pesertaid=peserta.pesertaid where checkin.sessionid='"+sessionID+"'", conn.getConnected);
            DataTable dat = new DataTable();
            sda.Fill(dat);
            
            conn.getConnected.Close();
            return dat;
        }

        public List<Peserta> SearchPesertaCheckin(String sessionID, String keyword)
        {
            List<Peserta> pesertas = new List<Peserta>();
            if (conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter(@"select checkin.pesertaid from checkin join peserta on checkin.pesertaid=peserta.pesertaid where checkin.sessionid='" + sessionID + "' and ( peserta.nama like '%" + keyword+ "%' or peserta.email like '%" + keyword + "%' or peserta.university like '%" + keyword + "%' ) ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pesertas.Add(getPeserta(dt.Rows[i][0].ToString()));
            }
            conn.getConnected.Close();
            return pesertas;
        }

        public DataTable SearchPesertaCheckin2(String sessionID, String keyword)
        {            
            if (conn.getConnected.State == ConnectionState.Closed) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter(@"select checkin.checkin,checkin.status,peserta.nama,peserta.email,peserta.jenispeserta,peserta.asalnegara,peserta.university,peserta.paket from checkin join peserta on checkin.pesertaid=peserta.pesertaid where checkin.sessionid='" + sessionID + "' and ( peserta.nama like '%" + keyword + "%' or peserta.email like '%" + keyword + "%' or peserta.university like '%" + keyword + "%' ) ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);            
            conn.getConnected.Close();
            return dt;
        }


    }
}
