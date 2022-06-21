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
    public partial class FormInserimentoComponentiVettura : Form
    {
        private readonly DataClassesF1DataContext _Db;
        private int _ComponentiIndex;
        private string _IdVettura;
        public FormInserimentoComponentiVettura(DataClassesF1DataContext originDb, string idVettura)
        {
            InitializeComponent();
            _Db = originDb;
            gridComponente.DataSource = from comp in _Db.componentis
                                        select comp;
            _ComponentiIndex = -1;
            _IdVettura = idVettura; 
        }

        private void gridComponente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _ComponentiIndex = e.RowIndex;
        }

        private void InserisciCompBtn_Click(object sender, EventArgs e)
        {
            if (qtaComponente.Value > 0 && _ComponentiIndex >= 0)
            {     
                var composizione = new composizioni();
                composizione.IDComponente = gridComponente.Rows[_ComponentiIndex].Cells["IDComponente"].Value.ToString();
                composizione.IDVettura = _IdVettura;
                composizione.Quantita = ((int)qtaComponente.Value);
                try
                {
                    _Db.composizionis.InsertOnSubmit(composizione);
                    _Db.SubmitChanges();
                    /* aggiorno l'indice di riga per poter registrare altri pezzi */
                    _ComponentiIndex = -1;
                    MessageBox.Show("Composizione registrata,\n terminare registrazione vettura o aggiungere nuovo componente!");
                }
                catch (Exception ex)
                {
                    Exception ex2 = ex;
                    while (ex2.InnerException != null)
                    {
                        ex2 = ex2.InnerException;
                    }
                    Console.WriteLine(ex.InnerException);
                    throw;

                    //MessageBox.Show("ATTENZIONE, ricontrolla di aver selezionato il componente e l'id della vettura!");
                }
            }
            else
            {
                MessageBox.Show("ATTENZIONE, ricontrolla di aver selezionato il componente!");
            }
        }

        private void esciInserimentoVetBtn_Click(object sender, EventArgs e)
        {
            if(_Db.composizionis.Where(c => c.IDVettura == _IdVettura).Any())
            {
                this.Close();
            } else
            {
                MessageBox.Show("Inserisci almeno un componente prima di chiudere!");
            }
        }
    }
}
