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
        private int rigaGridTeam;
        private int rigaGridComponente;
        public FormInserimentoVettura(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            gridTeamVettura.DataSource = from t in db.teams
                                         select t;
            gridComponenteAuto.DataSource = from c in db.componentis
                                            select c;
            rigaGridTeam = -1;
            rigaGridComponente = -1;
        }

        private void gridTeamVettura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaGridTeam = e.RowIndex;
        }

        private void gridComponenteAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaGridComponente = e.RowIndex;
        }

        private void AggiungiComponenteBtn_Click(object sender, EventArgs e)
        {
            if(qtaComponente.Value > 0 && rigaGridComponente >= 0 && !vettureIdVettura.Text.Equals(String.Empty))
            {
                var composizione = new composizioni();
                composizione.IDComponente = gridComponenteAuto.Rows[rigaGridComponente].Cells["IDComponente"].Value.ToString();
                composizione.IDVettura = vettureIdVettura.Text;
                composizione.Quantita = ((int)qtaComponente.Value);
                try
                {
                    db.composizionis.InsertOnSubmit(composizione);
                    db.SubmitChanges();
                    /* aggiorno l'indice di riga per poter registrare altri pezzi */
                    rigaGridComponente = -1;
                    MessageBox.Show("Composizione registrata,\n terminare registrazione vettura o aggiungere nuovo componente!");
                } catch(Exception ex)
                {
                    Exception ex2 = ex;
                    while (ex2.InnerException != null)
                    {
                        ex2 = ex2.InnerException;
                    }
                    Console.WriteLine(ex.InnerException);
                    throw;

                    //MessageBox.Show("ATTENZIONE, ricontrolla di aver selezionato il componente e l'id della vettura!");
                }
            } else
            {
                Console.WriteLine("qta = " + qtaComponente.Value + ", rigaGridComp = " + rigaGridComponente + ", IDVettura = " + vettureIdVettura.Text + ", rigaGridTeam = " + rigaGridTeam);
                MessageBox.Show("ATTENZIONE, ricontrolla di aver selezionato il componente e l'id della vettura!");
            }
        }

        private void FineRegistraAutoBtn_Click(object sender, EventArgs e)
        {
            if(rigaGridTeam >= 0 && !vettureIdVettura.Text.Equals(String.Empty) && !vettureanno.Text.Equals(String.Empty) && !vetturenome.Text.Equals(String.Empty))
            {
                /* controllo che sia stato registrato almeno un componente per quella vettura */
                if(db.composizionis.Where(comp => comp.IDVettura.Equals(vettureIdVettura.Text)).Any())
                {
                    var nuovaVettura = new vetture();
                    nuovaVettura.IDTeam = gridTeamVettura.Rows[rigaGridTeam].Cells["IDTeam"].Value.ToString();
                    nuovaVettura.IDVettura = vettureIdVettura.Text;
                    nuovaVettura.nome = vetturenome.Text;
                    nuovaVettura.annoProduzione = Convert.ToInt32(vettureanno.Text);
                    try
                    {
                        db.vettures.InsertOnSubmit(nuovaVettura);
                        db.SubmitChanges();
                        MessageBox.Show("Vettura registrata correttamente!");
                        this.Close();
                    } catch(Exception)
                    {
                        MessageBox.Show("ATTENZIONE, ricontrolla di aver inserito i dati correttamente!");
                    }

                } else
                {
                    MessageBox.Show("ATTENZIONE, prima occorre aggiungere almeno un componente!");
                }
            }
            MessageBox.Show("ATTENZIONE, ricontrolla di aver inserito i dati correttamente!");
        }
    }
}
