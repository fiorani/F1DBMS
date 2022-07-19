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
    public partial class FormCreazioneIncaichiPiloti : Form
    {
        private readonly DataClassesF1DataContext db;
        private int rigaGridPilota = -1;
        private int rigaGridTeam = -1;
        public FormCreazioneIncaichiPiloti(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            gridSelezionaPilIncarico.DataSource = from pil in db.pilotis
                                                  select pil;
            gridTeamIncaricoPil.DataSource = from team in db.teams
                                             select team;
        }
        private void SottoscriviIncPilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (rigaGridPilota < 0 || rigaGridTeam < 0 || StipendioPilBox.Equals(String.Empty))
                {
                    throw new Exception();
                }
                var incaricoPil = new incarichi_piloti();
                incaricoPil.CF = gridSelezionaPilIncarico.Rows[rigaGridPilota].Cells["CF"].Value.ToString();
                incaricoPil.IDTeam = gridTeamIncaricoPil.Rows[rigaGridTeam].Cells["IDTeam"].Value.ToString();
                incaricoPil.dataAssunzione = dataInizioIncaricoPil.Value.Date;
                incaricoPil.stipendio = Utilities.assignValue(StipendioPilBox);
                incaricoPil.dataLicenziamento = null;
                
                if(db.incarichi_pilotis.Any(pil => (pil.CF.Equals(incaricoPil.CF) && !pil.dataLicenziamento.HasValue) || (pil.CF.Equals(incaricoPil.CF) && pil.dataLicenziamento.HasValue && pil.dataLicenziamento.Value.CompareTo(incaricoPil.dataAssunzione) < 0)))
                {
                    throw new Exception();
                }
                db.incarichi_pilotis.InsertOnSubmit(incaricoPil);
                db.SubmitChanges();
                MessageBox.Show("Incarico sottoscritto!");
                this.Close();
            } catch(Exception)
            {
                MessageBox.Show("Ricontrolla Campi!");
            }
        }
        private void gridSelezionaPilIncarico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaGridPilota = e.RowIndex;
        }
        private void gridTeamIncaricoPil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaGridTeam = e.RowIndex;
        }
    }
}
