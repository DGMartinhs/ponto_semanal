using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ponto_semanal
{
    public partial class Form1 : Form
    {

        dia _dia = null;
        List<dia> listaDia = new List<dia>();
        TimeSpan totalHoras = TimeSpan.Zero;
        public Form1()
        {
            InitializeComponent();
            _dia = new dia();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            DateTime data = DateTime.Now;

            if (listaDia.Count > 0)
            {
                bool registro = listaDia.Where(x => x.Data.Date == data.Date).Any();


                if (registro)
                {
                    foreach (var re in listaDia)
                    {
                        if (re.Data.Date == data.Date)
                        {
                            if (re.Entrada == null)
                            {
                                re.Entrada = data;
                            }
                            else if (re.SaidaAlmoco == null)
                            {
                                re.SaidaAlmoco = data;
                            }
                            else if (re.VoltaAlmoco == null)
                            {
                                re.VoltaAlmoco = data;
                            }
                            else if (re.Saida == null)
                            {
                                re.Saida = data;

                            }
                            else
                            {
                                MessageBox.Show("Voce ja complentou as quatro marcaçao do dia");
                            }
                        }


                    }
                }
                else
                {
                    listaDia.Add(new dia { Data = data.Date });
                }
            }
            else
            {
                listaDia.Add(new dia { Data = data.Date });

            }


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDia;





            foreach (var _re in listaDia)
            {

                TimeSpan gp1 = TimeSpan.Zero;
                TimeSpan gp2 = TimeSpan.Zero;

                if (_re.Entrada != null && _re.SaidaAlmoco != null)
                    gp1 = TimeSpan.FromMinutes(_re.Entrada.Value.Subtract(_re.SaidaAlmoco.Value).TotalMinutes);

                if (_re.VoltaAlmoco != null && _re.Saida != null)
                    gp2 = TimeSpan.FromMinutes(_re.VoltaAlmoco.Value.Subtract(_re.Saida.Value).TotalMinutes);

                totalHoras = gp1 + gp2;
                _re.totalHoras = TimeSpan.FromMinutes(totalHoras.TotalMinutes)
            }


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDia;
        }
    }

}