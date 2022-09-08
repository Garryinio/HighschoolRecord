
namespace ProiectMPP
{
    partial class FStart
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.claseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exmatriculareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(277, 140);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(205, 13);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Aplicatie pt. evidenta elevilor dintr-un liceu";
            this.lblTitlu.Visible = false;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(311, 184);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(137, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor: Platon Mihai-Valentin";
            this.lblAutor.Visible = false;
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(277, 244);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(47, 13);
            this.lblUtilizator.TabIndex = 2;
            this.lblUtilizator.Text = "Utilizator";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(277, 295);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(345, 241);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(103, 20);
            this.txtUtilizator.TabIndex = 4;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(345, 288);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(103, 20);
            this.txtParola.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(360, 351);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.claseToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.mediiToolStripMenuItem,
            this.exmatriculareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // claseToolStripMenuItem
            // 
            this.claseToolStripMenuItem.Name = "claseToolStripMenuItem";
            this.claseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.claseToolStripMenuItem.Text = "Clase";
            this.claseToolStripMenuItem.Click += new System.EventHandler(this.claseToolStripMenuItem_Click);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.noteToolStripMenuItem.Text = "Note";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
            // 
            // mediiToolStripMenuItem
            // 
            this.mediiToolStripMenuItem.Name = "mediiToolStripMenuItem";
            this.mediiToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.mediiToolStripMenuItem.Text = "Medii";
            this.mediiToolStripMenuItem.Click += new System.EventHandler(this.mediiToolStripMenuItem_Click);
            // 
            // exmatriculareToolStripMenuItem
            // 
            this.exmatriculareToolStripMenuItem.Name = "exmatriculareToolStripMenuItem";
            this.exmatriculareToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.exmatriculareToolStripMenuItem.Text = "Exmatriculare";
            this.exmatriculareToolStripMenuItem.Click += new System.EventHandler(this.exmatriculareToolStripMenuItem_Click);
            // 
            // FStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FStart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FStart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem claseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exmatriculareToolStripMenuItem;
    }
}

