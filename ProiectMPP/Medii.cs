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

namespace ProiectMPP
{
    public partial class Medii : Form
    {
        private string lastCell;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader r;
        public Medii()
        {
            InitializeComponent();
        }

        private void Medii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'noteDS.Notee' table. You can move, or remove it, as needed.
            this.noteeTableAdapter.Fill(this.noteDS.Notee);
            // TODO: This line of code loads data into the 'noteDS.Elev' table. You can move, or remove it, as needed.
            this.elevTableAdapter.Fill(this.noteDS.Elev);

            dataGridView1.Focus();

            this.dataGridView1.Sort(this.dataGridView1.Columns["Nume"], ListSortDirection.Ascending);
            if (dataGridView1.Rows.Count > 0)
            {
                lastCell = dataGridView1.Rows[0].Cells[0].Value.ToString();

                noteeBindingSource.Filter = "IdElev = " + lastCell;
                if(dataGridView2.Rows.Count > 0)
                {
                    CalculMedie();
                }
                
            }
            A3();
     
        }

        private void elevBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            noteeTableAdapter.Fill(noteDS.Notee);
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    lastCell = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                noteeBindingSource.Filter = "IdElev = " + lastCell;

            }
            if(dataGridView2.Rows.Count > 0)
            {
                CalculMedie();
            }
            

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

        private void CalculMedie()
        {
            for (int i = 1; i < dataGridView2.Columns.Count - 1; i++)
            {
                string note = dataGridView2.Rows[0].Cells[i].Value.ToString();
                int nrNote = 0;
                int numar = 0;
                bool eGol = false;

                if (note == "")
                {
                    eGol = true;
                }

                for (int j = 0; j < note.Length; j++)
                {

                    if (Char.IsDigit(note[j]))
                    {

                        if (note[j] == '1' && note[j + 1] == '0')
                        {
                            char[] zece = { note[j], note[j + 1] };
                            string zecE = new string(zece);

                            numar += int.Parse(zecE);
                            nrNote++;
                            j++;
                        }
                        else
                        {
                            numar += int.Parse(note[j].ToString());
                            nrNote++;
                        }
                    }

                }
                if (eGol)
                {
                    dataGridView2.Rows[0].Cells[i].Value = "";
                }
                else
                {
                    dataGridView2.Rows[0].Cells[i].Value = numar / nrNote;
                }


            }
            
        }
        private void A3()
        {

            con.ConnectionString = elevTableAdapter.Connection.ConnectionString;
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
