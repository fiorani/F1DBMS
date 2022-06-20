﻿using System;
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
    public partial class MainForm : Form
    {
        private readonly DataClassesF1DataContext db;
        public MainForm()
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
                if(!IDTeam.Text.Equals(String.Empty) && !NomeTeam.Text.Equals(String.Empty) && !SedeCentrale.Text.Equals(String.Empty) && !Recapito1.Text.Equals(String.Empty) && !Mail1.Text.Equals(String.Empty))
                {
                    db.teams.InsertOnSubmit(newTeam);
                    db.SubmitChanges();
                    MessageBox.Show("Team registrato con successo!");
                    SedeCentrale.Clear();
                    NomeTeam.Clear();
                    Recapito1.Clear();
                    Mail1.Clear();
                    IDTeam.Clear();
                } else
                {
                    MessageBox.Show("Errore: Ricontrolla i campi!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore: Ricontrolla i campi!!!");
            }

        }

        private void showTeams_Click(object sender, EventArgs e)
        {
            var res = from t in db.teams
                      select new { t.IDTeam, t.nome, t.sedeCentrale, t.dataEsordio, t.recapiti_teams, t.mail_teams, t.gareVinte, t.campionatiVinti };
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
            var mails = db.mail_teams.Where(r => r.IDTeam.Equals(EliminaTeamBox.Text));
            if (teams.Any())
            {
                if (recapiti.Any())
                {
                    db.recapiti_teams.DeleteAllOnSubmit(recapiti);
                }
                if(mails.Any())
                {
                    db.mail_teams.DeleteAllOnSubmit(mails);
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
                if (!CFBox.Text.Equals(String.Empty) && !NomeBox.Text.Equals(String.Empty) && !CognomeBox.Text.Equals(String.Empty) && !LuogoNascita.Text.Equals(String.Empty) && !ResidenzaBox.Text.Equals(String.Empty) && !Tel1.Text.Equals(String.Empty))
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
                } else
                {
                    MessageBox.Show("Errore: controlla campi!");
                }
            }
            catch (Exception)
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

        private void RicercaDipCFBtn_Click(object sender, EventArgs e)
        {
            var res = db.dipendentis.Where(d => d.CF.Equals(BoxRicercaDipendenteCF.Text));
            gridDipendenti.DataSource = res;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var res = db.dipendentis.Where(d => d.nome.Equals(RicercaDipNomeBox.Text) && d.cognome.Equals(RicercaDipCognomeBox.Text));
            gridDipendenti.DataSource = res;
        }

        private void EliminaDipBtn_Click(object sender, EventArgs e)
        {
            var dip = db.dipendentis.Where(d => d.CF.Equals(EliminaDipBox.Text));
            var recapiti = db.recapiti_dipendentis.Where(r => r.CF.Equals(EliminaDipBox.Text));
            if (dip.Any())
            {
                if (recapiti.Any())
                {
                    db.recapiti_dipendentis.DeleteAllOnSubmit(recapiti);
                }
                db.dipendentis.DeleteAllOnSubmit(dip);
                db.SubmitChanges();
                MessageBox.Show("Dipendente eliminato correttamente!");
            }
            EliminaTeamBox.Clear();
        }

        private void AggiungiIncaricoBtn_Click(object sender, EventArgs e)
        {
            FormCreazioneIncarichi formIncarichi = new FormCreazioneIncarichi(db);
            formIncarichi.Show();
        }

        private void MostraIncarichiDip_Click(object sender, EventArgs e)
        {
            IncarichiGridView.DataSource = db.incarichi_dipendentis;
        }
    }
}