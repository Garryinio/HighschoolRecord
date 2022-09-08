using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ProiectMPP
{
    public partial class Note : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader r;

        private string lastCell;
        public Note()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'noteDS1.Notee' table. You can move, or remove it, as needed.
            this.noteeTableAdapter.Fill(this.noteDS1.Notee);
            // TODO: This line of code loads data into the 'noteDS.Note' table. You can move, or remove it, as needed.
            this.noteeTableAdapter.Fill(this.noteDS.Notee);
            // TODO: This line of code loads data into the 'noteDS.Elev' table. You can move, or remove it, as needed.
            this.elevTableAdapter.Fill(this.noteDS.Elev);
            // TODO: This line of code loads data into the 'noteDS.Note' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'noteDS.Note' table. You can move, or remove it, as needed.
            this.noteeTableAdapter.Fill(this.noteDS.Notee);
            // TODO: This line of code loads data into the 'noteDS.Elev' table. You can move, or remove it, as needed.
            this.elevTableAdapter.Fill(this.noteDS.Elev);

            this.dataGridView1.Sort(this.dataGridView1.Columns["Nume"], ListSortDirection.Ascending);

            lastCell = dataGridView1.Rows[0].Cells[0].Value.ToString();

            noteeBindingSource.Filter = "IdElev = " + lastCell;

            A3();

        }

        private void cbClasa_ValueMemberChanged(object sender, EventArgs e)
        {

            string clasaAleasa = cbClasa.Text;

            elevBindingSource.Filter = "Clasa = " + "'" + clasaAleasa + "'";

            this.dataGridView1.Sort(this.dataGridView1.Columns["Nume"], ListSortDirection.Ascending);

            dataGridView1.Focus();


  
            if (dataGridView1.Rows.Count > 0)
            {
                lastCell = dataGridView1.Rows[0].Cells[0].Value.ToString();
                noteeBindingSource.Filter = "IdElev = " + lastCell;

            }


        }

        private void elevBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            noteeTableAdapter.Fill(noteDS1.Notee);
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    lastCell = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                noteeBindingSource.Filter = "IdElev = " + lastCell;

            }
           
        }

        private void A1(bool v)
        {
            btnAdaugareNote.Enabled = !v;
            btnMedie.Enabled = !v;

            LblMaterie.Visible = v;
            cmbMaterie.Visible = v;

            LblNota.Visible = v;
            cmbNota.Visible = v;

            btnConfirmare.Visible = v;
            btnRenuntare.Visible = v;

        }

        private void btnModificareNote_Click(object sender, EventArgs e)
        {
            A1(true);
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {

            if(cmbMaterie.SelectedIndex == -1)
            {
                MessageBox.Show("Materia nu a fost selectata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbNota.SelectedIndex == -1)
            {
                MessageBox.Show("Nota nu a fost selectata!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string materie = cmbMaterie.Text;
            string nota = cmbNota.Text;

            con.ConnectionString = noteeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            //cmd.CommandText = "Insert into Note (" + materie + ")" + " Values (" + "'" + nota + "'" + ")" + " WHERE idElev =" + lastCell;
            cmd.CommandText = "SELECT 1 FROM Notee WHERE IdElev =" + lastCell;
            con.Open();
            var reader = cmd.ExecuteReader();
           
            if (!reader.Read()) 
            {
                con.Close();
                cmd.CommandText = " Insert INTO Notee (IdElev ," + materie  + ") Values(" + lastCell + "," + "'" + nota + "'" + ")";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                con.Close();
                cmd.CommandText = "Select " + materie + " From Notee Where IdElev = " + lastCell;
                con.Open();
                var reader2 = cmd.ExecuteScalar();
                string readerValue = Convert.ToString(reader2);

                if (!readerValue.Equals(""))
                {
                    
                    con.Close();
                    con.Open();
                    cmd.CommandText = "UPDATE Notee SET " + materie + "= " +"'"+ readerValue + ", " + nota + "'" + " WHERE idElev =" + lastCell;
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd.CommandText = "UPDATE Notee SET " + materie + "= " + "'" + nota + "'" + " WHERE idElev =" + lastCell;

                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            con.Close();

            noteeTableAdapter.Fill(noteDS1.Notee);
            noteeBindingSource.Filter = "IdElev = " + lastCell;

            A1(false);

            
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A1(false);
        }

        private void btnMedie_Click(object sender, EventArgs e)
        {
            A1(false);

             
           DialogResult dR = MessageBox.Show("Doriti un raport despre situatia scoala al elevului?", "Medie",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR == DialogResult.Yes)
            {
                RaportMedieForm f = new RaportMedieForm(this);
                f.ShowDialog();
            }
        }

        public string GetLastCell()
        {
            return lastCell;
        }

        private void A3()
        {

            con.ConnectionString = noteeTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;


            cmd.CommandText = "Select DenumireClasa From Clase ";


            con.Open();

            r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbClasa.Items.Add(r.GetString(0));
            }
            con.Close();
        
        }
    }
}
