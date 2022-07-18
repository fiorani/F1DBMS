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
    public partial class FormPartecipazioniCampionati : Form
    {
        private readonly DataClassesF1DataContext db;
        private int pilGridIndex;
        private int vetGridIndex;
        private int campGridIndex;
        public FormPartecipazioniCampionati(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            pilGridIndex = -1;
            vetGridIndex = -1;
            campGridIndex = -1;
            PilotaGrid.DataSource = from p in db.pilotis
                                    select p;
            VetturaGrid.DataSource = from v in db.vettures
                                     select v;
            CampionatoGrid.DataSource = from c in db.campionatis
                                        select c;
        }

        private void PilotaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pilGridIndex = e.RowIndex;
        }

        private void VetturaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vetGridIndex = e.RowIndex;
        }

        private void CampionatoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            campGridIndex = e.RowIndex;
        }

        private void regPilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var newPart = new partecipazioni_piloti();
                if(pilGridIndex == -1 || vetGridIndex == -1 || campGridIndex == -1)
                {
                    throw new AccessViolationException();
                }
                var pilRow = PilotaGrid.Rows[pilGridIndex];
                var vetRow = VetturaGrid.Rows[vetGridIndex];
                var campRow = CampionatoGrid.Rows[campGridIndex];
                newPart.CF = pilRow.Cells["CF"].Value.ToString();
                newPart.IDVettura = vetRow.Cells["IDVettura"].Value.ToString();
                newPart.IDCampionato = campRow.Cells["IDCampionato"].Value.ToString();
                newPart.numeroDiGara = Convert.ToInt32(numPilBox.Text);
                
                var team = from t in db.teams
                           where t.vettures.Any(v => v.IDVettura == newPart.IDVettura && v.annoProduzione == Convert.ToInt32(campRow.Cells["anno"].Value))
                           select t;

                var incarico = from i in db.incarichi_pilotis
                               where i.CF == newPart.CF && i.IDTeam == team.First().IDTeam && i.dataAssunzione.Year <= Convert.ToInt32(campRow.Cells["anno"].Value) && (!i.dataLicenziamento.HasValue || i.dataLicenziamento.GetValueOrDefault().Year >= Convert.ToInt32(campRow.Cells["anno"].Value))
                               select i;

                if (incarico.Any())
                {
                    db.partecipazioni_pilotis.InsertOnSubmit(newPart);
                    db.SubmitChanges();
                    MessageBox.Show("Registrazione avvenuta con successo!");
                    this.Close();
                } else
                {
                    throw new Exception();
                }
            } catch (Exception)
            {
                MessageBox.Show("Errore! Ricontrolla i dati!!");
            }                  
        }
    }
}
