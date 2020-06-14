using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Configuration;
using System.IO;

namespace ExamenFinalPG
{
    public partial class ImportarABDFRM : Form
    {
        IList<Recaudo> recaudos = new List<Recaudo>();
        RecaudoServiceBD recaudoservice;
        public ImportarABDFRM()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            recaudoservice = new RecaudoServiceBD(connectionString);
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
         recaudos.Clear();
            string linea = string.Empty;
            var fileContent = string.Empty;
            var filepath = string.Empty;
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = "C:\\";
                fileDialog.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = fileDialog.FileName;
                    var fileStream = fileDialog.OpenFile();

                    using (StreamReader lector = new StreamReader(fileStream))
                    {

                        //fileContent = lector.ReadToEnd();
                        while ((linea = lector.ReadLine()) != null)
                        {

                            String[] datos = linea.Split(';');
                           Recaudo recaudo = new Recaudo();
                            recaudo.Nitagente = datos[0];
                            recaudo.Mes = datos[1];
                            recaudo.Año= datos[2];
                            recaudo.TipoEstampilla = datos[3];
                            recaudo.valor = Convert.ToDecimal(datos[4]);
                            recaudo.IdentificacionContratista = datos[5];
                            recaudo.Nombre = datos[6];

                            recaudos.Add(recaudo);
                        }

                        lector.Close();

                    }

                    foreach (var item in recaudos)
                    {
                        recaudoservice.Guardar(item);
                    }

                }


            }

          
            MessageBox.Show(fileContent, "Mensaje de Guardado" + filepath, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

    }
    }

