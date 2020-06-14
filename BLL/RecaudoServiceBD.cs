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

        public RespuestaConsulta ConsultarRecaudos()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {

                conexion.Open();
                respuesta.recaudos = RepositorioRecaudo.ConsultarRecaudos();
                conexion.Close();
                if (respuesta.recaudos.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay datos para consultar";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }


    }
}
