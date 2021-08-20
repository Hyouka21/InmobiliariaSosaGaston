using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class PropietarioData
    {
        private string conectionString = "Server=(localdb)\\MSSQLLocalDB;Database=InmobiliariaSosa;Trusted_Connection=True;MultipleActiveResultSets=true";
        public PropietarioData()
        {

        }
        public int alta(Propietario p)
        {
            int res = -1;
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"INSERT INTO Propietario (nombre,apellido,dni,telefono,email,clave) VALUES(@nombre,@apellido,@dni,@telefono,@mail,@clave);SELECT SCOPE_IDENTITY();";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@mail", p.email);
                    com.Parameters.AddWithValue("@dni", p.dni);
                    com.Parameters.AddWithValue("@nombre", p.nombre);
                    com.Parameters.AddWithValue("@apellido", p.apellido);
                    com.Parameters.AddWithValue("@telefono", p.telefono);
                    com.Parameters.AddWithValue("@clave", p.clave);
                    con.Open();
                    res = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return res;
        }
        public IList<Propietario> obtenerTodo()
        {
            IList<Propietario> lista = new List<Propietario>();
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"SELECT idPropietario,nombre,apellido,dni,telefono,email,clave FROM Propietario;";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    con.Open();
                    var reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        Propietario p = new Propietario
                        {
                            idPropietario = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            apellido = reader.GetString(2),
                            dni = reader.GetString(3),
                            telefono = reader.GetString(4),
                            email = reader.GetString(5),
                            clave = reader.GetString(6),
                        };
                        lista.Add(p);
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
                string sql = $"DELETE FROM Propietario WHERE idPropietario = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public int Modificacion(Propietario p)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"UPDATE Propietario SET nombre=@nombre, apellido=@apellido, dni=@dni, telefono=@telefono, email=@email, clave=@clave " +
                    $"WHERE idPropietario = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombre", p.nombre);
                    command.Parameters.AddWithValue("@apellido", p.apellido);
                    command.Parameters.AddWithValue("@dni", p.dni);
                    command.Parameters.AddWithValue("@telefono", p.telefono);
                    command.Parameters.AddWithValue("@email", p.email);
                    command.Parameters.AddWithValue("@clave", p.clave);
                    command.Parameters.AddWithValue("@id", p.idPropietario);
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public Propietario ObtenerPorId(int id)
        {
            Propietario p = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"SELECT idPropietario, nombre, apellido, dni, telefono, email, clave FROM Propietario" +
                    $" WHERE idPropietario=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        p = new Propietario
                        {
                            idPropietario = reader.GetInt32(0),
                            nombre = reader.GetString(1),
                            apellido = reader.GetString(2),
                            dni = reader.GetString(3),
                            telefono = reader.GetString(4),
                            email = reader.GetString(5),
                            clave = reader.GetString(6)
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
