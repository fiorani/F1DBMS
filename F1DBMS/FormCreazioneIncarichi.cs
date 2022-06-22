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
    public partial class FormCreazioneIncarichi : Form
    {
        private readonly DataClassesF1DataContext db;
        private int rigaTabellaDipendente = -1;
        private int rigaTabellaTeam = -1;

        public FormCreazioneIncarichi(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            SelezionaDipPerIncarico.DataSource = from dip in db.dipendentis 
                                                 select dip;
            SelezionaTeamPerInc.DataSource = from team in db.teams
                                             select team;
        }

        private void SottoscriviIncaricoBtn_Click(object sender, EventArgs e)
        {
            if(rigaTabellaDipendente >= 0 && rigaTabellaTeam >= 0 && !StipendioBox.Text.Equals(String.Empty) && RuoloComboBox.SelectedItem != null)
            {
                incarichi_dipendenti newIncarico = new incarichi_dipendenti();
                newIncarico.CF = SelezionaDipPerIncarico.Rows[rigaTabellaDipendente].Cells["CF"].Value.ToString();
                newIncarico.IDTeam = SelezionaTeamPerInc.Rows[rigaTabellaTeam].Cells["IDTeam"].Value.ToString();
                newIncarico.dataAssunzione = dataInizioIncarico.Value.Date;
                newIncarico.Ruolo = RuoloComboBox.SelectedItem.ToString();
                newIncarico.stipendio = StipendioBox.Text;
                newIncarico.dataLicenziamento = null;
                try
                {
                    /* mancano i controlli LINQ sull'overlap di date */
                    db.incarichi_dipendentis.InsertOnSubmit(newIncarico);
                    db.SubmitChanges();
                    MessageBox.Show("Incarico sottoscritto!");
                    this.Close();
                } catch (Exception)
                {
                    MessageBox.Show("Ricontrolla Campi!");
                }
            } else
            {
                MessageBox.Show("Ricontrolla Campi!");
            }
        }

        private void SelezionaDipPerIncarico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaTabellaDipendente = e.RowIndex;
        }

        private void SelezionaTeamPerInc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaTabellaTeam = e.RowIndex;
        }
    }
}
