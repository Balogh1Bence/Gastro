using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gastro
{
    public partial class mod : Form
    {

        private Termekek k;
        TextBox Tvonkod = new TextBox();
        TextBox Tszavido = new TextBox();
        CheckBox Tegalizalte = new CheckBox();
        public mod(Termekek k)
        {

            this.k = k;
            
            InitializeComponent();
            int x = Tkatkod.Location.X;
            int y = Tkatkod.Location.Y;
            

            Tvonkod.Location = new Point(x,y+20);
            Tszavido.Location = new Point(x,y+40);
            Tegalizalte.Location = new Point(x, y+60);

            Controls.Add(Tvonkod);
            Controls.Add(Tszavido);
            Controls.Add(Tegalizalte);

            ok.DialogResult = DialogResult.OK;
            
            Tkod.Text = k.getTkod().ToString();
            Tnev.Text = k.getTnev();
            Tar.Text = k.getTar().ToString();
            Tkeszl.Text = k.getTkeszl().ToString();
            Tmert.Text = k.getTmert();
            Tkatkod.Text = k.getTkeszl().ToString();
            Tvonkod.Text = k.getTvonkod().ToString();
            Tszavido.Text = k.getTszavido().ToShortDateString().ToString();
            bool eg = false;
          
            eg = k.getTegalizalt();
            if(eg==true)
            { Tegalizalte.Checked = true; }
            else Tegalizalte.Checked = false;

        }

        private void mod_Load(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {

            k.setTkod(Convert.ToInt32(Tkod.Text));
            k.setTnev(Tnev.Text);
            k.setTar((Convert.ToInt32(Tar.Text)));
            k.setTkeszl(Convert.ToInt32(Tkeszl.Text));
            k.setTmert(Tmert.Text);
            k.setTkatkod(Convert.ToInt32(Tkatkod.Text));
            k.setTvonkod(Convert.ToInt32(Tvonkod.Text));
            k.setTszavido(Convert.ToDateTime(Tszavido.Text));
            if (Tegalizalte.Checked)
                k.setTegalizalt(true);
            else
                k.setTegalizalt(false);
                    

            


            this.Close();
        }    
        /*public int getTkod() { return Convert.ToInt32(Tkod.Text); }
        public string getNev() { return Tnev.Text; }
        public int getTar() { return Convert.ToInt32(Tar.Text); }
        public int getTkeszl() { return Convert.ToInt32(Tkeszl.Text); }
        public string getTmert() { return Tmert.Text; }
        public int getTkatkod() { return Convert.ToInt32(Tkatkod.Text); }*/
        

    }
}
