using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastro
{
    class currentuser
    {
        private int azon;
        private string username;
        private string pw;
        private string email;
        private DateTime utolso;
        private string jog;
        public currentuser(int azon, string username, string pw, string email, DateTime utolso, string jog )
        {
            this.azon = azon;
            this.username = username;
            this.pw = pw;
            this.email = email;
            this.utolso = utolso;
            this.jog = jog;
        }
   
        public void setAzon(int azon) { this.azon = azon; }
        public void setUsername(string username){ this.username = username;}
        public void setPw (string pw) { this.pw = pw; }
        public void setEmail(string email) { this.email = email; }
        public void setUtolso(DateTime utolso) { this.utolso = utolso; }
        public void setJog(string jog) { this.jog = jog; }

        public int getAzon() { return azon; }
        public string getUsername() {return username; }
        public string getPw() { return pw; }
        public string getEmail() { return email; }
        public DateTime getUtolso() { return utolso; }
        public string getJog() { return jog; }

   
    }
}
