using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class InmuebleData : Data
    {
        public InmuebleData(IConfiguration configuration): base(configuration)
        {

        }
        public int alta(Inmueble i)
        {
            int res = -1;
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"INSERT INTO Inmueble (direccion,ambiente,superficie,latitud,longitud,idPropietario) VALUES(@direccion,@ambiente,@superficie,@latitud,@longitud,@idPropietario);SELECT SCOPE_IDENTITY();";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@direccion", i.Direccion);
                    com.Parameters.AddWithValue("@ambiente", i.Ambiente);
                    com.Parameters.AddWithValue("@superficie", i.Superficie);
                    com.Parameters.AddWithValue("@latitud", i.Latitud);
                    com.Parameters.AddWithValue("@longitud", i.Longitud);
                    com.Parameters.AddWithValue("@idPropietario", i.IdPropietario);
                    con.Open();
                    res = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return res;
        }
        public IList<Inmueble> obtenerTodo()
        {
            IList<Inmueble> lista = new List<Inmueble>();
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"SELECT I.id,I.direccion,I.ambiente,I.superficie,I.latitud,I.longitud,I.idPropietario,P.nombre ,P.apellido FROM Inmueble AS I INNER JOIN PROPIETARIO AS P ON I.idPropietario = P.idPropietario;";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    con.Open();
                    var reader = com.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            Inmueble i = new Inmueble
                            {
                                Id = reader.GetInt32(0),
                                Direccion = reader.GetString(1),
                                Ambiente = reader.GetInt32(2),
                                Superficie = reader.GetInt32(3),
                                Latitud = reader.GetDecimal(4),
                                Longitud = reader.GetDecimal(5),
                                IdPropietario = reader.GetInt32(6),
                                Duenio = new Propietario { 
                                    idPropietario= reader.GetInt32(6),
                                    nombre = reader.GetString(7),
                                    apellido = reader.GetString(8)
                                },
                            };
                            lista.Add(i);
                        }
                    }
                    con.Close();
                }
            }
            return lista;
        }
        public int Baja(int id)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"DELETE FROM Inmueble WHERE id = {id}";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public int Modificacion(Inmueble e)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"UPDATE Inmueble SET " +
                    $"direccion=@direccion, ambiente=@ambiente, superficie=@superficie, latitud=@latitud, longitud=@longitud , idPropietario=@idPropietario " +
                    $"WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@direccion", e.Direccion);
                    command.Parameters.AddWithValue("@ambiente", e.Ambiente);
                    command.Parameters.AddWithValue("@superficie", e.Superficie);
                    command.Parameters.AddWithValue("@latitud", e.Latitud);
                    command.Parameters.AddWithValue("@longitud", e.Longitud);
                    command.Parameters.AddWithValue("@idPropietario", e.IdPropietario);
                    command.Parameters.AddWithValue("@id", e.Id);
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public Inmueble ObtenerPorId(int id)
        {
            Inmueble p = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                string sql = @"SELECT I.id,I.direccion,I.ambiente,I.superficie,I.latitud,I.longitud,I.idPropietario,P.nombre ,P.apellido FROM Inmueble AS I INNER JOIN PROPIETARIO AS P ON I.idPropietario = P.idPropietario WHERE id=@id;";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Inmueble i = new Inmueble
                        {
                            Id = reader.GetInt32(0),
                            Direccion = reader.GetString(1),
                            Ambiente = reader.GetInt32(2),
                            Superficie = reader.GetInt32(3),
                            Latitud = reader.GetDecimal(4),
                            Longitud = reader.GetDecimal(5),
                            IdPropietario = reader.GetInt32(6),
                            Duenio = new Propietario
                            {
                                idPropietario = reader.GetInt32(6),
                                nombre = reader.GetString(7),
                                apellido = reader.GetString(8)
                            },
                        };
                        return i;
                    }
                    connection.Close();
                }
            }
            return p;
        }
    }
}

