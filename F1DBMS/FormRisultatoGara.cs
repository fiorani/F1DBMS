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
    public partial class FormRisultatoGara : Form
    {
        private DataClassesF1DataContext db;
        private int pilGridIndex;
        private int garGridIndex;
        private int campGridIndex;

        public FormRisultatoGara(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            pilGridIndex = -1;
            garGridIndex = -1;
            campGridIndex = -1;
            pilotaGrid.DataSource = from p in db.pilotis
                                    select p;
            garaGrid.DataSource = from g in db.gares
                                    select g;
            CampionatoGrid.DataSource = from c in db.campionatis
                                        select c;
        }

        private void numPilBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newPart = new classifiche_piloti();
                if (pilGridIndex == -1 || garGridIndex == -1 || campGridIndex == -1)
                {
                    throw new Exception();
                }
                var pilRow = pilotaGrid.Rows[pilGridIndex];
                var garRow = garaGrid.Rows[garGridIndex];
                var campRow = CampionatoGrid.Rows[campGridIndex];
                newPart.CF = pilRow.Cells["CF"].Value.ToString();
                newPart.IDCircuito = garRow.Cells["IDCircuito"].Value.ToString();
                newPart.IDCampionato = campRow.Cells["IDCampionato"].Value.ToString();
                newPart.posizione = risPilBox.Text;
                var query =
                    from p in db.partecipazioni_pilotis
                    where p.CF == newPart.CF
                    select p;
                foreach (partecipazioni_piloti p in query)
                {
                    newPart.IDVettura=p.IDVettura;
                }

                if (risPilBox.Text.Equals('1'))
                {
                    var queryp =
                    from p in db.pilotis
                    where p.CF == newPart.CF
                    select p;
                    foreach (piloti p in queryp)
                    {
                        p.gareVinte++;
                    }
                    var queryv =
                    from v in db.vettures
                    where v.IDVettura==newPart.IDVettura
                    select v;
                    foreach (vetture v in queryv)
                    {
                        var queryt =
                        from t in db.teams
                        where t.IDTeam == v.IDTeam
                        select t;
                        foreach (team t in queryt)
                        {
                            t.gareVinte++;
                        }
                    }
                }

                /* aggiorno i punti attuali*/
                (from p in db.partecipazioni_pilotis
                 where p.CF == newPart.CF
                 select p).ToList().ForEach(p => p.puntiAttuali = this.getPoints(newPart.posizione));


                db.classifiche_pilotis.InsertOnSubmit(newPart);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Errore! Ricontrolla i dati!!");
            }
        }

        private void CampionatoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            campGridIndex = e.RowIndex;
        }

        private void garaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            garGridIndex = e.RowIndex;
        }

        private void pilotaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pilGridIndex = e.RowIndex;
        }
    
        private int getPoints(string result)
        {
            switch (result)
            {
                case "1": return 30;
                case "2": return 25;    
                case "3": return 20;
                case "4": return 15;
                case "5": return 10;
                case "6": return 5;
                case "7": return 4;
                case "8": return 3;
                case "9": return 2;
                default: return 1;
            }
        }
    }


}
