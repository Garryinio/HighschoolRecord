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
    public partial class lblData : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader r;
        public lblData()
        {
            InitializeComponent();
        }

        private void Exmatriculare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exmatriculariDS.Exmatriculari' table. You can move, or remove it, as needed.
            this.exmatriculariTableAdapter.Fill(this.exmatriculariDS.Exmatriculari);
            // TODO: This line of code loads data into the 'exmatriculariDS.Exmatriculari' table. You can move, or remove it, as needed.
            this.exmatriculariTableAdapter.Fill(this.exmatriculariDS.Exmatriculari);
            // TODO: This line of code loads data into the 'claseDS.Elev' table. You can move, or remove it, as needed.
            this.elevTableAdapter.Fill(this.claseDS.Elev);
            // TODO: This line of code loads data into the 'exmatriculariDS.Exmatriculari' table. You can move, or remove it, as needed.
            this.exmatriculariTableAdapter.Fill(this.exmatriculariDS.Exmatriculari);

            this.dataGridView2.Sort(this.dataGridView2
             .Columns["Nume"], ListSortDirection.Ascending);
            A3();

        }

        private void A1(bool v)
        {
            btnConfirmare.Enabled = v;
            btnRenuntare.Enabled = v;

            dateTimePicker1.Visible = v;
            label3.Visible = v;
            lblMotiv.Visible = v;
            txtMotiv.Visible = v;

            btnPromovare.Enabled = !v;
            btnExmatriculare.Enabled = !v;
            dataGridView1.Visible = !v;
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
        private void btnExmatriculare_Click(object sender, EventArgs e)
        {
            A1(true);
            lblMain.Text = "EXMATRICULARE";
            txtMotiv.Enabled = true;

        }

        private void btnPromovare_Click(object sender, EventArgs e)
        {
            A1(true);
            lblMain.Text = "PROMOVARE";

            txtMotiv.Text = "Promovare";
            txtMotiv.Enabled = false;

        }

        private void cbClasa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dataGridView2.Enabled)
            {
                string clasaAleasa = cbClasa.Text;

                elevBindingSource.Filter = "Clasa = " + "'" + clasaAleasa + "'";

                this.dataGridView2.Sort(this.dataGridView2.Columns["Nume"], ListSortDirection.Ascending);

                dataGridView2.Focus();
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A1(false);
            lblMain.Text = "";
            txtMotiv.Enabled = true;
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
          
            if(lblMain.Text == "EXMATRICULARE")
            {
                if(txtMotiv.Text == "")
                {
                    MessageBox.Show("Motivul nu a fost adaugat!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int i = dataGridView2.CurrentCell.RowIndex;

                string lastCell = dataGridView2.Rows[i].Cells[0].Value.ToString();

                int lastCellInt = int.Parse(lastCell);

                con.ConnectionString = exmatriculariTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;
                string listaCampuri = "IdElev, NumeComplet, Motiv, DataExm";
                string listaValori =
                           lastCellInt + ", '" + dataGridView2.Rows[i].Cells[1].Value.ToString() 
                        + " " + dataGridView2.Rows[i].Cells[2].Value.ToString()
                        + ". " + dataGridView2.Rows[i].Cells[3].Value.ToString() +"'"  +
                        " ,'" + txtMotiv.Text + "'" +
                         " , '" + dateTimePicker1.Value.ToShortDateString() + "'";

                cmd.CommandText = "Insert into Exmatriculari(" + listaCampuri + ") " +
                  "Values " + "(" + listaValori + ")";
                MessageBox.Show(cmd.CommandText);
                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;

                    con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;



                    cmd.CommandText = "DELETE FROM Elev Where IdElev= " + lastCellInt;



                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    cmd.CommandText = "DELETE FROM Notee Where IdElev= " + lastCellInt;

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                 

                    elevTableAdapter.Fill(claseDS.Elev);

                    exmatriculariTableAdapter.Fill(exmatriculariDS.Exmatriculari);
              


            }
            else
            {

                int i = dataGridView2.CurrentCell.RowIndex;

                string lastCell = dataGridView2.Rows[i].Cells[0].Value.ToString();

                int lastCellInt = int.Parse(lastCell);

                string clasa = dataGridView2.Rows[i].Cells[4].Value.ToString();

                var clasaString = clasa;

                var clasaStringCommands = clasaString.Split(new[] { ' ' }, 2);

                var clasaNr = clasaStringCommands[0];

                var clasaSimbol = clasaStringCommands[1];

                string clasaNoua;

                SituatieScoalara(lastCellInt);

                con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;

                cmd.CommandText = "Select IdClasa From Clase Where DenumireClasa = " + "'" + clasa + "'";
                con.Open();
                int clasaId = (int)cmd.ExecuteScalar() + 3;
                con.Close();

                cmd.CommandText = "Update SituatieElev Set IdClasa = " + clasaId  + " Where IdElev=" + lastCellInt;

                elevTableAdapter.Update(claseDS.Elev);


                con.Open();


                cmd.ExecuteNonQuery();

                con.Close();

                con.Close();

                cmd.CommandText = "DELETE FROM Notee Where IdElev= " + lastCellInt;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                if (clasaNr.ToString() == "IX")
                {
                    clasaNoua = "X ";
                    clasaNoua += clasaSimbol.ToString();


                    con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;


                    cmd.CommandText = "Update Elev Set Clasa = " + "'"+  clasaNoua + "'" + " Where IdElev=" + lastCellInt;

                    elevTableAdapter.Update(claseDS.Elev);

                    

                    con.Open();


                    cmd.ExecuteNonQuery();

                    con.Close();
                    cmd.CommandText = "Update SituatieElev Set IdClasa = " + clasaId  + " Where IdElev=" + lastCellInt;

                    elevTableAdapter.Update(claseDS.Elev);


                    con.Open();


                    cmd.ExecuteNonQuery();

                    con.Close();

                }
                else if(clasaNr.ToString() == "X")
                {
                    clasaNoua = "XI ";
                    clasaNoua += clasaSimbol.ToString();


                    con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;


                    cmd.CommandText = "Update Elev Set Clasa = " + "'" + clasaNoua + "'" + " Where IdElev=" + lastCellInt;

                    elevTableAdapter.Update(claseDS.Elev);



                    con.Open();


                    cmd.ExecuteNonQuery();

                    con.Close();
                    cmd.CommandText = "Update SituatieElev Set IdClasa = " + clasaId  + " Where IdElev=" + lastCellInt;

                    elevTableAdapter.Update(claseDS.Elev);


                    con.Open();


                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                else if(clasaNr.ToString() == "XI")
                {
                    clasaNoua = "XII ";
                    clasaNoua += clasaSimbol.ToString();


                    con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;


                    cmd.CommandText = "Update Elev Set Clasa = " + "'" + clasaNoua + "'" + " Where IdElev=" + lastCellInt;

                    elevTableAdapter.Update(claseDS.Elev);



                    con.Open();


                    cmd.ExecuteNonQuery();

                    con.Close();
                    cmd.CommandText = "Update SituatieElev Set IdClasa = " + clasaId  + " Where IdElev=" + lastCellInt;

                    elevTableAdapter.Update(claseDS.Elev);


                    con.Open();


                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                else
                {

                    con.ConnectionString = exmatriculariTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;
                    string listaCampuri = "IdElev, NumeComplet, Motiv, DataExm";
                    string listaValori =
                               lastCellInt + ", '" + dataGridView2.Rows[i].Cells[1].Value.ToString()
                            + " " + dataGridView2.Rows[i].Cells[2].Value.ToString()
                            + ". " + dataGridView2.Rows[i].Cells[3].Value.ToString() + "'" +
                            " ,'" + txtMotiv.Text + "'" +
                             " , '" + dateTimePicker1.Value.ToShortDateString() + "'";

                    cmd.CommandText = "Insert into Exmatriculari(" + listaCampuri + ") " +
                      "Values " + "(" + listaValori + ")";
       
                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;

                    con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

                    cmd.Connection = con;

                    cmd.CommandText = "DELETE FROM Elev Where IdElev= " + lastCellInt;

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    cmd.CommandText = "DELETE FROM Notee Where IdElev= " + lastCellInt;

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    cmd.CommandText = "DELETE FROM SituatieElev Where IdElev= " + lastCellInt;

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    elevTableAdapter.Fill(claseDS.Elev);

                    exmatriculariTableAdapter.Fill(exmatriculariDS.Exmatriculari);

                }

            }
            elevTableAdapter.Update(claseDS.Elev);
            elevTableAdapter.Fill(claseDS.Elev);
            A1(false);
            lblMain.Text = "";
            txtMotiv.Enabled = true;

        }

        private void SituatieScoalara(int lastCell)
        {
            con.ConnectionString = elevTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select * from Notee Where IdElev = " + lastCell;

            con.Open();

            
            r = cmd.ExecuteReader();
            r.Read();
            for(int i = 1;i <= 11; i++)
            {
                if (r[i].ToString() == "")
                {
                    MessageBox.Show("Elevul respectiv nu are situatia incheiata!"
                        , "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (r[i].ToString().Length < 4)
                {
                    MessageBox.Show("Elevul respectiv nu are numarul de note suficente!"
                    , "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            con.Close();
           

        }
        private void CbItems()
        {

        }
    }
}
