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

        public IList<Recaudo> ConsultarRecaudos()
        {
            SqlDataReader dataReader;
           
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Recaudos ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Recaudo recaudo = Mapear(dataReader);
                        recaudos.Add(recaudo);
                    }
                }
            }
            return recaudos;
        }

        private Recaudo Mapear(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Recaudo recaudo = new Recaudo();
           recaudo.Nitagente = (string)dataReader["NitAgente"];
           recaudo.Mes = (string)dataReader["Mes"];
           recaudo.Año= (string)dataReader["Año"];
           recaudo.TipoEstampilla= (string)dataReader["TipoEstampilla"];
            recaudo.valor = (decimal)dataReader["Valor"];
            recaudo.IdentificacionContratista = (string)dataReader["Identificacion"];
            recaudo.Nombre = (string)dataReader["Nombre"];
            return recaudo;
        }


        public IList<Recaudo> ConsultarPorAgenteMes(string nitAgente, string mes, string año)
        {
            SqlDataReader dataReader;
             using (var command = _connection.CreateCommand())
            {
               command.CommandText = @"Select * from Recaudos where NitAgente=@NitAgente and Mes = @Mes and Año= @Año";
               command.Parameters.AddWithValue("@NitAgente", nitAgente);
                command.Parameters.AddWithValue("@Mes", mes);
                command.Parameters.AddWithValue("@Año", año);

                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Recaudo recaudo = Mapear(dataReader);
                        recaudos.Add(recaudo);
                    }
                }
            }
            return recaudos;
        }
    }
}
