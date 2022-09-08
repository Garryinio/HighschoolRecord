using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace ProiectMPP
{
    public partial class Clase : Form
    {
        private int nrElevi, nrClase;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader r;

        private string lastCell;
        public Clase()
        {
            InitializeComponent();
        }

        private void Clase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'claseDS.Clasa' table. You can move, or remove it, as needed.
            this.clasaTableAdapter.Fill(this.claseDS.Clasa);
            // TODO: This line of code loads data into the 'claseDS.Elev' table. You can move, or remove it, as needed.
            this.elevTableAdapter.Fill(this.claseDS.Elev);

            this.dataGridView1.Sort(this.dataGridView1.Columns["Nume"], ListSortDirection.Ascending);

            nrElevi = claseDS.Elev.Rows.Count;

            nrClase = claseDS.Clasa.Rows.Count;
            dataGridView1.Focus();

            RefreshChart();
        }


        private void RefreshChart()
        {

            con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT COUNT(*) FROM Clase";
            Int32 nrClase = (Int32)cmd.ExecuteScalar();
            con.Close();

            string[] xval = new string[nrClase ];
            int[] yval = new int[nrClase ];




            con.Close();

            cmd.CommandText = "Select DenumireClasa From Clase ";


            con.Open();

            r = cmd.ExecuteReader();
            int x = 0;
            while (r.Read())
            {
                xval[x] = r.GetString(0);
                x++;
            }

          
            foreach (DataRow r in claseDS.Elev)
            {
                con.Close();
                string clasa = r["Clasa"].ToString();

               int id = (int)r["IdElev"];

                cmd.CommandText = "Select IdClasa From SituatieElev Where IdElev = " +id;

                con.Open();

                int idClasa = (int)cmd.ExecuteScalar();


                con.Close();

                yval[idClasa - 1]++;
            }

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            chart1.ChartAreas[0].AxisY.Maximum = nrElevi;

            chart1.Series[0].Points.DataBindXY(xval, yval);

            chart1.Series[0].Name = "Grad ocupare";
            chart1.Series[0].ChartType = SeriesChartType.Column;
        }
        private void cbClasa_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.Enabled)
            {
                string clasaAleasa = cbClasa.Text;

                elevBindingSource.Filter = "Clasa = " + "'" + clasaAleasa + "'";

                this.dataGridView1.Sort(this.dataGridView1.Columns["Nume"], ListSortDirection.Ascending);

                dataGridView1.Focus();
            }
       
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A1(true);
            A3(true);
            lblMain.Text = "ADAUGARE";

            txtNume.Focus();
            txtNume.Text = null;
            txtInitialaTatalui.Text = null;
            txtPrenume.Text = null;
            cmbClasaPanel.SelectedItem = null;
            txtLocalitate.Text = null;
            txtAdresa.Text = null;

            dataGridView1.Enabled = false;
            cbClasa.Enabled = false;
            
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A1(true);
            lblMain.Text = "MODIFICARE/TRANSFER";
            A3(false);

        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            

            if (lblMain.Text == "ADAUGARE")
            {
                dateTimePicker1.Enabled = true;
                if (txtNume.Text == "")
                {
                    MessageBox.Show("Numele nu a fost adaugat!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPrenume.Text == "")
                {
                    MessageBox.Show("Prenumele nu a fost adaugat!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(cmbClasaPanel.SelectedIndex == -1)
                {
                    MessageBox.Show("Clasa nu a fost selectata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtLocalitate.Text == "")
                {
                    MessageBox.Show("Localitatea nu a fost adaugata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtAdresa.Text == "")
                {
                    MessageBox.Show("Adresa nu a fost adaugata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                string listaCampuri = "Nume, InitialaTata, Prenume, Clasa, Localitate, Adresa";
                string listaValori =
                     "'" + txtNume.Text + "'" +
                          ",'" + txtInitialaTatalui.Text + "'" +
                          ",'" + txtPrenume.Text + "'" +
                          ",'" + cmbClasaPanel.Text + "'" +
                          ",'" + txtLocalitate.Text + "'" +
                          ",'" + txtAdresa.Text + "'";
                cmd.CommandText = "Insert into Elev(" + listaCampuri + ") " +
                  "Values " + "(" + listaValori + ")";


                
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                elevTableAdapter.Update(claseDS.Elev);

                cmd.CommandText = "SELECT TOP 1 IdElev FROM Elev ORDER BY IdElev DESC";
                con.Open();
                int ultimulId = (int)cmd.ExecuteScalar();
                con.Close();

                cmd.CommandText = "Select IdClasa From Clase Where DenumireClasa = " + "'" + cmbClasaPanel.Text + "'";
                con.Open();
                int clasaId = (int)cmd.ExecuteScalar();
                con.Close();

                cmd.CommandText = "INSERT INTO SituatieElev(IdElev, IdClasa) Values(" + ultimulId +", " + clasaId +")";

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd.CommandText = "INSERT INTO Inmatriculari(IdElev, DataInmatriculare) Values(" + ultimulId + ", '" 
                    + dateTimePicker1.Value.ToShortDateString() + "')";

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


            }
            else if(lblMain.Text == "MODIFICARE/TRANSFER")
            {
                dateTimePicker1.Enabled = false;
                int i = dataGridView1.CurrentCell.RowIndex;

                string lastCell = dataGridView1.Rows[i].Cells[0].Value.ToString();

                int lastCellInt = int.Parse(lastCell);

                string clasa = dataGridView1.Rows[i].Cells[4].Value.ToString();

                var clasaString = clasa;

                var clasaStringCommands = clasaString.Split(new[] { ' ' }, 2);

                var clasaNr = clasaStringCommands[0];

                var clasaSimbol = clasaStringCommands[1];

                string clasaNoua;


                if (txtNume.Text == "")
                {
                    MessageBox.Show("Numele este gol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtPrenume.Text == "")
                {
                    MessageBox.Show("Prenumele este gol!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtLocalitate.Text == "")
                {
                    MessageBox.Show("Localitatea lipseste!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtAdresa.Text == "")
                {
                    MessageBox.Show("Adresa lipseste!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                con.Open();

                string listaSet =
                           "Nume = '" + txtNume.Text + "'" +
                          ", InitialaTata = '" + txtInitialaTatalui.Text + "'" +
                          ", Prenume = '" + txtPrenume.Text + "'" +
                          ", Clasa = '" + clasaNr.ToString() + " " + cmbClasaPanel.Text + "'" +
                          ", Localitate ='" + txtLocalitate.Text + "'" +
                          ", Adresa = '" + txtAdresa.Text + "'";

                lastCellInt = int.Parse(lastCell);

                cmd.CommandText = "Update Elev Set " + listaSet + " Where IdElev=" + lastCellInt;

                cmd.ExecuteNonQuery();


                con.Close();

                elevTableAdapter.Update(claseDS.Elev);

                con.Open();


                cmd.CommandText = "SELECT IdClasa FROM Clase Where DenumireClasa = '"
                    + clasaNr.ToString() + " " + cmbClasaPanel.Text + "'";
                Int32 idClasa = (Int32)cmd.ExecuteScalar();


                cmd.CommandText = "Update SituatieElev Set IdClasa = " + idClasa + " Where IdElev = " + lastCellInt;

                cmd.ExecuteNonQuery();
                

                con.Close();
            }
            else
            {
                
                con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                if(dataGridView1.Rows.Count == 1)
                {
                    lastCell = dataGridView1.Rows[0].Cells[0].Value.ToString();
                }
                else
                {
                    lastCell = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                }
              

                int lastCellInt = int.Parse(lastCell);

                cmd.CommandText = "DELETE FROM Elev Where IdElev= " + lastCellInt;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                cmd.CommandText = "DELETE FROM Notee Where IdElev= " + lastCellInt;

                elevTableAdapter.Update(claseDS.Elev);
            }
            A1(false);
            A2(false);
            elevTableAdapter.Fill(claseDS.Elev);
            RefreshChart();
           
            dataGridView1.Enabled = true;
            cbClasa.Enabled = true;

            lblMain.Text = "";
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A1(false);
            A2(false);
            lblMain.Text = "";
            dataGridView1.Enabled = true;
            cbClasa.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int i;

                i = dataGridView1.CurrentCell.RowIndex;


                txtNume.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtInitialaTatalui.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtPrenume.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                cmbClasaPanel.SelectedItem = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txtLocalitate.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txtAdresa.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
       
        }

        private void btnExmatriculare_Click(object sender, EventArgs e)
        {
            A1(true);
            lblMain.Text = "EXMATRICULARE";
            A2(true);
           
        }

        private void A1(bool v)
        {
            btnConfirmare.Enabled = v;
            btnRenuntare.Enabled = v;

            panel1.Visible = v;

            btnAdaugare.Enabled = !v;
            btnModificare.Enabled = !v;
            //btnExmatriculare.Enabled = !v;

            
        }

        private void A2(bool v)
        {

            txtNume.ReadOnly = v;
            txtInitialaTatalui.ReadOnly = v;
            txtPrenume.ReadOnly = v;
            txtAdresa.ReadOnly = v;
            txtLocalitate.ReadOnly = v;

            cmbClasaPanel.Enabled = !v;
        }

        private void A3(bool v)
        {
            cmbClasaPanel.Items.Clear();
            if (v)
            {
      
                cmd.CommandText = "Select DenumireClasa From Clase ";


                con.Open();

                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    cmbClasaPanel.Items.Add(r.GetString(0));
                }
                con.Close();
            }
            else
            {
                cmbClasaPanel.Items.Add("A");
                cmbClasaPanel.Items.Add("B");
                cmbClasaPanel.Items.Add("C");
            }
        }

    }

}
