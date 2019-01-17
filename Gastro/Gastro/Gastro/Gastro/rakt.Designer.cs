namespace Gastro
{
    partial class rakt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.betöltés = new System.Windows.Forms.Button();
            this.szerkesztés = new System.Windows.Forms.Button();
            this.mentés = new System.Windows.Forms.Button();
            this.kilépés = new System.Windows.Forms.Button();
            this.új = new System.Windows.Forms.Button();
            this.törlés = new System.Windows.Forms.Button();
            this.mégsem = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megrendelésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // betöltés
            // 
            this.betöltés.Location = new System.Drawing.Point(713, 29);
            this.betöltés.Name = "betöltés";
            this.betöltés.Size = new System.Drawing.Size(75, 23);
            this.betöltés.TabIndex = 1;
            this.betöltés.Text = "betöltés";
            this.betöltés.UseVisualStyleBackColor = true;
            this.betöltés.Click += new System.EventHandler(this.betöltés_Click);
            // 
            // szerkesztés
            // 
            this.szerkesztés.Location = new System.Drawing.Point(713, 79);
            this.szerkesztés.Name = "szerkesztés";
            this.szerkesztés.Size = new System.Drawing.Size(75, 23);
            this.szerkesztés.TabIndex = 2;
            this.szerkesztés.Text = "szerkesztés";
            this.szerkesztés.UseVisualStyleBackColor = true;
            this.szerkesztés.Click += new System.EventHandler(this.szerkesztés_Click);
            // 
            // mentés
            // 
            this.mentés.Location = new System.Drawing.Point(713, 130);
            this.mentés.Name = "mentés";
            this.mentés.Size = new System.Drawing.Size(75, 23);
            this.mentés.TabIndex = 3;
            this.mentés.Text = "mentés";
            this.mentés.UseVisualStyleBackColor = true;
            this.mentés.Click += new System.EventHandler(this.mentés_Click);
            // 
            // kilépés
            // 
            this.kilépés.Location = new System.Drawing.Point(713, 360);
            this.kilépés.Name = "kilépés";
            this.kilépés.Size = new System.Drawing.Size(75, 23);
            this.kilépés.TabIndex = 4;
            this.kilépés.Text = "kilépés";
            this.kilépés.UseVisualStyleBackColor = true;
            this.kilépés.Click += new System.EventHandler(this.kilépés_Click);
            // 
            // új
            // 
            this.új.Location = new System.Drawing.Point(713, 173);
            this.új.Name = "új";
            this.új.Size = new System.Drawing.Size(75, 23);
            this.új.TabIndex = 5;
            this.új.Text = "új";
            this.új.UseVisualStyleBackColor = true;
            this.új.Click += new System.EventHandler(this.új_Click);
            // 
            // törlés
            // 
            this.törlés.Location = new System.Drawing.Point(713, 220);
            this.törlés.Name = "törlés";
            this.törlés.Size = new System.Drawing.Size(75, 23);
            this.törlés.TabIndex = 6;
            this.törlés.Text = "törlés";
            this.törlés.UseVisualStyleBackColor = true;
            this.törlés.Click += new System.EventHandler(this.törlés_Click);
            // 
            // mégsem
            // 
            this.mégsem.Location = new System.Drawing.Point(713, 271);
            this.mégsem.Name = "mégsem";
            this.mégsem.Size = new System.Drawing.Size(75, 23);
            this.mégsem.TabIndex = 7;
            this.mégsem.Text = "mégsem";
            this.mégsem.UseVisualStyleBackColor = true;
            this.mégsem.Click += new System.EventHandler(this.mégsem_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(713, 319);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 8;
            this.buttonMod.Text = "módosítások";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megrendelésekToolStripMenuItem});
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menu2ToolStripMenuItem.Text = "megrendelések";
            this.menu2ToolStripMenuItem.Click += new System.EventHandler(this.menu2ToolStripMenuItem_Click);
            // 
            // megrendelésekToolStripMenuItem
            // 
            this.megrendelésekToolStripMenuItem.Name = "megrendelésekToolStripMenuItem";
            this.megrendelésekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megrendelésekToolStripMenuItem.Text = "megrendelések";
            this.megrendelésekToolStripMenuItem.Click += new System.EventHandler(this.megrendelésekToolStripMenuItem_Click);
            // 
            // rakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.mégsem);
            this.Controls.Add(this.törlés);
            this.Controls.Add(this.új);
            this.Controls.Add(this.kilépés);
            this.Controls.Add(this.mentés);
            this.Controls.Add(this.szerkesztés);
            this.Controls.Add(this.betöltés);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "rakt";
            this.Text = "rakt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button betöltés;
        private System.Windows.Forms.Button szerkesztés;
        private System.Windows.Forms.Button mentés;
        private System.Windows.Forms.Button kilépés;
        private System.Windows.Forms.Button új;
        private System.Windows.Forms.Button törlés;
        private System.Windows.Forms.Button mégsem;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megrendelésekToolStripMenuItem;
    }
}