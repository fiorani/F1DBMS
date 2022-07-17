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
                    throw new Exception();
                }
                var pilRow = PilotaGrid.Rows[pilGridIndex];
                var vetRow = VetturaGrid.Rows[vetGridIndex];
                var campRow = CampionatoGrid.Rows[campGridIndex];
                newPart.CF = pilRow.Cells["CF"].Value.ToString();
                newPart.IDVettura = vetRow.Cells["IDVettura"].Value.ToString();
                newPart.IDCampionato = campRow.Cells["IDCampionato"].Value.ToString();
                newPart.numeroDiGara = Convert.ToInt32(numPilBox.Text);
                if((from v in db.vettures
                   where v.IDVettura == newPart.IDVettura
                   select v.annoProduzione) == (from c in db.campionatis
                                  where c.IDCampionato == newPart.IDCampionato
                                  select c.anno))
                {

                }
            } catch (Exception)
            {
                MessageBox.Show("Errore! Ricontrolla i dati!!");
            }                  
        }
    }
}
