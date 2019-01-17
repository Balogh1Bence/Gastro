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
    public partial class Form1 : Form
    {
        ErrorProvider uname = new ErrorProvider();
        ErrorProvider pw = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jelsz j = new jelsz();
            j.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
     

            us u = new us();
            rakt rakt = new rakt();
            
            if (u.belep(textBox1.Text, textBox2.Text)==0)
            {
                rakt.Show();
                
            }
            if (u.belep(textBox1.Text, textBox2.Text) == 1)
            {
                pw.SetError(textBox2,"helytelen jelszó");

            }
            else
            {
                pw.Clear();

                pw.SetError(textBox2, "");
            }
            if (u.belep(textBox1.Text, textBox2.Text) == 2)
            {
                uname.SetError(textBox1, "nincs ilyen felhasználónév");


            }
            else
            {
                uname.Clear();
                uname.SetError(textBox1, "");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
