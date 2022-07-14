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
    public partial class FormInserimentoGara : Form
    {
        private const int kmGara = 308;
        private readonly DataClassesF1DataContext db;
        private int campionatoGridIndex;
        private int circuitoGridIndex;


        public FormInserimentoGara(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            tabCampionati.DataSource = from camp in db.campionatis
                                       select camp;
            tabCircuiti.DataSource = from circ in db.circuitis
                                     select circ;
            campionatoGridIndex = -1;
            circuitoGridIndex = -1;
        }

        private void tabCampionati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            campionatoGridIndex = e.RowIndex;
        }

        private void tabCircuiti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            circuitoGridIndex = e.RowIndex;
        }

        private void registraGaraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var newGara = new gare();
                if(campionatoGridIndex >= 0 && circuitoGridIndex >= 0 && dataGara.Value.Year == Int32.Parse(tabCampionati.Rows[campionatoGridIndex].Cells["Anno"].Value.ToString()))
                {
                    newGara.IDCampionato = tabCampionati.Rows[campionatoGridIndex].Cells["IDCampionato"].Value.ToString();
                    newGara.IDCircuito = tabCircuiti.Rows[circuitoGridIndex].Cells["IDCircuito"].Value.ToString();
                    newGara.data = dataGara.Value.Date;
                    newGara.giri = kmGara / Int32.Parse(tabCircuiti.Rows[circuitoGridIndex].Cells["Lunghezza"].Value.ToString());
                    db.gares.InsertOnSubmit(newGara);
                    db.SubmitChanges();
                    MessageBox.Show("Gara inserita correttamente");
                    this.Close();
                } else
                {
                    throw new Exception();
                }

            } catch (Exception)
            {
                MessageBox.Show("Ricontrolla i campi!!!");
            }
        }
    }
}
