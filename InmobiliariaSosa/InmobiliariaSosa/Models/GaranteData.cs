
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class GaranteData:Data,IGaranteData
    {
        public GaranteData(IConfiguration configuration) : base(configuration)
        {

        }
        public int alta(Garante i)
        {
            int res = -1;
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"INSERT INTO Garante (nombre,apellido,dni,telefono,email) VALUES(@nombre,@apellido,@dni,@telefono,@mail);SELECT SCOPE_IDENTITY();";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@mail", i.Email);
                    com.Parameters.AddWithValue("@dni", i.Dni);
                    com.Parameters.AddWithValue("@nombre", i.Nombre);
                    com.Parameters.AddWithValue("@apellido", i.Apellido);
                    com.Parameters.AddWithValue("@telefono", i.Telefono);
                    con.Open();
                    res = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return res;
        }
        public IList<Garante> obtenerTodo()
        {
            IList<Garante> lista = new List<Garante>();
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"SELECT id,nombre,apellido,dni,telefono,email FROM Garante;";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    con.Open();
                    var reader = com.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            Garante i = new Garante
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Dni = reader.GetString(3),
                                Telefono = reader.GetString(4),
                                Email = reader.GetString(5),
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
                string sql = $"DELETE FROM Garante WHERE id = {id}";
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
        public int Modificacion(Garante e)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"UPDATE Garante SET " +
                    $"nombre=@nombre, apellido=@apellido, dni=@dni, telefono=@telefono, email=@email " +
                    $"WHERE id = @idGarante";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombre", e.Nombre);
                    command.Parameters.AddWithValue("@apellido", e.Apellido);
                    command.Parameters.AddWithValue("@dni", e.Dni);
                    command.Parameters.AddWithValue("@telefono", e.Telefono);
                    command.Parameters.AddWithValue("@email", e.Email);
                    command.Parameters.AddWithValue("@idGarante", e.Id);
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public Garante ObtenerPorId(int id)
        {
            Garante p = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"SELECT id, nombre, apellido, dni, telefono, email FROM Garante" +
                    $" WHERE id=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        p = new Garante
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Dni = reader.GetString(3),
                            Telefono = reader.GetString(4),
                            Email = reader.GetString(5),
                        };
                        return p;
                    }
                    connection.Close();
                }
            }
            return p;
        }
    }
}
