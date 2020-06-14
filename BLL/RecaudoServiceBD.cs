using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace BLL
{
    public class RecaudoServiceBD
    {
        private RecaudoRepositoryBD RepositorioRecaudo;
        private readonly ConnectionManager conexion;

        public RecaudoServiceBD(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            RepositorioRecaudo = new RecaudoRepositoryBD(conexion);

        }
        public string Guardar(Recaudo recaudo)
        {

            {
                try
                {

                    conexion.Open();
                    RepositorioRecaudo.Guardar(recaudo);
                    conexion.Close();
                    return $"Se guardaron los datos satisfactoriamente";
                }
                catch (Exception e)
                {
                    return $"Error de la Aplicacion: {e.Message}";
                }
                finally { conexion.Close(); }
            }
        }
    }
}
