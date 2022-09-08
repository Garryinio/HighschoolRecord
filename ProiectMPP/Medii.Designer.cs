
namespace ProiectMPP
{
    partial class Medii
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
            this.lblClasa = new System.Windows.Forms.Label();
            this.cbClasa = new System.Windows.Forms.ComboBox();
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
            this.informaticaTicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteDS = new ProiectMPP.NoteDS();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idElevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialaTataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elevTableAdapter = new ProiectMPP.NoteDSTableAdapters.ElevTableAdapter();
            this.noteeTableAdapter = new ProiectMPP.NoteDSTableAdapters.NoteeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClasa
            // 
            this.lblClasa.AutoSize = true;
            this.lblClasa.Location = new System.Drawing.Point(35, 91);
            this.lblClasa.Name = "lblClasa";
            this.lblClasa.Size = new System.Drawing.Size(36, 13);
            this.lblClasa.TabIndex = 15;
            this.lblClasa.Text = "Clasa:";
            // 
            // cbClasa
            // 
            this.cbClasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasa.Location = new System.Drawing.Point(113, 88);
            this.cbClasa.Name = "cbClasa";
            this.cbClasa.Size = new System.Drawing.Size(121, 21);
            this.cbClasa.TabIndex = 14;
            this.cbClasa.SelectedValueChanged += new System.EventHandler(this.cbClasa_ValueMemberChanged);
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
            this.informaticaTicDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.noteeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(835, 138);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(597, 294);
            this.dataGridView2.TabIndex = 13;
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
            // informaticaTicDataGridViewTextBoxColumn
            // 
            this.informaticaTicDataGridViewTextBoxColumn.DataPropertyName = "Informatica_Tic";
            this.informaticaTicDataGridViewTextBoxColumn.HeaderText = "Informatica_Tic";
            this.informaticaTicDataGridViewTextBoxColumn.Name = "informaticaTicDataGridViewTextBoxColumn";
            this.informaticaTicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteeBindingSource
            // 
            this.noteeBindingSource.DataMember = "Notee";
            this.noteeBindingSource.DataSource = this.noteDS;
            // 
            // noteDS
            // 
            this.noteDS.DataSetName = "NoteDS";
            this.noteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(605, 294);
            this.dataGridView1.TabIndex = 12;
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
            // elevTableAdapter
            // 
            this.elevTableAdapter.ClearBeforeFill = true;
            // 
            // noteeTableAdapter
            // 
            this.noteeTableAdapter.ClearBeforeFill = true;
            // 
            // Medii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 552);
            this.Controls.Add(this.lblClasa);
            this.Controls.Add(this.cbClasa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Medii";
            this.Text = "Medii";
            this.Load += new System.EventHandler(this.Medii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClasa;
        private System.Windows.Forms.ComboBox cbClasa;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NoteDS noteDS;
        private System.Windows.Forms.BindingSource elevBindingSource;
        private NoteDSTableAdapters.ElevTableAdapter elevTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn informaticaTicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idElevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialaTataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
    }
}