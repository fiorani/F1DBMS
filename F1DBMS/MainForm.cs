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
    public partial class MainForm : Form
    {
        private readonly DataClassesF1DataContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new DataClassesF1DataContext();
            gridTeam.DataSource = db.teams;
            gridDipendenti.DataSource = db.dipendentis;
            GridIncarichiDip.DataSource = db.incarichi_dipendentis;
            gridPiloti.DataSource = db.pilotis;
            gridIncarichiPiloti.DataSource = db.incarichi_pilotis;
            vettureGriglia.DataSource = db.vettures;
            componentiGriglia.DataSource = db.componentis;
            campionatiGriglia.DataSource = db.campionatis;
            sponsorGriglia.DataSource = db.sponsors;
            contrattiGriglia.DataSource = db.contrattis;
            garaGriglia.DataSource = db.gares;
            grigliaCircuito.DataSource = db.circuitis;

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
            EliminaDipBox.Clear();
        }

        private void AggiungiIncaricoBtn_Click(object sender, EventArgs e)
        {
            FormCreazioneIncarichi formIncarichi = new FormCreazioneIncarichi(db);
            formIncarichi.Show();
        }

        private void MostraIncarichiDip_Click(object sender, EventArgs e)
        {
            GridIncarichiDip.DataSource = db.incarichi_dipendentis;
        }

        private void RevocaIncaricoBtn_Click(object sender, EventArgs e)
        {
            FormRevocaIncarico formRevoca = new FormRevocaIncarico(db);
            formRevoca.Show();
        }

        private void MostraIncBtn_Click(object sender, EventArgs e)
        {
            var incarichiDip = from inc in db.incarichi_dipendentis
                      where inc.CF.Equals(CFCercaIncDipBox.Text)
                      select inc;
            gridDipendenti.DataSource = incarichiDip;
        }

        private void regPilotaBtn_Click(object sender, EventArgs e)
        {
            var pilota = new piloti();
            pilota.CF = CFPilotaBox.Text;
            pilota.nome = NomePilotaBox.Text;
            pilota.cognome = CognomePilotaBox.Text;
            pilota.luogoDiNascita = LuogoNascitaPilotaBox.Text;
            pilota.dataDiNascita = dataNascitaPilota.Value;
            pilota.residenza = ResidenzaPilotaBox.Text;
            var recapito = new recapiti_piloti();
            recapito.CF = CFPilotaBox.Text;
            recapito.Telefono = Tel1PilotaBox.Text;
            pilota.recapiti_pilotis.Add(recapito);
            if (Tel2.Text.Any())
            {
                var recapito2 = new recapiti_piloti();
                recapito2.CF = CFPilotaBox.Text;
                recapito2.Telefono = Tel2PilotaBox.Text;
                pilota.recapiti_pilotis.Add(recapito2);
            }
            try
            {
                if (!CFPilotaBox.Text.Equals(String.Empty) && !NomePilotaBox.Text.Equals(String.Empty) && !CognomePilotaBox.Text.Equals(String.Empty) && !LuogoNascitaPilotaBox.Text.Equals(String.Empty) && !ResidenzaPilotaBox.Text.Equals(String.Empty) && !Tel1PilotaBox.Text.Equals(String.Empty))
                {
                    db.pilotis.InsertOnSubmit(pilota);
                    db.SubmitChanges();
                    MessageBox.Show("Pilota inserito!");
                    CFPilotaBox.Clear();
                    NomePilotaBox.Clear();
                    CognomePilotaBox.Clear();
                    ResidenzaPilotaBox.Clear();
                    Tel1PilotaBox.Clear();
                    Tel2PilotaBox.Clear();
                }
                else
                {
                    MessageBox.Show("Errore: controlla campi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errore: controlla campi!");
            }
        }

        private void MostraPilotiBtn_Click(object sender, EventArgs e)
        {
            var res = from p in db.pilotis
                      select p;
            gridPiloti.DataSource = res;
        }

        private void ricercaPilCFBtn_Click(object sender, EventArgs e)
        {
            gridPiloti.DataSource = db.pilotis.Where(p => p.CF.Equals(RicercaPilCFBox.Text));
        }

        private void RicercaPilNomeCognomeBtn_Click(object sender, EventArgs e)
        {
            gridPiloti.DataSource = db.pilotis.Where(p => p.nome.Equals(ricercaPilNomeBox.Text) && p.cognome.Equals(RicercaPilCognomeBox.Text));
        }

        private void EliminaPilotaBtn_Click(object sender, EventArgs e)
        {
            var pil = db.pilotis.Where(p => p.CF.Equals(EliminaPilCFBox.Text));
            var recapiti = db.recapiti_pilotis.Where(r => r.CF.Equals(EliminaPilCFBox.Text));
            if (pil.Any())
            {
                if (recapiti.Any())
                {
                    db.recapiti_pilotis.DeleteAllOnSubmit(recapiti);
                }
                db.pilotis.DeleteAllOnSubmit(pil);
                db.SubmitChanges();
                MessageBox.Show("Pilota eliminato correttamente!");
            } 
            EliminaPilCFBox.Clear();
        }

        private void RicercaIncarichiPilBtn_Click(object sender, EventArgs e)
        {
            gridPiloti.DataSource = db.incarichi_pilotis.Where(inc => inc.CF.Equals(RicercaIncarichiPilBox.Text));
        }

        private void InserisciIncaricoPilBtn_Click(object sender, EventArgs e)
        {
            FormCreazioneIncaichiPiloti creaIncaricoPil = new FormCreazioneIncaichiPiloti(db);
            creaIncaricoPil.Show();
        }



        private void IncarichiPilBtn_Click(object sender, EventArgs e)
        {
            var res = from incPil in db.incarichi_pilotis
                      select incPil;
            gridIncarichiPiloti.DataSource = res;

        }
        private void RevocaIncaricoPilBtn_Click(object sender, EventArgs e)
        {
            FormRevocaIncarichiPiloti revocaIncPil = new FormRevocaIncarichiPiloti(db);
            revocaIncPil.Show();
        }
        private void registraCircuito_Click(object sender, EventArgs e)
        {
            var newCircuiti = new circuiti();
            newCircuiti.IDCircuito = idCircuitoCircuito.Text;
            newCircuiti.nome = nomeCircuito.Text;
            newCircuiti.stato = statoCircuito.Text;
            newCircuiti.descrizione = descrizioneCircuito.Text;
            newCircuiti.lunghezza = Convert.ToInt32(lunghezzaCircuito);
            newCircuiti.tipologia = tipologiaCircuito.Text;
            newCircuiti.numeroCurve = Convert.ToInt32(numDiCurveCircuito);

            try
            {
                db.circuitis.InsertOnSubmit(newCircuiti);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                var res = from t in db.circuitis
                          select new { t.IDCircuito, t.nome, t.stato, t.descrizione, t.lunghezza, t.tipologia, t.numeroCurve };
                grigliaCircuito.DataSource = res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void tastoRicercaNomeCircuito_Click(object sender, EventArgs e)
        {
            var res = from t in db.circuitis
                      where t.nome.Equals(ricercaNomeCircuito.Text)
                      select t;
            grigliaCircuito.DataSource = res;
        }

        private void tastoRicercaStatoCircuito_Click(object sender, EventArgs e)
        {
            var res = from t in db.circuitis
                      where t.nome.Equals(ricercaStatoCircuito.Text)
                      select t;
            grigliaCircuito.DataSource = res;
        }

        private void gararegistra_Click(object sender, EventArgs e)
        {
            var newGare = new gare();
            newGare.IDCircuito = garaIdCircuito.Text;
            newGare.IDCampionato = garaIdCampionato.Text;
            newGare.data = garaData.Value.Date;
            newGare.giri = Convert.ToInt32(garaGiri);

            try
            {
                db.gares.InsertOnSubmit(newGare);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                var res = from t in db.gares
                          select new { t.IDCircuito, t.IDCampionato, t.data, t.giri };
                garaGriglia.DataSource = res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void garaTastoRicercaData_Click(object sender, EventArgs e)
        {

            var res = from t in db.gares
                      where t.data.Equals(garaRicercaData.Text)
                      select t;
            garaGriglia.DataSource = res;
        }

        private void garaTastoRicercaIdCampionato_Click(object sender, EventArgs e)
        {

            var res = from t in db.gares
                      where t.IDCampionato.Equals(garaRicercaIdCampionato.Text)
                      select t;
            garaGriglia.DataSource = res;
        }

        private void garaTastoRicercaIdCircuito_Click(object sender, EventArgs e)
        {

            var res = from t in db.gares
                      where t.IDCircuito.Equals(garaRicercaIdCircuito.Text)
                      select t;
            garaGriglia.DataSource = res;
        }

        private void contrattiRegistra_Click(object sender, EventArgs e)
        {
            var newContratti = new contratti();
            newContratti.IDSponsor = contrattiIdSponsor.Text;
            newContratti.IDTeam = contrattiIdTeam.Text;
            newContratti.budget = Convert.ToInt32(contrattiBudget);
            newContratti.dataInizio = contrattiData.Value.Date;

            try
            {
                db.contrattis.InsertOnSubmit(newContratti);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                var res = from t in db.contrattis
                          select new { t.IDSponsor, t.IDTeam, t.budget, t.dataInizio };
                contrattiGriglia.DataSource = res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void contrattiTastoRicercaIdTeam_Click(object sender, EventArgs e)
        {

            var res = from t in db.contrattis
                      where t.IDTeam.Equals(contrattiRicercaIdTeam.Text)
                      select t;
            contrattiGriglia.DataSource = res;
        }

        private void contrattiTastoRicercaIdSponsor_Click(object sender, EventArgs e)
        {

            var res = from t in db.contrattis
                      where t.IDSponsor.Equals(contrattiRicercaIdSponsor.Text)
                      select t;
            contrattiGriglia.DataSource = res;
        }

        private void sponsorRegistra_Click(object sender, EventArgs e)
        {
            var newSponsor = new sponsor();
            newSponsor.IDSponsor = sponsorIdSponsor.Text;
            newSponsor.Nome = sponsorNome.Text;
            newSponsor.Stato = sponsorStato.Text;
            var recapitoSponsor = new recapiti_sponsor();
            recapitoSponsor.IDSponsor = newSponsor.IDSponsor;
            recapitoSponsor.Telefono = sponsorTelefono.Text;
            newSponsor.recapiti_sponsors.Add(recapitoSponsor);
            var mailSponsor = new mail_sponsor();
            mailSponsor.IDSponsor = newSponsor.IDSponsor;
            mailSponsor.Mail = sponsorMail.Text;

            try
            {
                db.sponsors.InsertOnSubmit(newSponsor);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                var res = from t in db.sponsors
                          select new { t.IDSponsor, t.Nome, t.Stato, t.recapiti_sponsors, t.mail_sponsors };
                sponsorGriglia.DataSource = res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void sponsorTastoRicercaIdSponsor_Click(object sender, EventArgs e)
        {

            var res = from t in db.sponsors
                      where t.IDSponsor.Equals(sponsorRicercaIdSponsor.Text)
                      select t;
            sponsorGriglia.DataSource = res;
        }

        private void sponsorTastoRicercaNome_Click(object sender, EventArgs e)
        {

            var res = from t in db.sponsors
                      where t.Nome.Equals(sponsorRicercaNome.Text)
                      select t;
            sponsorGriglia.DataSource = res;
        }

        private void campionatiRegistra_Click(object sender, EventArgs e)
        {
            var newCampionati = new campionati();
            newCampionati.IDCampionato = campionatoIdCampionato.Text;
            newCampionati.anno = Convert.ToInt32(campionatiAnno);
            newCampionati.nome = campionatiNome.Text;
            newCampionati.descrizione = campionatiDescrizione.Text;

            try
            {
                db.campionatis.InsertOnSubmit(newCampionati);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                var res = from t in db.campionatis
                          select new { t.IDCampionato, t.anno, t.nome, t.descrizione };
                campionatiGriglia.DataSource = res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void campionatiTastoRicercaId_Click(object sender, EventArgs e)
        {

            var res = from t in db.campionatis
                      where t.IDCampionato.Equals(campionatiRicercaIdCampionato.Text)
                      select t;
            campionatiGriglia.DataSource = res;
        }

        private void campionatiTastoRicercaAnno_Click(object sender, EventArgs e)
        {
            var res = from t in db.campionatis
                      where t.anno.Equals(campionatiRicercaAnno.Text)
                      select t;
            campionatiGriglia.DataSource = res;
        }

        private void componentiRegistra_Click(object sender, EventArgs e)
        {
            var newComponenti = new componenti();
            newComponenti.IDComponente = componentiIdComponente.Text;
            newComponenti.Descrizione = componenteDescrizione.Text;
            newComponenti.PrezzoUnitario = componentePrezzo.Text;

            try
            {
                db.componentis.InsertOnSubmit(newComponenti);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                var res = from t in db.componentis
                          select new { t.IDComponente, t.Descrizione, t.PrezzoUnitario };
                componentiGriglia.DataSource = res;
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void componenteRicercaIdVettura_Click(object sender, EventArgs e)
        {

            var res = from t in db.componentis
                      where t.IDComponente.Equals(componenteRicercaIdComponente.Text)
                      select t;
            componentiGriglia.DataSource = res;
        }

        private void vettureRegistra_Click(object sender, EventArgs e)
        {
            new FormInserimentoVettura(db).Show();
        }

        private void vettureTastoRicercaIdVettura_Click(object sender, EventArgs e)
        {

            var res = from t in db.vettures
                      where t.IDVettura.Equals(vetturericercaIdVettura.Text)
                      select t;
            vettureGriglia.DataSource = res;
        }

        private void vettureTastoRicercaIdTeam_Click(object sender, EventArgs e)
        {

            var res = from t in db.vettures
                      where t.IDTeam.Equals(vettureRicercaIdteam.Text)
                      select t;
            vettureGriglia.DataSource = res;
        }

        private void vetturaTastoRicercaAnno_Click(object sender, EventArgs e)
        {

            var res = from t in db.vettures
                      where t.annoProduzione.Equals(vettureRicercaAnno.Text)
                      select t;
            vettureGriglia.DataSource = res;
        }

        private void vettureTastoRicercaNome_Click(object sender, EventArgs e)
        {

            var res = from t in db.vettures
                      where t.nome.Equals(VettureRicercaNome.Text)
                      select t;
            vettureGriglia.DataSource = res;
        }


    }
}