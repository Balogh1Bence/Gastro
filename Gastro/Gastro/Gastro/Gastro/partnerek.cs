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
    public partial class partnerek : Form
    {
        MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
        private DataTable partner;
        DataGridViewComboBoxColumn cbc;
        DataTable dataTableGyakorisag;
        public partnerek()
        {
            
            InitializeComponent();
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas(); mdi.open();
            partner = mdi.getToDataTable("SELECT * FROM partnerek");

            dataGridView1.DataSource = partner;
            
            if(cbc==null)
            {
                cbc = new DataGridViewComboBoxColumn();
                dataGridView1.Columns[0].HeaderText = "intézmény név";
                dataGridView1.Columns[1].HeaderText = "intézmény ID";
                cbc.HeaderText = "helyszín";
                cbc.Name = "cbccol";
                dataGridView1.Columns.Add(cbc);
                comboboxTolt();
                setColumnHelyekComboBoxValue();
            }

        }
        public void comboboxTolt()
        {
            Adatbazis gy = new Adatbazis();
            MySQLDatabaseInterface mdiGyakorisag;
            mdiGyakorisag = gy.kapcsolodas();
            mdiGyakorisag.open();
            dataTableGyakorisag = new DataTable();


            int b = 0;
            int az = 0;
            #region
            /*while (b<dataGridView1.Rows.Count-1)
            {
                MessageBox.Show(dataGridView1.Rows[b].Cells[1].Value.ToString());
                
                az = 0;
                az = Convert.ToInt32(dataGridView1.Rows[b].Cells[1].Value.ToString());
                dataTableGyakorisag =
                    mdiGyakorisag.getToDataTable("SELECT CONCAT(irsz,', ',varos,', ',utca,', ',szam) as " +
                    "na, helyek.IntAzon from helyek, partnerek where partnerek.IntAzon=helyek.IntAzon and partnerek.IntAzon=" + az);
               
                cbc.DataSource = dataTableGyakorisag;
                
               
                
                
                cbc.ValueMember = "na";
                cbc.DisplayMember = "IntAzon";
               
              //ez teljesen alkalmatlan a használatra, mivel nem lehet beállítani midnen egyes sorra egyedi értékeket a comboboxra

                b++;
            }*/
            
            #endregion
            /*dataTableGyakorisag =mdiGyakorisag.getToDataTable("SELECT CONCAT(irsz,', ',varos,', ',utca,', ',szam) as " +
                     "na from helyek, partnerek where partnerek.IntAzon=helyek.IntAzon");*/

            #region
            
            dataTableGyakorisag =
           mdiGyakorisag.getToDataTable("SELECT CONCAT(irsz,', ',varos,', ',utca,', ',szam) as " +
           "na, helyek.IntAzon from helyek, partnerek where partnerek.IntAzon=helyek.IntAzon");
            cbc.DataSource = dataTableGyakorisag;
            cbc.ValueMember = "na";
            cbc.DisplayMember = "na";
            
            mdi.close();
            
            #endregion
            cbc.Width = 180;

            
            /*int i = 0;
            while(i<dataGridView1.Rows.Count-1)
            {
                dataGridView1.Rows[i].Cells["cbccol"].Value = dataGridView1.Rows[i].Cells["IntAzon"].Value;
                i++;
            }*/
            
        }
        private void setColumnHelyekComboBoxValue()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                //DataTable-ból olvasva ki az adatokat (1. megoldás)
                //dataGridView1.Rows[i].Cells["cbcol"].Value =
                //dataTableGyakorisag.Rows[i]["helyek.IntAzon"];
                //DataGridView-ból olvasva az adatokat (2. megoldás)
                dataGridView1.Rows[i].Cells[2].Value =
                dataGridView1.Rows[i].Cells[0].Value;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas();
            mdi.open();
            string selectedIntAzon = "";
            string where = "";
            /*dataGridView1.Columns.RemoveAt(1);*/
            

            selectedIntAzon = comboBox1.SelectedItem.ToString();
            

            if (selectedIntAzon != "összes")
                {
                    where = " WHERE partnerek.IntAzon=" + selectedIntAzon;
                /*dataGridView1.Columns.RemoveAt(2);*/
             
                dataGridView1.DataSource = null;
                dataTableGyakorisag = mdi.getToDataTable("SELECT * FROM partnerek" + where);
                dataGridView1.DataSource = dataTableGyakorisag;
                dataGridView1.Columns[0].DisplayIndex = 2;
            }
            else if(selectedIntAzon=="összes")
            {
               
                dataGridView1.DataSource = null;
                dataTableGyakorisag = mdi.getToDataTable("select * from partnerek");
                dataGridView1.DataSource = dataTableGyakorisag;
                dataGridView1.Columns[0].DisplayIndex = 2;
            }
        
            
        }
    }
}
