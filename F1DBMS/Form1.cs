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
    public partial class Form1 : Form
    {
        private readonly DataClassesF1DataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new DataClassesF1DataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newTeam = new team();
            newTeam.IDTeam = IDTeam.Text;
            newTeam.nome = NomeTeam.Text;
            newTeam.sedeCentrale = SedeCentrale.Text;
            newTeam.dataEsordio = DataEsordio.Value.Date;
            var recapitoTeam = new recapiti_team();
            recapitoTeam.IDTeam = newTeam.IDTeam;
            recapitoTeam.Telefono = Recapito1.Text;
            newTeam.recapiti_teams.Add(recapitoTeam);
            var mailTeam = new mail_team();
            mailTeam.IDTeam = newTeam.IDTeam;
            mailTeam.Mail = Mail1.Text;            
            try
            {
                db.teams.InsertOnSubmit(newTeam);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                SedeCentrale.Clear();
                NomeTeam.Clear();
                Recapito1.Clear();
                Mail1.Clear();
                IDTeam.Clear();
            } catch (Exception)
            {
                MessageBox.Show("Errore: Ricontrolla i campi!!!");
            }
            
        }

        private void showTeams_Click(object sender, EventArgs e)
        {
            var res = from t in db.teams
                      select t;
            gridTeam.DataSource = res;
        }

        private void BottoneRicercaPerID_Click(object sender, EventArgs e)
        {
            var res = from t in db.teams
                      where t.IDTeam.Equals(RicercaTeamPerID.Text)
                      select t;
            gridTeam.DataSource = res;
            RicercaTeamPerID.Clear();
        }

        private void RicercaTeamPerNomeBtn_Click(object sender, EventArgs e)
        {
            var res = from t in db.teams
                      where t.nome.Equals(RicercaTeamPerNomeBox.Text)
                      select t;
            gridTeam.DataSource = res;
            RicercaTeamPerNomeBox.Clear();
        }

        private void EliminaTeamBtn_Click(object sender, EventArgs e)
        {
            var teams = db.teams.Where(t => t.IDTeam.Equals(EliminaTeamBox.Text));
            var recapiti = db.recapiti_teams.Where(r => r.IDTeam.Equals(EliminaTeamBox.Text));
            if(teams.Any())
            {
                if (recapiti.Any())
                {
                    db.recapiti_teams.DeleteAllOnSubmit(recapiti);
                }
                db.teams.DeleteAllOnSubmit(teams);
                db.SubmitChanges();
                MessageBox.Show("Team eliminato correttamente!");
            }
            EliminaTeamBox.Clear();
        }

        private void RegistraDipendente_Click(object sender, EventArgs e)
        {
            var dipendente = new dipendenti();
            dipendente.CF = CFBox.Text;
            dipendente.nome = NomeBox.Text;
            dipendente.cognome = CognomeBox.Text;
            dipendente.luogoDiNascita = LuogoNascita.Text;
            dipendente.dataNascita = DataNascita.Value;
            dipendente.residenza = ResidenzaBox.Text;
            var recapito = new recapiti_dipendenti();
            recapito.CF = CFBox.Text;
            recapito.Telefono = Tel1.Text;
            dipendente.recapiti_dipendentis.Add(recapito);
            if (Tel2.Text.Any())
            {
                var recapito2 = new recapiti_dipendenti();
                recapito2.CF = CFBox.Text;
                recapito2.Telefono = Tel2.Text;
                dipendente.recapiti_dipendentis.Add(recapito2);
            }
            try
            {
                db.dipendentis.InsertOnSubmit(dipendente);
                db.SubmitChanges();
                MessageBox.Show("Dipendente inserito!");
                CFBox.Clear();
                NomeBox.Clear();
                CognomeBox.Clear();
                ResidenzaBox.Clear();
                Tel1.Clear();
                Tel2.Clear();
            } catch(Exception)
            {
                MessageBox.Show("Errore: controlla campi!");
            }
        }

        private void MostraDipendenti_Click(object sender, EventArgs e)
        {
            var res = from d in db.dipendentis
                      select d;
            gridDipendenti.DataSource = res;
        }
    }
}
