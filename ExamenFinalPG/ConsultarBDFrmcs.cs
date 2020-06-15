using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
using System.Configuration;

namespace ExamenFinalPG
{
    public partial class ConsultarBDFrmcs : Form

      
    {
        RespuestaConsulta respuestaConsulta;
        RecaudoServiceBD recaudoservice;
        ResponseConsulta respuestafiltro;
        public ConsultarBDFrmcs()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            recaudoservice = new RecaudoServiceBD(connectionString);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            respuestaConsulta = recaudoservice.ConsultarRecaudos();
            Consultar();
        }

        private void Consultar()
        {
            if (TipoConsultaCmb.SelectedIndex == 0) {
                dataGridView1.DataSource = respuestaConsulta.recaudos;
            }

            else if (TipoConsultaCmb.SelectedIndex == 1)
            { string nitAgente = Nittxt.Text;
                string mes = Mestxt.Text;
                string año = AñoTxt.Text;
                respuestafiltro = recaudoservice.ConsultarPorAgenteMesYVigencia(nitAgente, mes, año);
                dataGridView1.DataSource = respuestafiltro.recaudosFiltros;
            }
        }
    }
}
