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
    class termekekVezerlo
    {
        List<Termekek> termekek = new List<Termekek>();
      
        
        int kod;
        string nev;
        int ar;
        int keszl;
        string mert;
        int katkod;
        int Tvonkod;
        DateTime Tszavido;
        bool Tegalizalte;


        public List<Termekek> termekToltes()
        {
            string con = "SERVER=\"localhost\";"
                + "DATABASE=\"gastro\";"
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


            string query = "SELECT * from termekek";
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataReader dr = cmd.ExecuteReader();
            try
            {
               
                while (dr.Read())
                {
                   
                    kod = Convert.ToInt32(dr["Tkod"]);
                    nev = dr["Tnev"].ToString();
                    ar = Convert.ToInt32(dr["Tar"]);
                    keszl = Convert.ToInt32(dr["Tkeszl"]);
                    mert = dr["Tmert"].ToString();
                    katkod = Convert.ToInt32(dr["Tkatkod"]);
                    termekek.Add(new Termekek(kod,nev,ar,keszl,mert,katkod,0,new DateTime(0,0,0),false));

                }
                
                

                MessageBox.Show("test");

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);


            }

          


            return termekek;
            
        }



        
    }
}
