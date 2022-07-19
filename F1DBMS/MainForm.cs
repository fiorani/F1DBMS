using System;
using System.Data;
using System.Linq;
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
            gridTeam.DataSource = from team in db.teams
                                  select team;
            gridDipendenti.DataSource = from dip in db.dipendentis
                                        select dip;
            GridIncarichiDip.DataSource = from incDip in db.incarichi_dipendentis
                                          select incDip;
            gridPiloti.DataSource = from pil in db.pilotis
                                    select pil;
            gridIncarichiPiloti.DataSource = from incPil in db.incarichi_pilotis
                                             select incPil;
            vettureGriglia.DataSource = from vet in db.vettures
                                        select vet;
            componentiGriglia.DataSource = from comp in db.componentis
                                           select comp;
            campionatiGriglia.DataSource = from camp in db.campionatis
                                           select camp;
            sponsorGriglia.DataSource = from spons in db.sponsors
                                        select spons;
            contrattiGriglia.DataSource = from contr in db.contrattis
                                          select contr;
            garaGriglia.DataSource = from gare in db.gares
                                     select gare;
            grigliaCircuito.DataSource = from circ in db.circuitis
                                         select circ;
            RegistrazioniGrid.DataSource = from part in db.partecipazioni_pilotis
                                           select part;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newTeam = new team();
                newTeam.IDTeam = Utilities.assignValue(IDTeam);
                newTeam.nome = Utilities.assignValue(NomeTeam);
                newTeam.sedeCentrale = Utilities.assignValue(SedeCentrale);
                newTeam.dataEsordio = DataEsordio.Value.Date;
                var recapitoTeam = new recapiti_team();
                recapitoTeam.IDTeam = newTeam.IDTeam;
                recapitoTeam.Telefono = Utilities.assignValue(Recapito1);
                newTeam.recapiti_teams.Add(recapitoTeam);
                var mailTeam = new mail_team();
                mailTeam.IDTeam = newTeam.IDTeam;
                mailTeam.Mail = Utilities.assignValue(Mail1);

                db.teams.InsertOnSubmit(newTeam);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                SedeCentrale.Clear();
                NomeTeam.Clear();
                Recapito1.Clear();
                Mail1.Clear();
                IDTeam.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore: Ricontrolla i campi!!!");
            }

        }

        private void showTeams_Click(object sender, EventArgs e)
        {
            gridTeam.DataSource = from t in db.teams
                                  select new { t.IDTeam, t.nome, t.sedeCentrale, t.dataEsordio, t.recapiti_teams, t.mail_teams, t.gareVinte, t.campionatiVinti };
        }

        private void BottoneRicercaPerID_Click(object sender, EventArgs e)
        {
            gridTeam.DataSource = from t in db.teams
                                  where t.IDTeam.Equals(RicercaTeamPerID.Text)
                                  select t;
            RicercaTeamPerID.Clear();
        }

        private void RicercaTeamPerNomeBtn_Click(object sender, EventArgs e)
        {
            gridTeam.DataSource = from t in db.teams
                                  where t.nome.Equals(RicercaTeamPerNomeBox.Text)
                                  select t;
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
                if (mails.Any())
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
            try
            {
                var dipendente = new dipendenti();
                dipendente.CF = Utilities.assignValue(CFBox);
                dipendente.nome = Utilities.assignValue(NomeBox);
                dipendente.cognome = Utilities.assignValue(CognomeBox);
                dipendente.luogoDiNascita = Utilities.assignValue(LuogoNascitaBox);
                dipendente.dataNascita = DataNascita.Value;
                dipendente.residenza = Utilities.assignValue(ResidenzaBox);
                var recapito = new recapiti_dipendenti();
                recapito.CF = Utilities.assignValue(CFBox);
                recapito.Telefono = Utilities.assignValue(Tel1);
                dipendente.recapiti_dipendentis.Add(recapito);
                if (Tel2.Text.Any())
                {
                    var recapito2 = new recapiti_dipendenti();
                    recapito2.CF = Utilities.assignValue(CFBox);
                    recapito2.Telefono = Tel2.Text;
                    dipendente.recapiti_dipendentis.Add(recapito2);
                }
                db.dipendentis.InsertOnSubmit(dipendente);
                db.SubmitChanges();
                MessageBox.Show("Dipendente inserito!");
                CFBox.Clear();
                NomeBox.Clear();
                CognomeBox.Clear();
                ResidenzaBox.Clear();
                LuogoNascitaBox.Clear();
                Tel1.Clear();
                Tel2.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore: controlla campi!");
            }
        }

        private void MostraDipendenti_Click(object sender, EventArgs e)
        {
            gridDipendenti.DataSource = from d in db.dipendentis
                                        select d;
        }

        private void RicercaDipCFBtn_Click(object sender, EventArgs e)
        {
            gridDipendenti.DataSource = db.dipendentis.Where(d => d.CF.Equals(BoxRicercaDipendenteCF.Text));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            gridDipendenti.DataSource = db.dipendentis.Where(d => d.nome.Equals(RicercaDipNomeBox.Text) && d.cognome.Equals(RicercaDipCognomeBox.Text));
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
            new FormCreazioneIncarichi(db).Show();
        }

        private void MostraIncarichiDip_Click(object sender, EventArgs e)
        {
            GridIncarichiDip.DataSource = db.incarichi_dipendentis;
        }

        private void RevocaIncaricoBtn_Click(object sender, EventArgs e)
        {
            new FormRevocaIncarico(db).Show();
        }

        private void MostraIncBtn_Click(object sender, EventArgs e)
        {
            gridDipendenti.DataSource = from inc in db.incarichi_dipendentis
                                        where inc.CF.Equals(CFCercaIncDipBox.Text)
                                        select inc;
        }

        private void regPilotaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var pilota = new piloti();
                pilota.CF = Utilities.assignValue(CFPilotaBox);
                pilota.nome = Utilities.assignValue(NomePilotaBox);
                pilota.cognome = Utilities.assignValue(CognomePilotaBox);
                pilota.luogoDiNascita = Utilities.assignValue(LuogoNascitaPilotaBox);
                pilota.dataDiNascita = dataNascitaPilota.Value;
                pilota.residenza = Utilities.assignValue(ResidenzaPilotaBox);
                var recapito = new recapiti_piloti();
                recapito.CF = Utilities.assignValue(CFPilotaBox);
                recapito.Telefono = Utilities.assignValue(Tel1PilotaBox);
                pilota.recapiti_pilotis.Add(recapito);
                if (Tel2.Text.Any())
                {
                    var recapito2 = new recapiti_piloti();
                    recapito2.CF = Utilities.assignValue(CFPilotaBox);
                    recapito2.Telefono = Tel2PilotaBox.Text;
                    pilota.recapiti_pilotis.Add(recapito2);
                }
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
            catch (Exception)
            {
                MessageBox.Show("Errore: controlla campi!");
            }
        }

        private void MostraPilotiBtn_Click(object sender, EventArgs e)
        {
            gridPiloti.DataSource = from p in db.pilotis
                                    select p;
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
            new FormCreazioneIncaichiPiloti(db).Show();
        }



        private void IncarichiPilBtn_Click(object sender, EventArgs e)
        {
            var res = from incPil in db.incarichi_pilotis
                      select incPil;
            gridIncarichiPiloti.DataSource = res;

        }
        private void RevocaIncaricoPilBtn_Click(object sender, EventArgs e)
        {
            new FormRevocaIncarichiPiloti(db).Show();
        }
        private void registraCircuito_Click(object sender, EventArgs e)
        {
            try
            {
                var newCircuiti = new circuiti();
                newCircuiti.IDCircuito = Utilities.assignValue(idCircuitoCircuito);
                newCircuiti.nome = Utilities.assignValue(nomeCircuito);
                newCircuiti.stato = Utilities.assignValue(statoCircuito);
                newCircuiti.descrizione = Utilities.assignValue(descrizioneCircuito);
                newCircuiti.lunghezza = Convert.ToInt32(lunghezzaCircuito.Text);
                newCircuiti.tipologia = Utilities.assignValue(tipologiaCircuito);
                newCircuiti.numeroCurve = Convert.ToInt32(numDiCurveCircuito.Text);

                db.circuitis.InsertOnSubmit(newCircuiti);
                db.SubmitChanges();
                MessageBox.Show("Circuito registrato con successo!");
                var res = from t in db.circuitis
                          select new { t.IDCircuito, t.nome, t.stato, t.descrizione, t.lunghezza, t.tipologia, t.numeroCurve };
                grigliaCircuito.DataSource = res;
                idCircuitoCircuito.Clear();
                nomeCircuito.Clear();
                statoCircuito.Clear();
                descrizioneCircuito.Clear();
                lunghezzaCircuito.Clear();
                tipologiaCircuito.Clear();
                numDiCurveCircuito.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i Dati!!!");
            }
        }

        private void tastoRicercaNomeCircuito_Click(object sender, EventArgs e)
        {
            grigliaCircuito.DataSource = from t in db.circuitis
                                         where t.nome.Equals(ricercaNomeCircuito.Text)
                                         select t;
        }

        private void tastoRicercaStatoCircuito_Click(object sender, EventArgs e)
        {
            grigliaCircuito.DataSource = from t in db.circuitis
                                         where t.nome.Equals(ricercaStatoCircuito.Text)
                                         select t;
        }

        private void gararegistra_Click(object sender, EventArgs e)
        {
            new FormInserimentoGara(db).Show();
            garaGriglia.DataSource = from g in db.gares
                                     select g;
        }

        private void garaTastoRicercaData_Click(object sender, EventArgs e)
        {
            garaGriglia.DataSource = from t in db.gares
                                     where t.data.Equals(dataGara.Value.Date)
                                     select t;
        }

        private void garaTastoRicercaIdCampionato_Click(object sender, EventArgs e)
        {
            garaGriglia.DataSource = from t in db.gares
                                     where t.IDCampionato.Equals(garaRicercaIdCampionato.Text)
                                     select t;
        }

        private void garaTastoRicercaIdCircuito_Click(object sender, EventArgs e)
        {
            garaGriglia.DataSource = from t in db.gares
                                     where t.IDCircuito.Equals(garaRicercaIdCircuito.Text)
                                     select t;
        }

        private void contrattiRegistra_Click(object sender, EventArgs e)
        {
            try
            {
                var newContratti = new contratti();
                newContratti.IDSponsor = Utilities.assignValue(contrattiIdSponsor);
                newContratti.IDTeam = Utilities.assignValue(contrattiIdTeam);
                newContratti.budget = Convert.ToInt32(contrattiBudget);
                newContratti.dataInizio = contrattiData.Value.Date;

                db.contrattis.InsertOnSubmit(newContratti);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                contrattiGriglia.DataSource = from t in db.contrattis
                                              select new { t.IDSponsor, t.IDTeam, t.budget, t.dataInizio };
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void contrattiTastoRicercaIdTeam_Click(object sender, EventArgs e)
        {
            contrattiGriglia.DataSource = from t in db.contrattis
                                          where t.IDTeam.Equals(contrattiRicercaIdTeam.Text)
                                          select t;
        }

        private void contrattiTastoRicercaIdSponsor_Click(object sender, EventArgs e)
        {
            contrattiGriglia.DataSource = from t in db.contrattis
                                          where t.IDSponsor.Equals(contrattiRicercaIdSponsor.Text)
                                          select t;
        }

        private void sponsorRegistra_Click(object sender, EventArgs e)
        {
            try
            {
                var newSponsor = new sponsor();
                newSponsor.IDSponsor = Utilities.assignValue(sponsorIdSponsor);
                newSponsor.Nome = Utilities.assignValue(sponsorNome);
                newSponsor.Stato = Utilities.assignValue(sponsorStato);
                var recapitoSponsor = new recapiti_sponsor();
                recapitoSponsor.IDSponsor = newSponsor.IDSponsor;
                recapitoSponsor.Telefono = Utilities.assignValue(sponsorTelefono);
                newSponsor.recapiti_sponsors.Add(recapitoSponsor);
                var mailSponsor = new mail_sponsor();
                mailSponsor.IDSponsor = newSponsor.IDSponsor;
                mailSponsor.Mail = Utilities.assignValue(sponsorMail);

                db.sponsors.InsertOnSubmit(newSponsor);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                sponsorGriglia.DataSource = from t in db.sponsors
                                            select new { t.IDSponsor, t.Nome, t.Stato, t.recapiti_sponsors, t.mail_sponsors };
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void sponsorTastoRicercaIdSponsor_Click(object sender, EventArgs e)
        {
            sponsorGriglia.DataSource = from t in db.sponsors
                                        where t.IDSponsor.Equals(sponsorRicercaIdSponsor.Text)
                                        select t;
        }

        private void sponsorTastoRicercaNome_Click(object sender, EventArgs e)
        {
            sponsorGriglia.DataSource = from t in db.sponsors
                                        where t.Nome.Equals(sponsorRicercaNome.Text)
                                        select t;
        }

        private void campionatiRegistra_Click(object sender, EventArgs e)
        {
            try
            {
                var newCampionati = new campionati();
                newCampionati.IDCampionato = Utilities.assignValue(campionatoIdCampionato);
                newCampionati.anno = Convert.ToInt32(campionatiAnno.Text);
                newCampionati.nome = Utilities.assignValue(campionatiNome);
                newCampionati.descrizione = Utilities.assignValue(campionatiDescrizione);
                db.campionatis.InsertOnSubmit(newCampionati);
                db.SubmitChanges();
                MessageBox.Show("Campionato registrato con successo!");
                campionatiGriglia.DataSource = from t in db.campionatis
                                               select new { t.IDCampionato, t.anno, t.nome, t.descrizione };
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void campionatiTastoRicercaId_Click(object sender, EventArgs e)
        {
            campionatiGriglia.DataSource = from t in db.campionatis
                                           where t.IDCampionato.Equals(campionatiRicercaIdCampionato.Text)
                                           select t;
        }

        private void campionatiTastoRicercaAnno_Click(object sender, EventArgs e)
        {
            campionatiGriglia.DataSource = from t in db.campionatis
                                           where t.anno.Equals(campionatiRicercaAnno.Text)
                                           select t;
        }

        private void componentiRegistra_Click(object sender, EventArgs e)
        {
            try
            {
                var newComponenti = new componenti();
                newComponenti.IDComponente = Utilities.assignValue(componentiIdComponente);
                newComponenti.Descrizione = Utilities.assignValue(componenteDescrizione);
                newComponenti.PrezzoUnitario = Utilities.assignValue(componentePrezzo);
                db.componentis.InsertOnSubmit(newComponenti);
                db.SubmitChanges();
                MessageBox.Show("Team registrato con successo!");
                componentiGriglia.DataSource = from t in db.componentis
                                               select new { t.IDComponente, t.Descrizione, t.PrezzoUnitario };
            }
            catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }

        private void componenteRicercaIdVettura_Click(object sender, EventArgs e)
        {
            componentiGriglia.DataSource = from t in db.componentis
                                           where t.IDComponente.Equals(componenteRicercaIdComponente.Text)
                                           select t;
        }

        private void vettureRegistra_Click(object sender, EventArgs e)
        {
            new FormInserimentoVettura(db).Show();
        }

        private void vettureTastoRicercaIdVettura_Click(object sender, EventArgs e)
        {
            vettureGriglia.DataSource = from t in db.vettures
                                        where t.IDVettura.Equals(vetturericercaIdVettura.Text)
                                        select t;
        }

        private void vettureTastoRicercaIdTeam_Click(object sender, EventArgs e)
        {
            vettureGriglia.DataSource = from t in db.vettures
                                        where t.IDTeam.Equals(vettureRicercaIdteam.Text)
                                        select t;
        }

        private void vetturaTastoRicercaAnno_Click(object sender, EventArgs e)
        {
            vettureGriglia.DataSource = from t in db.vettures
                                        where t.annoProduzione.Equals(vettureRicercaAnno.Text)
                                        select t;
        }

        private void vettureTastoRicercaNome_Click(object sender, EventArgs e)
        {
            vettureGriglia.DataSource = from t in db.vettures
                                        where t.nome.Equals(VettureRicercaNome.Text)
                                        select t;
        }

        private void ricercaCFBtn_Click(object sender, EventArgs e)
        {
            RegistrazioniGrid.DataSource = from t in db.partecipazioni_pilotis
                                           where t.CF.Equals(CFBox.Text)
                                           select t;
        }

        private void IDCampBtn_Click(object sender, EventArgs e)
        {
            RegistrazioniGrid.DataSource = from t in db.partecipazioni_pilotis
                                           where t.IDCampionato.Equals(IDCampionatoBox.Text)
                                           select t;
        }

        private void registraPilBtn_Click(object sender, EventArgs e)
        {
            new FormPartecipazioniCampionati(db).Show();
        }

<<<<<<< HEAD
        private void risulltatoPilBtn_Click(object sender, EventArgs e)
        {
            new FormRisultatoGara(db).Show();
=======
        private void CompBtn_Click(object sender, EventArgs e)
        {
            vettureGriglia.DataSource = from c in db.composizionis
                                        where c.IDVettura.Equals(IDVetCompBox.Text)
                                        select c.componenti;
        }

        private void classificaCampBtn_Click(object sender, EventArgs e)
        {
            campionatiGriglia.DataSource = from part in db.partecipazioni_pilotis
                                           where part.IDCampionato.Equals(IDCampEsitoBox.Text)
                                           orderby part.puntiAttuali descending
                                           select new {part.IDCampionato, part.CF, part.IDVettura, part.numeroDiGara, part.puntiAttuali};
>>>>>>> f26798c74a22a6643a428e8e6ace1d3976a2b1f2
        }
    }
}