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
            gridSelezionaPilIncarico.DataSource = db.pilotis;
            gridTeamIncaricoPil.DataSource = db.teams;
        }

        private void SottoscriviIncPilBtn_Click(object sender, EventArgs e)
        {
            if(rigaGridPilota >= 0 && rigaGridTeam >= 0 && !StipendioPilBox.Equals(String.Empty))
            {
                var incaricoPil = new incarichi_piloti();
                incaricoPil.CF = gridSelezionaPilIncarico.Rows[rigaGridPilota].Cells["CF"].Value.ToString();
                incaricoPil.IDTeam = gridTeamIncaricoPil.Rows[rigaGridTeam].Cells["IDTeam"].Value.ToString();
                incaricoPil.dataAssunzione = dataInizioIncaricoPil.Value.Date;
                incaricoPil.stipendio = StipendioPilBox.Text;
                incaricoPil.dataLicenziamento = null;
                try
                {
                    db.incarichi_pilotis.InsertOnSubmit(incaricoPil);
                    db.SubmitChanges();
                    MessageBox.Show("Incarico sottoscritto!");
                    this.Close();
                } catch(Exception)
                {
                    MessageBox.Show("Ricontrolla Campi!");
                }
            }  else
            {
                MessageBox.Show("Ricontrolla Campi!");
            }
        }

        private void gridSelezionaPilIncarico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaGridPilota = e.RowIndex;
        }

        private void gridTeamIncaricoPil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaGridTeam = e.RowIndex;
        }
    }
}
