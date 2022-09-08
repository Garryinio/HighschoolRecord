using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectMPP
{
    public partial class RaportMedieForm : Form
    {
        Note n = null;

        public RaportMedieForm(Note n)
        {
            InitializeComponent();
            this.n = n;
           
        }

        private void RaportMedieForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NoteDS.Notee' table. You can move, or remove it, as needed.
            this.NoteeTableAdapter.Fill(this.NoteDS.Notee);

            int idElevInt = int.Parse(this.n.GetLastCell());

            NoteeBindingSource.Filter = "IdElev = " + idElevInt;

            this.reportViewer1.RefreshReport();

            

        }
    }
}
