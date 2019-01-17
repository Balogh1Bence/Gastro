using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectToMysqlDatabase;
namespace Gastro
{
    public partial class rakt : Form
    {
        MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
        private DataTable termekek;
        
        private bool lettmodositva = false;
        public rakt()
        {
            InitializeComponent();
            vezerlokindulaskor();
        }

        private void betöltés_Click(object sender, EventArgs e)
        {
            feltolt();
            betöltés.Visible = false;
            
        }
        private void feltolt()
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas(); mdi.open();
            termekek = mdi.getToDataTable("SELECT * FROM termekek");
            
            dataGridView1.DataSource = termekek;
            szerkesztés.Visible = false;
            buttonMod.Visible = true;
        }
        private void vezerlokindulaskor() {
            új.Visible = false;
            szerkesztés.Visible = false;
            törlés.Visible = false;
            mégsem.Visible = false;
            mentés.Visible = false;
            buttonMod.Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToDeleteRows = false;
            

        }
        private void beallitvezerloketnemszerk()
        {
            új.Visible = true;
            szerkesztés.Visible = true;
            törlés.Visible = true;
            mentés.Visible = false;
            dataGridView1.ReadOnly = true;
            buttonMod.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToDeleteRows = false;



        }

        private void szerkesztés_Click(object sender, EventArgs e)
        {
          
            int kod = 0, ar = 0, keszl = 0, katkod = 0, Tvonkod=0;
            string nev = "", mert = "";
            bool Tegalizalte=false;
           
            DateTime Tszavido = new DateTime();
            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                kod = Convert.ToInt32(row.Cells[0].Value.ToString());              
                nev = row.Cells[1].Value.ToString();
                ar = Convert.ToInt32(row.Cells[2].Value.ToString());
                keszl = Convert.ToInt32(row.Cells[3].Value.ToString());
                mert = row.Cells[4].Value.ToString();
                katkod = Convert.ToInt32(row.Cells[5].Value.ToString());
                Tvonkod = Convert.ToInt32(row.Cells[6].Value.ToString());
                Tszavido = Convert.ToDateTime(row.Cells[7].Value);
                
                if (row.Cells[8].Value.ToString() == "True")
                { Tegalizalte = true; }
                else Tegalizalte = false;                
                




            }

            Termekek t = new Termekek(kod, nev, ar, keszl, mert, katkod,Tvonkod,Tszavido,Tegalizalte );
            mod modosit = new mod(t);

            if (modosit.ShowDialog() != DialogResult.None)
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    row.Cells[0].Value = t.getTkod();
                    row.Cells[1].Value = t.getTnev();
                    row.Cells[2].Value = t.getTar();
                    row.Cells[3].Value = t.getTkeszl();
                    row.Cells[4].Value = t.getTmert();
                    row.Cells[5].Value = t.getTkatkod();
                    row.Cells[6].Value = t.getTvonkod();
                    row.Cells[7].Value = t.getTszavido();
                    
                    bool eg = false;
                    eg = t.getTegalizalt();
                    MessageBox.Show(eg.ToString());
                    if (eg == true) { row.Cells[8].Value = true; }
                    else
                        row.Cells[8].Value = false;

                    


                }
            }
            
            dataGridView1.ReadOnly = false;
            mentés.Visible = true;
        }
        private void szerkszethetoek()
        {
            új.Visible = false;
            szerkesztés.Visible = false;
            törlés.Visible = false;
            mentés.Visible = true;      
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToDeleteRows = false;         
        }

        private void mégsem_Click(object sender, EventArgs e)
        {
            feltolt();
            beallitvezerloketnemszerk();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lettmodositva = true;

        }

        private void mentés_Click(object sender, EventArgs e)
        {
            if (!lettmodositva)
            { MessageBox.Show("Nem lett módosítva egy adat sem.", "Módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { mdi.updateChangesInTable(termekek);
                beallitvezerloketnemszerk();
                lettmodositva = false;
            }
        }

        private void kilépés_Click(object sender, EventArgs e)
        {
            if (lettmodositva)
            { if (MessageBox.Show("Nem mentett adatok vannak! Valóban ki akar lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { mdi.close();
                    this.Close();
                } }
            else
            { mdi.close();
                this.Close(); }
        }

        private void törlés_Click(object sender, EventArgs e)
        {
            try
            {      int sor = dataGridView1.SelectedRows[0].Index;
                if (MessageBox.Show("Valóban törölni akarja a sort?", "Törlés",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation                     )== DialogResult.Yes)
                {dataGridView1.Rows.RemoveAt(sor);
                    mentés.Visible = true;
                    lettmodositva = true;
                }
                else
                    return;
            }     catch (Exception ex)
            {         MessageBox.Show(
                "Jelölje ki a törlendő sort!",
                "Törlés", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
        }
        private void beallitvezerloketujfelvitelkor()
        {
            új.Visible = false;
            mentés.Enabled = true;
            mentés.Visible = true;
            szerkesztés.Enabled = false;
            törlés.Enabled = false;
            mégsem.Visible = true;
            mégsem.Enabled = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ReadOnly = false;

        }

        private void új_Click(object sender, EventArgs e)
        {
            
           
            Termekek t = new Termekek();
            mod mod = new mod(t);
         
           
            if (mod.ShowDialog()==DialogResult.OK)
            {
               
                int i = 0;
          
                while (i < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.Rows[i].Selected = false;
                    
                    i++;
                        
                        }
                    
                
                dataGridView1.Rows[dataGridView1.Rows.Count-2].Selected = true;
                DataRow rw = termekek.NewRow();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    /*row.Cells[0].Value = t.getTkod();
                    
                    row.Cells[1].Value = t.getTnev();
                   
                    row.Cells[2].Value = t.getTar();
                   
                    row.Cells[3].Value = t.getTkeszl();
                    row.Cells[4].Value = t.getTmert();
                    row.Cells[5].Value = t.getTkatkod();
                    
                    
                    rw[0] = row.Cells[0].Value;
                    rw[1] = row.Cells[1].Value;
                    rw[2] = row.Cells[2].Value;
                    rw[3] = row.Cells[3].Value;
                    rw[4] = row.Cells[4].Value;
                    rw[5] = row.Cells[5].Value;*/

                    rw[0] = t.getTkod();
                    rw[1] = t.getTnev();
                    rw[2] = t.getTar();
                    rw[3] = t.getTkeszl();
                    rw[4] = t.getTmert();
                    rw[5] = t.getTkatkod();
                    rw[6] = t.getTvonkod();
                    rw[7] = t.getTszavido();
                    rw[8] = t.getTegalizalt();

                }


                termekek.Rows.Add(rw);





            }


            /*int bi = 0;
            while(bi<termekek.Rows.Count)
            {
                MessageBox.Show(termekek.Rows[bi].ToString());
                bi++;
            
            }*/
           
          


            
            beallitvezerloketujfelvitelkor();
            int sor = dataGridView1.Rows.Count - 1;
            lettmodositva = true;
         
            dataGridView1.FirstDisplayedScrollingRowIndex = sor;
            dataGridView1.Columns[0].ReadOnly = true;

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
           
            Adatbazis ujida = new Adatbazis();
            MySQLDatabaseInterface mdiujid = ujida.kapcsolodas();
            mdiujid.open();
            int max;
            bool siker = int.TryParse(mdiujid.executeScalarQuery("SELECT MAX(Tkod) FROM termekek"), out max);
            if (!siker) { MessageBox.Show("Nem lehet megállapítani a következő rekord kulcsát. Adatbázis lekérdezési hiba.",
                "Hiba...", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return; }
            mdiujid.close();
            e.Row.Cells[0].Value = max + 1;

        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            beallitvezerloketnemszerk();
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void megrendelésekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partnerek p = new partnerek();
            p.ShowDialog();
        }
    }
}
