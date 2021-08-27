using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class InquilinoData : Data
    {
        
        public InquilinoData(IConfiguration configuration):base(configuration)
        {

        }
        public int alta(Inquilino i)
        {
            int res = -1;
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"INSERT INTO Inquilino (nombre,apellido,dni,telefono,email) VALUES(@nombre,@apellido,@dni,@telefono,@mail);SELECT SCOPE_IDENTITY();";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@mail", i.email);
                    com.Parameters.AddWithValue("@dni", i.dni);
                    com.Parameters.AddWithValue("@nombre", i.nombre);
                    com.Parameters.AddWithValue("@apellido", i.apellido);
                    com.Parameters.AddWithValue("@telefono", i.telefono);
                    con.Open();
                    res = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return res;
        }
        public IList<Inquilino> obtenerTodo()
        {
            IList<Inquilino> lista = new List<Inquilino>();
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"SELECT idInquilino,nombre,apellido,dni,telefono,email FROM Inquilino;";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    con.Open();
                    var reader = com.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            Inquilino i = new Inquilino
                            {
                                idInquilino = reader.GetInt32(0),
                                nombre = reader.GetString(1),
                                apellido = reader.GetString(2),
                                dni = reader.GetString(3),
                                telefono = reader.GetString(4),
                                email = reader.GetString(5),
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
                string sql = $"DELETE FROM Inquilino WHERE idInquilino = {id}";
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
        public int Modificacion(Inquilino e)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"UPDATE Inquilino SET " +
                    $"nombre=@nombre, apellido=@apellido, dni=@dni, telefono=@telefono, email=@email " +
                    $"WHERE idInquilino = @idInquilino";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombre", e.nombre);
                    command.Parameters.AddWithValue("@apellido", e.apellido);
                    command.Parameters.AddWithValue("@dni", e.dni);
                    command.Parameters.AddWithValue("@telefono", e.telefono);
                    command.Parameters.AddWithValue("@email", e.email);
                    command.Parameters.AddWithValue("@idInquilino", e.idInquilino);
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public Inquilino ObtenerPorId(int id)
        {
            Inquilino p = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"SELECT idInquilino, nombre, apellido, dni, telefono, email FROM Inquilino" +
                    $" WHERE idInquilino=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        p = new Inquilino
                        {
                            idInquilino = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            apellido = reader.GetString(2),
                            dni = reader.GetString(3),
                            telefono = reader.GetString(4),
                            email = reader.GetString(5),
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
