
namespace ProiectMPP
{
    partial class Clase
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idElevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialaTataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseDS = new ProiectMPP.ClaseDS();
            this.clasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.elevTableAdapter = new ProiectMPP.ClaseDSTableAdapters.ElevTableAdapter();
            this.clasaTableAdapter = new ProiectMPP.ClaseDSTableAdapters.ClasaTableAdapter();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbClasaPanel = new System.Windows.Forms.ComboBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtLocalitate = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtInitialaTatalui = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblLocalitate = new System.Windows.Forms.Label();
            this.lblClasa = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblInitialaTata = new System.Windows.Forms.Label();
            this.clasaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.claseDS1 = new ProiectMPP.ClaseDS();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClasa = new System.Windows.Forms.ComboBox();
            this.lblMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clasaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseDS1)).BeginInit();
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
            this.Clasa,
            this.localitateDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.elevBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(556, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // Clasa
            // 
            this.Clasa.DataPropertyName = "Clasa";
            this.Clasa.HeaderText = "Clasa";
            this.Clasa.Name = "Clasa";
            this.Clasa.ReadOnly = true;
            this.Clasa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.elevBindingSource.DataSource = this.claseDS;
            // 
            // claseDS
            // 
            this.claseDS.DataSetName = "ClaseDS";
            this.claseDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasaBindingSource
            // 
            this.clasaBindingSource.DataMember = "Clasa";
            this.clasaBindingSource.DataSource = this.claseDS;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 5;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(246, 294);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(987, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // elevTableAdapter
            // 
            this.elevTableAdapter.ClearBeforeFill = true;
            // 
            // clasaTableAdapter
            // 
            this.clasaTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(687, 104);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(172, 25);
            this.btnAdaugare.TabIndex = 3;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(16, 16);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(41, 13);
            this.lblNume.TabIndex = 4;
            this.lblNume.Text = "Nume: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cmbClasaPanel);
            this.panel1.Controls.Add(this.txtAdresa);
            this.panel1.Controls.Add(this.txtLocalitate);
            this.panel1.Controls.Add(this.txtPrenume);
            this.panel1.Controls.Add(this.txtInitialaTatalui);
            this.panel1.Controls.Add(this.txtNume);
            this.panel1.Controls.Add(this.lblAdresa);
            this.panel1.Controls.Add(this.lblLocalitate);
            this.panel1.Controls.Add(this.lblClasa);
            this.panel1.Controls.Add(this.lblPrenume);
            this.panel1.Controls.Add(this.lblInitialaTata);
            this.panel1.Controls.Add(this.lblNume);
            this.panel1.Location = new System.Drawing.Point(1011, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 262);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 245);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 17;
            this.lblData.Text = "Data: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // cmbClasaPanel
            // 
            this.cmbClasaPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasaPanel.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbClasaPanel.Location = new System.Drawing.Point(118, 137);
            this.cmbClasaPanel.Name = "cmbClasaPanel";
            this.cmbClasaPanel.Size = new System.Drawing.Size(172, 21);
            this.cmbClasaPanel.TabIndex = 11;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(118, 214);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(172, 20);
            this.txtAdresa.TabIndex = 15;
            // 
            // txtLocalitate
            // 
            this.txtLocalitate.Location = new System.Drawing.Point(118, 181);
            this.txtLocalitate.Name = "txtLocalitate";
            this.txtLocalitate.Size = new System.Drawing.Size(172, 20);
            this.txtLocalitate.TabIndex = 14;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(118, 95);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(172, 20);
            this.txtPrenume.TabIndex = 12;
            // 
            // txtInitialaTatalui
            // 
            this.txtInitialaTatalui.Location = new System.Drawing.Point(118, 52);
            this.txtInitialaTatalui.MaxLength = 1;
            this.txtInitialaTatalui.Name = "txtInitialaTatalui";
            this.txtInitialaTatalui.Size = new System.Drawing.Size(172, 20);
            this.txtInitialaTatalui.TabIndex = 11;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(118, 9);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(172, 20);
            this.txtNume.TabIndex = 10;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(16, 221);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(46, 13);
            this.lblAdresa.TabIndex = 9;
            this.lblAdresa.Text = "Adresa: ";
            // 
            // lblLocalitate
            // 
            this.lblLocalitate.AutoSize = true;
            this.lblLocalitate.Location = new System.Drawing.Point(16, 184);
            this.lblLocalitate.Name = "lblLocalitate";
            this.lblLocalitate.Size = new System.Drawing.Size(59, 13);
            this.lblLocalitate.TabIndex = 8;
            this.lblLocalitate.Text = "Localitate: ";
            // 
            // lblClasa
            // 
            this.lblClasa.AutoSize = true;
            this.lblClasa.Location = new System.Drawing.Point(16, 140);
            this.lblClasa.Name = "lblClasa";
            this.lblClasa.Size = new System.Drawing.Size(39, 13);
            this.lblClasa.TabIndex = 7;
            this.lblClasa.Text = "Clasa: ";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(16, 98);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(55, 13);
            this.lblPrenume.TabIndex = 6;
            this.lblPrenume.Text = "Prenume: ";
            // 
            // lblInitialaTata
            // 
            this.lblInitialaTata.AutoSize = true;
            this.lblInitialaTata.Location = new System.Drawing.Point(16, 55);
            this.lblInitialaTata.Name = "lblInitialaTata";
            this.lblInitialaTata.Size = new System.Drawing.Size(75, 13);
            this.lblInitialaTata.TabIndex = 5;
            this.lblInitialaTata.Text = "Initiala Tatalui:";
            // 
            // clasaBindingSource1
            // 
            this.clasaBindingSource1.DataMember = "Clasa";
            this.clasaBindingSource1.DataSource = this.claseDS;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Enabled = false;
            this.btnConfirmare.Location = new System.Drawing.Point(687, 181);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(83, 28);
            this.btnConfirmare.TabIndex = 6;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Enabled = false;
            this.btnRenuntare.Location = new System.Drawing.Point(776, 181);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(83, 28);
            this.btnRenuntare.TabIndex = 7;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(687, 140);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(172, 25);
            this.btnModificare.TabIndex = 8;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // claseDS1
            // 
            this.claseDS1.DataSetName = "ClaseDS";
            this.claseDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clasa:";
            // 
            // cbClasa
            // 
            this.cbClasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasa.Items.AddRange(new object[] {
            "IX A",
            "IX B",
            "IX C",
            "X A",
            "X B",
            "X C",
            "XI A",
            "XI B",
            "XI C",
            "XII A",
            "XII B",
            "XII C"});
            this.cbClasa.Location = new System.Drawing.Point(710, 50);
            this.cbClasa.Name = "cbClasa";
            this.cbClasa.Size = new System.Drawing.Size(121, 21);
            this.cbClasa.TabIndex = 9;
            this.cbClasa.SelectedValueChanged += new System.EventHandler(this.cbClasa_SelectedValueChanged);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(747, 251);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(0, 13);
            this.lblMain.TabIndex = 11;
            // 
            // Clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 606);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClasa);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clase";
            this.Text = "Clase";
            this.Load += new System.EventHandler(this.Clase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clasaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ClaseDS claseDS;
        private System.Windows.Forms.BindingSource elevBindingSource;
        private ClaseDSTableAdapters.ElevTableAdapter elevTableAdapter;
        private System.Windows.Forms.BindingSource clasaBindingSource;
        private ClaseDSTableAdapters.ClasaTableAdapter clasaTableAdapter;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInitialaTata;
        private System.Windows.Forms.TextBox txtInitialaTatalui;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblLocalitate;
        private System.Windows.Forms.Label lblClasa;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.BindingSource clasaBindingSource1;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Button btnModificare;
        private ClaseDS claseDS1;
        private System.Windows.Forms.TextBox txtLocalitate;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ComboBox cmbClasaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idElevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialaTataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}