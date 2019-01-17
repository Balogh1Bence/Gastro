using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gastro
{
    
    class us
    {
        List<currentuser> users;
        public us()
        {
            users = new List<currentuser>();
        }
        public List<currentuser> getUsers()
        {
            return users;
        }
        public string emailOfUser(string username)
        {
       
            string name = username;
            string mail = "";
            string con= "SERVER=\"localhost\";"
                + "DATABASE=\"felh\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
            MySqlConnection connect = new MySqlConnection(con);
            try
            {
                connect.Open();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Sikertelen adatbázismegnyitás.");
            }
         

            string query="SELECT email from deskusers where username like '"+name+"'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
               
                    mail = dr["email"].ToString();
                 
                }
                
           
                MessageBox.Show(mail);

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                

            }
            return mail;
        }

        public  int belep(string username, string password)
        {
            string uname = username;
            string pw = password;
            string RealPW = "";
            string con = "SERVER=\"localhost\";"
               + "DATABASE=\"felh\";"
               + "UID=\"root\";"
               + "PASSWORD=\"\";"
               + "PORT=\"3306\";";
            MySqlConnection connect = new MySqlConnection(con);
            try
            {
                connect.Open();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Sikertelen adatbázismegnyitás.");
            }
            string query = "SELECT password from deskusers where username='" + uname + "'";
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader dr = cmd.ExecuteReader();
            string remelemnemures=string.Empty;
            try
            {
                
                    while (dr.Read())
                    {

                        RealPW = dr["password"].ToString();
                       
                        remelemnemures = RealPW;

                    }



            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
               

            }
            /*
           hibakódok:
           0: minden jó
           1: nem jó jelszó
           2: nincs ilyen felhasználónév
            */
            
           
            if (RealPW == pw)
            {
                return 0;
            }
            if (string.IsNullOrEmpty(remelemnemures)) { return 2; }
            if (RealPW != pw)
            {
                return 1;
            }
           


            return 0;
        }

        public void beolvasDtUsers()
        {
            if (users.Count > 0)
                users.Clear();
            string connectionString =
                  "SERVER=\"localhost\";"
                + "DATABASE=\"felh\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Sikertelen adatbázismegnyitás.");
            }
            string query = "SELECT * FROM deskusers";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string datum = dr["utols"].ToString();
                    string[] darabok = datum.Split('.');
                    DateTime ido;
                    ido = DateTime.Now;

                    ido = new DateTime(
                        Convert.ToInt32(darabok[0]),
                        Convert.ToInt32(darabok[1]),
                        Convert.ToInt32(darabok[2])
                        );

                    currentuser k = new currentuser(
                        Convert.ToInt32(dr["azon"]),
                        dr["username"].ToString(),
                        dr["password"].ToString(),
                        dr["email"].ToString(),
                        ido,
                        dr["jog"].ToString());
                    users.Add(k);
                    
                }
                
                dr.Close();
                connection.Close();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw new Exception("Hibás SQL lekérdezés.");
            }
        }
        public currentuser getKaja(int azonosito)
        {
            foreach (currentuser k in users)
            {
                if (k.getAzon() == azonosito)
                { return k; }
            }
            return null;
        }


    }
}
