using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1DBMS
{
    public partial class FormInserimentoVettura : Form
    {
        private readonly DataClassesF1DataContext db;
        private int _RigaGridTeam;
        public FormInserimentoVettura(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            gridTeamVettura.DataSource = from t in db.teams
                                         select t;
            _RigaGridTeam = -1;
        }

        private void gridTeamVettura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _RigaGridTeam = e.RowIndex;
        }

        private void FineRegistraAutoBtn_Click(object sender, EventArgs e)
        {
            if(_RigaGridTeam >= 0 && !vettureIdVettura.Text.Equals(String.Empty) && !vettureanno.Text.Equals(String.Empty) && !vetturenome.Text.Equals(String.Empty))
            {
                
                var nuovaVettura = new vetture();
                nuovaVettura.IDTeam = gridTeamVettura.Rows[_RigaGridTeam].Cells["IDTeam"].Value.ToString();
                nuovaVettura.IDVettura = vettureIdVettura.Text;
                nuovaVettura.nome = vetturenome.Text;
                nuovaVettura.annoProduzione = Convert.ToInt32(vettureanno.Text);
                try
                {
                    db.vettures.InsertOnSubmit(nuovaVettura);
                    db.SubmitChanges();
                    MessageBox.Show("Vettura registrata correttamente!");
                    this.Close();
                    new FormInserimentoComponentiVettura(db, nuovaVettura.IDVettura).Show();
                } catch(Exception)
                {
                    MessageBox.Show("ATTENZIONE, ricontrolla di aver inserito i dati correttamente!");
                }
            } else
            {
                MessageBox.Show("ATTENZIONE, ricontrolla di aver inserito i dati correttamente! " + _RigaGridTeam + ", " + vettureIdVettura.Text + ", " + vettureanno.Text + ", " + vetturenome.Text);
            }
        }
    }
}
