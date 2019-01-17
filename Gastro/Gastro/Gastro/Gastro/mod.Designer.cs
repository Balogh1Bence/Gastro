namespace Gastro
{
    partial class mod
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
            this.Tkod = new System.Windows.Forms.TextBox();
            this.Tnev = new System.Windows.Forms.TextBox();
            this.Tar = new System.Windows.Forms.TextBox();
            this.Tkeszl = new System.Windows.Forms.TextBox();
            this.Tmert = new System.Windows.Forms.TextBox();
            this.Tkatkod = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tkod
            // 
            this.Tkod.Location = new System.Drawing.Point(117, 61);
            this.Tkod.Name = "Tkod";
            this.Tkod.Size = new System.Drawing.Size(100, 20);
            this.Tkod.TabIndex = 0;
            // 
            // Tnev
            // 
            this.Tnev.Location = new System.Drawing.Point(117, 87);
            this.Tnev.Name = "Tnev";
            this.Tnev.Size = new System.Drawing.Size(100, 20);
            this.Tnev.TabIndex = 1;
            // 
            // Tar
            // 
            this.Tar.Location = new System.Drawing.Point(117, 113);
            this.Tar.Name = "Tar";
            this.Tar.Size = new System.Drawing.Size(100, 20);
            this.Tar.TabIndex = 2;
            // 
            // Tkeszl
            // 
            this.Tkeszl.Location = new System.Drawing.Point(117, 139);
            this.Tkeszl.Name = "Tkeszl";
            this.Tkeszl.Size = new System.Drawing.Size(100, 20);
            this.Tkeszl.TabIndex = 3;
            // 
            // Tmert
            // 
            this.Tmert.Location = new System.Drawing.Point(117, 165);
            this.Tmert.Name = "Tmert";
            this.Tmert.Size = new System.Drawing.Size(100, 20);
            this.Tmert.TabIndex = 5;
            // 
            // Tkatkod
            // 
            this.Tkatkod.Location = new System.Drawing.Point(117, 191);
            this.Tkatkod.Name = "Tkatkod";
            this.Tkatkod.Size = new System.Drawing.Size(100, 20);
            this.Tkatkod.TabIndex = 6;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(107, 320);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 7;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(272, 320);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Tkatkod);
            this.Controls.Add(this.Tmert);
            this.Controls.Add(this.Tkeszl);
            this.Controls.Add(this.Tar);
            this.Controls.Add(this.Tnev);
            this.Controls.Add(this.Tkod);
            this.Name = "mod";
            this.Text = "mod";
            this.Load += new System.EventHandler(this.mod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tkod;
        private System.Windows.Forms.TextBox Tnev;
        private System.Windows.Forms.TextBox Tar;
        private System.Windows.Forms.TextBox Tkeszl;
        private System.Windows.Forms.TextBox Tmert;
        private System.Windows.Forms.TextBox Tkatkod;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}