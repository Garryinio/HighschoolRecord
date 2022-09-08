
namespace ProiectMPP
{
    partial class lblData
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
            this.numeCompletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exmatriculariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exmatriculariDS = new ProiectMPP.ExmatriculariDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idElevDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialaTataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseDS = new ProiectMPP.ClaseDS();
            this.elevTableAdapter = new ProiectMPP.ClaseDSTableAdapters.ElevTableAdapter();
            this.btnExmatriculare = new System.Windows.Forms.Button();
            this.btnPromovare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClasa = new System.Windows.Forms.ComboBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMotiv = new System.Windows.Forms.Label();
            this.txtMotiv = new System.Windows.Forms.TextBox();
            this.exmatriculariTableAdapter = new ProiectMPP.ExmatriculariDSTableAdapters.ExmatriculariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exmatriculariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exmatriculariDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseDS)).BeginInit();
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
            this.numeCompletDataGridViewTextBoxColumn,
            this.motivDataGridViewTextBoxColumn,
            this.dataExmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exmatriculariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1059, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(839, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // idElevDataGridViewTextBoxColumn
            // 
            this.idElevDataGridViewTextBoxColumn.DataPropertyName = "IdElev";
            this.idElevDataGridViewTextBoxColumn.HeaderText = "IdElev";
            this.idElevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idElevDataGridViewTextBoxColumn.Name = "idElevDataGridViewTextBoxColumn";
            this.idElevDataGridViewTextBoxColumn.ReadOnly = true;
            this.idElevDataGridViewTextBoxColumn.Visible = false;
            this.idElevDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeCompletDataGridViewTextBoxColumn
            // 
            this.numeCompletDataGridViewTextBoxColumn.DataPropertyName = "NumeComplet";
            this.numeCompletDataGridViewTextBoxColumn.HeaderText = "NumeComplet";
            this.numeCompletDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeCompletDataGridViewTextBoxColumn.Name = "numeCompletDataGridViewTextBoxColumn";
            this.numeCompletDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeCompletDataGridViewTextBoxColumn.Width = 125;
            // 
            // motivDataGridViewTextBoxColumn
            // 
            this.motivDataGridViewTextBoxColumn.DataPropertyName = "Motiv";
            this.motivDataGridViewTextBoxColumn.HeaderText = "Motiv";
            this.motivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motivDataGridViewTextBoxColumn.Name = "motivDataGridViewTextBoxColumn";
            this.motivDataGridViewTextBoxColumn.ReadOnly = true;
            this.motivDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataExmDataGridViewTextBoxColumn
            // 
            this.dataExmDataGridViewTextBoxColumn.DataPropertyName = "DataExm";
            this.dataExmDataGridViewTextBoxColumn.HeaderText = "DataExm";
            this.dataExmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataExmDataGridViewTextBoxColumn.Name = "dataExmDataGridViewTextBoxColumn";
            this.dataExmDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataExmDataGridViewTextBoxColumn.Width = 125;
            // 
            // exmatriculariBindingSource
            // 
            this.exmatriculariBindingSource.DataMember = "Exmatriculari";
            this.exmatriculariBindingSource.DataSource = this.exmatriculariDS;
            // 
            // exmatriculariDS
            // 
            this.exmatriculariDS.DataSetName = "ExmatriculariDS";
            this.exmatriculariDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idElevDataGridViewTextBoxColumn1,
            this.Nume,
            this.initialaTataDataGridViewTextBoxColumn1,
            this.prenumeDataGridViewTextBoxColumn1,
            this.clasaDataGridViewTextBoxColumn1,
            this.localitateDataGridViewTextBoxColumn1,
            this.adresaDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.elevBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 15);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(860, 524);
            this.dataGridView2.TabIndex = 1;
            // 
            // idElevDataGridViewTextBoxColumn1
            // 
            this.idElevDataGridViewTextBoxColumn1.DataPropertyName = "IdElev";
            this.idElevDataGridViewTextBoxColumn1.HeaderText = "IdElev";
            this.idElevDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idElevDataGridViewTextBoxColumn1.Name = "idElevDataGridViewTextBoxColumn1";
            this.idElevDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idElevDataGridViewTextBoxColumn1.Visible = false;
            this.idElevDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Nume
            // 
            this.Nume.DataPropertyName = "Nume";
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 6;
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            this.Nume.Width = 125;
            // 
            // initialaTataDataGridViewTextBoxColumn1
            // 
            this.initialaTataDataGridViewTextBoxColumn1.DataPropertyName = "InitialaTata";
            this.initialaTataDataGridViewTextBoxColumn1.HeaderText = "InitialaTata";
            this.initialaTataDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.initialaTataDataGridViewTextBoxColumn1.Name = "initialaTataDataGridViewTextBoxColumn1";
            this.initialaTataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.initialaTataDataGridViewTextBoxColumn1.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn1
            // 
            this.prenumeDataGridViewTextBoxColumn1.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn1.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn1.Name = "prenumeDataGridViewTextBoxColumn1";
            this.prenumeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prenumeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // clasaDataGridViewTextBoxColumn1
            // 
            this.clasaDataGridViewTextBoxColumn1.DataPropertyName = "Clasa";
            this.clasaDataGridViewTextBoxColumn1.HeaderText = "Clasa";
            this.clasaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clasaDataGridViewTextBoxColumn1.Name = "clasaDataGridViewTextBoxColumn1";
            this.clasaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clasaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // localitateDataGridViewTextBoxColumn1
            // 
            this.localitateDataGridViewTextBoxColumn1.DataPropertyName = "Localitate";
            this.localitateDataGridViewTextBoxColumn1.HeaderText = "Localitate";
            this.localitateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.localitateDataGridViewTextBoxColumn1.Name = "localitateDataGridViewTextBoxColumn1";
            this.localitateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.localitateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // adresaDataGridViewTextBoxColumn1
            // 
            this.adresaDataGridViewTextBoxColumn1.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn1.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn1.Name = "adresaDataGridViewTextBoxColumn1";
            this.adresaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // elevBindingSource
            // 
            this.elevBindingSource.DataMember = "Elev";
            this.elevBindingSource.DataSource = this.claseDS;
            // 
            // claseDS
            // 
            this.claseDS.DataSetName = "ClaseDS";
            this.claseDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elevTableAdapter
            // 
            this.elevTableAdapter.ClearBeforeFill = true;
            // 
            // btnExmatriculare
            // 
            this.btnExmatriculare.Location = new System.Drawing.Point(900, 160);
            this.btnExmatriculare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExmatriculare.Name = "btnExmatriculare";
            this.btnExmatriculare.Size = new System.Drawing.Size(132, 28);
            this.btnExmatriculare.TabIndex = 2;
            this.btnExmatriculare.Text = "Exmatriculare";
            this.btnExmatriculare.UseVisualStyleBackColor = true;
            this.btnExmatriculare.Click += new System.EventHandler(this.btnExmatriculare_Click);
            // 
            // btnPromovare
            // 
            this.btnPromovare.Location = new System.Drawing.Point(900, 217);
            this.btnPromovare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPromovare.Name = "btnPromovare";
            this.btnPromovare.Size = new System.Drawing.Size(132, 28);
            this.btnPromovare.TabIndex = 3;
            this.btnPromovare.Text = "Promovare";
            this.btnPromovare.UseVisualStyleBackColor = true;
            this.btnPromovare.Click += new System.EventHandler(this.btnPromovare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Enabled = false;
            this.btnConfirmare.Location = new System.Drawing.Point(913, 282);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(104, 47);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Enabled = false;
            this.btnRenuntare.Location = new System.Drawing.Point(913, 336);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(104, 47);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(939, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clasa:";
            // 
            // cbClasa
            // 
            this.cbClasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasa.Location = new System.Drawing.Point(889, 46);
            this.cbClasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClasa.Name = "cbClasa";
            this.cbClasa.Size = new System.Drawing.Size(160, 24);
            this.cbClasa.TabIndex = 11;
            this.cbClasa.SelectedValueChanged += new System.EventHandler(this.cbClasa_SelectedValueChanged);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(939, 113);
            this.lblMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(0, 17);
            this.lblMain.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1363, 129);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1456, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data";
            this.label3.Visible = false;
            // 
            // lblMotiv
            // 
            this.lblMotiv.AutoSize = true;
            this.lblMotiv.Location = new System.Drawing.Point(1456, 217);
            this.lblMotiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotiv.Name = "lblMotiv";
            this.lblMotiv.Size = new System.Drawing.Size(41, 17);
            this.lblMotiv.TabIndex = 16;
            this.lblMotiv.Text = "Motiv";
            this.lblMotiv.Visible = false;
            // 
            // txtMotiv
            // 
            this.txtMotiv.Location = new System.Drawing.Point(1363, 270);
            this.txtMotiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotiv.Name = "txtMotiv";
            this.txtMotiv.Size = new System.Drawing.Size(247, 22);
            this.txtMotiv.TabIndex = 17;
            this.txtMotiv.Visible = false;
            // 
            // exmatriculariTableAdapter
            // 
            this.exmatriculariTableAdapter.ClearBeforeFill = true;
            // 
            // lblData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1911, 818);
            this.Controls.Add(this.txtMotiv);
            this.Controls.Add(this.lblMotiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClasa);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnPromovare);
            this.Controls.Add(this.btnExmatriculare);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "lblData";
            this.Text = "Exmatriculare";
            this.Load += new System.EventHandler(this.Exmatriculare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exmatriculariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exmatriculariDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ClaseDS claseDS;
        private System.Windows.Forms.BindingSource elevBindingSource;
        private ClaseDSTableAdapters.ElevTableAdapter elevTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idElevDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialaTataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnExmatriculare;
        private System.Windows.Forms.Button btnPromovare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClasa;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMotiv;
        private System.Windows.Forms.TextBox txtMotiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private ExmatriculariDS exmatriculariDS;
        private System.Windows.Forms.BindingSource exmatriculariBindingSource;
        private ExmatriculariDSTableAdapters.ExmatriculariTableAdapter exmatriculariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idElevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeCompletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExmDataGridViewTextBoxColumn;
    }
}