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
    public partial class FormRicercaEsitoGara : Form
    {
        private readonly DataClassesF1DataContext db;
        
        public FormRicercaEsitoGara(DataClassesF1DataContext db)
        {
            InitializeComponent();
            this.db = db;
            CampionatoGrid.DataSource = from camp in db.campionatis
                                        select camp;
        }

        private void CampionatoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campionato = CampionatoGrid.Rows[e.RowIndex];
            GaraGrid.DataSource = from gare in db.gares
                                  where gare.IDCampionato.Equals(campionato.Cells["IDCampionato"].Value)
                                  select gare;
        }

        private void GaraGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gara = GaraGrid.Rows[e.RowIndex];
            EsitoGrid.DataSource = from esiti in db.classifiche_pilotis
                                   orderby esiti.posizione descending
                                   where esiti.gare.IDCampionato.Equals(gara.Cells["IDCampionato"].Value) && esiti.gare.IDCircuito.Equals(gara.Cells["IDCircuito"].Value)
                                   select esiti;
        }



    }
}
