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
    public partial class FormRevocaIncarichiPiloti : Form
    {
        private readonly DataClassesF1DataContext db;
        private int tabellaIncarichiPilIndex;
        public FormRevocaIncarichiPiloti(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            gridIncaricoPilRevoca.DataSource = from incPil in db.incarichi_pilotis
                            select incPil;
            tabellaIncarichiPilIndex = -1;
        }

        private void revocaIncPilBtn_Click(object sender, EventArgs e)
        {
            if(tabellaIncarichiPilIndex >= 0)
            {
                var incarico = (from incPil in db.incarichi_pilotis
                                where incPil.CF.Equals(gridIncaricoPilRevoca.Rows[tabellaIncarichiPilIndex].Cells["CF"].Value)
                                && incPil.dataAssunzione.Equals(gridIncaricoPilRevoca.Rows[tabellaIncarichiPilIndex].Cells["DataAssunzione"].Value)
                                && !incPil.dataLicenziamento.HasValue
                                && incPil.dataAssunzione <= DataLicenziamentoPilota.Value.Date
                                select incPil).SingleOrDefault();
                if(incarico != null)
                {
                    incarico.dataLicenziamento = DataLicenziamentoPilota.Value.Date;
                    db.SubmitChanges();
                    MessageBox.Show("Incarico revocato!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Errore: ricontrolla la selezione o la data!");
                }
            } else
            {
                MessageBox.Show("Errore: ricontrolla la selezione o la data!");
            }
        }

        private void gridIncaricoPilRevoca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabellaIncarichiPilIndex = e.RowIndex;
        }
    }
}
