
namespace ProiectMPP
{
    partial class Note
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idElevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialaTataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteDS = new ProiectMPP.NoteDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idElevDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.romanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matematicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.germanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biologieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chimieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muzicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteDS1 = new ProiectMPP.NoteDS();
            this.cbClasa = new System.Windows.Forms.ComboBox();
            this.lblClasa = new System.Windows.Forms.Label();
            this.btnAdaugareNote = new System.Windows.Forms.Button();
            this.elevTableAdapter = new ProiectMPP.NoteDSTableAdapters.ElevTableAdapter();
            this.LblMaterie = new System.Windows.Forms.Label();
            this.cmbMaterie = new System.Windows.Forms.ComboBox();
            this.LblNota = new System.Windows.Forms.Label();
            this.cmbNota = new System.Windows.Forms.ComboBox();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.noteeTableAdapter = new ProiectMPP.NoteDSTableAdapters.NoteeTableAdapter();
            this.btnMedie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idElevDataGridViewTextBoxColumn,
            this.Nume,
            this.initialaTataDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.clasaDataGridViewTextBoxColumn,
            this.localitateDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.elevBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(605, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // idElevDataGridViewTextBoxColumn
            // 
            this.idElevDataGridViewTextBoxColumn.DataPropertyName = "IdElev";
            this.idElevDataGridViewTextBoxColumn.HeaderText = "IdElev";
            this.idElevDataGridViewTextBoxColumn.Name = "idElevDataGridViewTextBoxColumn";
            this.idElevDataGridViewTextBoxColumn.ReadOnly = true;
            this.idElevDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nume
            // 
            this.Nume.DataPropertyName = "Nume";
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            // 
            // initialaTataDataGridViewTextBoxColumn
            // 
            this.initialaTataDataGridViewTextBoxColumn.DataPropertyName = "InitialaTata";
            this.initialaTataDataGridViewTextBoxColumn.HeaderText = "InitialaTata";
            this.initialaTataDataGridViewTextBoxColumn.Name = "initialaTataDataGridViewTextBoxColumn";
            this.initialaTataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clasaDataGridViewTextBoxColumn
            // 
            this.clasaDataGridViewTextBoxColumn.DataPropertyName = "Clasa";
            this.clasaDataGridViewTextBoxColumn.HeaderText = "Clasa";
            this.clasaDataGridViewTextBoxColumn.Name = "clasaDataGridViewTextBoxColumn";
            this.clasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localitateDataGridViewTextBoxColumn
            // 
            this.localitateDataGridViewTextBoxColumn.DataPropertyName = "Localitate";
            this.localitateDataGridViewTextBoxColumn.HeaderText = "Localitate";
            this.localitateDataGridViewTextBoxColumn.Name = "localitateDataGridViewTextBoxColumn";
            this.localitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elevBindingSource
            // 
            this.elevBindingSource.DataMember = "Elev";
            this.elevBindingSource.DataSource = this.noteDS;
            this.elevBindingSource.CurrentChanged += new System.EventHandler(this.elevBindingSource_CurrentChanged);
            // 
            // noteDS
            // 
            this.noteDS.DataSetName = "NoteDS";
            this.noteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idElevDataGridViewTextBoxColumn1,
            this.romanaDataGridViewTextBoxColumn,
            this.matematicaDataGridViewTextBoxColumn,
            this.fizicaDataGridViewTextBoxColumn,
            this.sportDataGridViewTextBoxColumn,
            this.englezaDataGridViewTextBoxColumn,
            this.germanaDataGridViewTextBoxColumn,
            this.biologieDataGridViewTextBoxColumn,
            this.chimieDataGridViewTextBoxColumn,
            this.desenDataGridViewTextBoxColumn,
            this.muzicaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.noteeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(824, 83);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(597, 294);
            this.dataGridView2.TabIndex = 1;
            // 
            // idElevDataGridViewTextBoxColumn1
            // 
            this.idElevDataGridViewTextBoxColumn1.DataPropertyName = "IdElev";
            this.idElevDataGridViewTextBoxColumn1.HeaderText = "IdElev";
            this.idElevDataGridViewTextBoxColumn1.Name = "idElevDataGridViewTextBoxColumn1";
            this.idElevDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idElevDataGridViewTextBoxColumn1.Visible = false;
            // 
            // romanaDataGridViewTextBoxColumn
            // 
            this.romanaDataGridViewTextBoxColumn.DataPropertyName = "Romana";
            this.romanaDataGridViewTextBoxColumn.HeaderText = "Romana";
            this.romanaDataGridViewTextBoxColumn.Name = "romanaDataGridViewTextBoxColumn";
            this.romanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matematicaDataGridViewTextBoxColumn
            // 
            this.matematicaDataGridViewTextBoxColumn.DataPropertyName = "Matematica";
            this.matematicaDataGridViewTextBoxColumn.HeaderText = "Matematica";
            this.matematicaDataGridViewTextBoxColumn.Name = "matematicaDataGridViewTextBoxColumn";
            this.matematicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fizicaDataGridViewTextBoxColumn
            // 
            this.fizicaDataGridViewTextBoxColumn.DataPropertyName = "Fizica";
            this.fizicaDataGridViewTextBoxColumn.HeaderText = "Fizica";
            this.fizicaDataGridViewTextBoxColumn.Name = "fizicaDataGridViewTextBoxColumn";
            this.fizicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sportDataGridViewTextBoxColumn
            // 
            this.sportDataGridViewTextBoxColumn.DataPropertyName = "Sport";
            this.sportDataGridViewTextBoxColumn.HeaderText = "Sport";
            this.sportDataGridViewTextBoxColumn.Name = "sportDataGridViewTextBoxColumn";
            this.sportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // englezaDataGridViewTextBoxColumn
            // 
            this.englezaDataGridViewTextBoxColumn.DataPropertyName = "Engleza";
            this.englezaDataGridViewTextBoxColumn.HeaderText = "Engleza";
            this.englezaDataGridViewTextBoxColumn.Name = "englezaDataGridViewTextBoxColumn";
            this.englezaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // germanaDataGridViewTextBoxColumn
            // 
            this.germanaDataGridViewTextBoxColumn.DataPropertyName = "Germana";
            this.germanaDataGridViewTextBoxColumn.HeaderText = "Germana";
            this.germanaDataGridViewTextBoxColumn.Name = "germanaDataGridViewTextBoxColumn";
            this.germanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biologieDataGridViewTextBoxColumn
            // 
            this.biologieDataGridViewTextBoxColumn.DataPropertyName = "Biologie";
            this.biologieDataGridViewTextBoxColumn.HeaderText = "Biologie";
            this.biologieDataGridViewTextBoxColumn.Name = "biologieDataGridViewTextBoxColumn";
            this.biologieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chimieDataGridViewTextBoxColumn
            // 
            this.chimieDataGridViewTextBoxColumn.DataPropertyName = "Chimie";
            this.chimieDataGridViewTextBoxColumn.HeaderText = "Chimie";
            this.chimieDataGridViewTextBoxColumn.Name = "chimieDataGridViewTextBoxColumn";
            this.chimieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desenDataGridViewTextBoxColumn
            // 
            this.desenDataGridViewTextBoxColumn.DataPropertyName = "Desen";
            this.desenDataGridViewTextBoxColumn.HeaderText = "Desen";
            this.desenDataGridViewTextBoxColumn.Name = "desenDataGridViewTextBoxColumn";
            this.desenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // muzicaDataGridViewTextBoxColumn
            // 
            this.muzicaDataGridViewTextBoxColumn.DataPropertyName = "Muzica";
            this.muzicaDataGridViewTextBoxColumn.HeaderText = "Muzica";
            this.muzicaDataGridViewTextBoxColumn.Name = "muzicaDataGridViewTextBoxColumn";
            this.muzicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Informatica_Tic";
            this.dataGridViewTextBoxColumn1.HeaderText = "Informatica_Tic";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noteeBindingSource
            // 
            this.noteeBindingSource.DataMember = "Notee";
            this.noteeBindingSource.DataSource = this.noteDS1;
            // 
            // noteDS1
            // 
            this.noteDS1.DataSetName = "NoteDS";
            this.noteDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbClasa
            // 
            this.cbClasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasa.Location = new System.Drawing.Point(102, 33);
            this.cbClasa.Name = "cbClasa";
            this.cbClasa.Size = new System.Drawing.Size(121, 21);
            this.cbClasa.TabIndex = 2;
            this.cbClasa.SelectedValueChanged += new System.EventHandler(this.cbClasa_ValueMemberChanged);
            // 
            // lblClasa
            // 
            this.lblClasa.AutoSize = true;
            this.lblClasa.Location = new System.Drawing.Point(24, 36);
            this.lblClasa.Name = "lblClasa";
            this.lblClasa.Size = new System.Drawing.Size(36, 13);
            this.lblClasa.TabIndex = 3;
            this.lblClasa.Text = "Clasa:";
            // 
            // btnAdaugareNote
            // 
            this.btnAdaugareNote.Location = new System.Drawing.Point(671, 50);
            this.btnAdaugareNote.Name = "btnAdaugareNote";
            this.btnAdaugareNote.Size = new System.Drawing.Size(97, 56);
            this.btnAdaugareNote.TabIndex = 4;
            this.btnAdaugareNote.Text = "AdaugareNote";
            this.btnAdaugareNote.UseVisualStyleBackColor = true;
            this.btnAdaugareNote.Click += new System.EventHandler(this.btnModificareNote_Click);
            // 
            // elevTableAdapter
            // 
            this.elevTableAdapter.ClearBeforeFill = true;
            // 
            // LblMaterie
            // 
            this.LblMaterie.AutoSize = true;
            this.LblMaterie.Location = new System.Drawing.Point(697, 185);
            this.LblMaterie.Name = "LblMaterie";
            this.LblMaterie.Size = new System.Drawing.Size(42, 13);
            this.LblMaterie.TabIndex = 5;
            this.LblMaterie.Text = "Materie";
            this.LblMaterie.Visible = false;
            // 
            // cmbMaterie
            // 
            this.cmbMaterie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterie.FormattingEnabled = true;
            this.cmbMaterie.Items.AddRange(new object[] {
            "Romana",
            "Matematica",
            "Fizica",
            "Sport",
            "Engleza",
            "Germana",
            "Biologie",
            "Chimie",
            "Desen",
            "Muzica",
            "Informatica_Tic"});
            this.cmbMaterie.Location = new System.Drawing.Point(659, 201);
            this.cmbMaterie.Name = "cmbMaterie";
            this.cmbMaterie.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterie.TabIndex = 6;
            this.cmbMaterie.Visible = false;
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Location = new System.Drawing.Point(697, 281);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(30, 13);
            this.LblNota.TabIndex = 7;
            this.LblNota.Text = "Nota";
            this.LblNota.Visible = false;
            // 
            // cmbNota
            // 
            this.cmbNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNota.FormattingEnabled = true;
            this.cmbNota.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNota.Location = new System.Drawing.Point(659, 306);
            this.cmbNota.Name = "cmbNota";
            this.cmbNota.Size = new System.Drawing.Size(121, 21);
            this.cmbNota.TabIndex = 8;
            this.cmbNota.Visible = false;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(614, 383);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(97, 26);
            this.btnConfirmare.TabIndex = 9;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Visible = false;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(717, 383);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(97, 26);
            this.btnRenuntare.TabIndex = 10;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Visible = false;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // noteeTableAdapter
            // 
            this.noteeTableAdapter.ClearBeforeFill = true;
            // 
            // btnMedie
            // 
            this.btnMedie.Location = new System.Drawing.Point(683, 112);
            this.btnMedie.Name = "btnMedie";
            this.btnMedie.Size = new System.Drawing.Size(75, 23);
            this.btnMedie.TabIndex = 11;
            this.btnMedie.Text = "Raport";
            this.btnMedie.UseVisualStyleBackColor = true;
            this.btnMedie.Click += new System.EventHandler(this.btnMedie_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 450);
            this.Controls.Add(this.btnMedie);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.cmbNota);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.cmbMaterie);
            this.Controls.Add(this.LblMaterie);
            this.Controls.Add(this.btnAdaugareNote);
            this.Controls.Add(this.lblClasa);
            this.Controls.Add(this.cbClasa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Note";
            this.Text = "Note";
            this.Load += new System.EventHandler(this.Note_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbClasa;
        private System.Windows.Forms.Label lblClasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn limbaRomanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limbaEnglezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limbaGermanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informaticaTicDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdaugareNote;
        private NoteDS noteDS;
        private System.Windows.Forms.BindingSource elevBindingSource;
        private NoteDSTableAdapters.ElevTableAdapter elevTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idElevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialaTataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LblMaterie;
        private System.Windows.Forms.ComboBox cmbMaterie;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.ComboBox cmbNota;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private NoteDS noteDS1;
        private System.Windows.Forms.BindingSource noteeBindingSource;
        private NoteDSTableAdapters.NoteeTableAdapter noteeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idElevDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn romanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matematicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn germanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biologieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chimieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muzicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnMedie;
    }
}