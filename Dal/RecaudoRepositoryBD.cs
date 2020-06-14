using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace Dal
{
    public class RecaudoRepositoryBD
    {
        private readonly SqlConnection _connection;
        IList<Recaudo> recaudos = new List<Recaudo>();
        public RecaudoRepositoryBD(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(Recaudo recaudo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Recaudos (NitAgente,Mes,Año,TipoEstampilla,Valor,Identificacion,Nombre) 
                                        values (@NitAgente,@Mes,@Año,@TipoEstampilla,@Valor,@Identificacion,@Nombre)";

                command.Parameters.AddWithValue("@NitAgente", recaudo.Nitagente);
                command.Parameters.AddWithValue("@Mes", recaudo.Mes);
                command.Parameters.AddWithValue("@Año", recaudo.Año);
                command.Parameters.AddWithValue("@TipoEstampilla", recaudo.TipoEstampilla);
                command.Parameters.AddWithValue("@Valor", recaudo.valor);
                command.Parameters.AddWithValue("@Identificacion", recaudo.IdentificacionContratista);
                command.Parameters.AddWithValue("@Nombre", recaudo.Nombre);
                var filas = command.ExecuteNonQuery();

            }
        }
    }
}
