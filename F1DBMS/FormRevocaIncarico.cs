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
    public partial class FormRevocaIncarico : Form
    {
        private readonly DataClassesF1DataContext db;
        private int rigaTabellaIncarico;
        
        public FormRevocaIncarico(DataClassesF1DataContext originDb)
        {
            InitializeComponent();
            db = originDb;
            SelezionaIncRevoca.DataSource = from incDip in db.incarichi_dipendentis
                                            where !incDip.dataLicenziamento.HasValue
                                            select incDip;
            rigaTabellaIncarico = -1;
        }

        private void revocaIncBtn_Click(object sender, EventArgs e)
        {
            if (rigaTabellaIncarico >= 0)
            {
                var incarico = (from inc in db.incarichi_dipendentis
                                where inc.CF.Equals(SelezionaIncRevoca.Rows[rigaTabellaIncarico].Cells["CF"].Value)
                                && inc.dataAssunzione.Equals(SelezionaIncRevoca.Rows[rigaTabellaIncarico].Cells["dataAssunzione"].Value)
                                && !inc.dataLicenziamento.HasValue
                                && inc.dataAssunzione <= DataLicenziamento.Value.Date
                                select inc).SingleOrDefault();
                if(incarico != null)
                {
                    incarico.dataLicenziamento = DataLicenziamento.Value.Date;
                    db.SubmitChanges();
                    MessageBox.Show("Incarico revocato!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Errore: ricontrolla la selezione o la data!");
                }
            }
            else
            {
                MessageBox.Show("Errore: ricontrolla la selezione o la data!");
            }
        }

        private void SelezionaIncRevoca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rigaTabellaIncarico = e.RowIndex;
        }
        
    }
}
