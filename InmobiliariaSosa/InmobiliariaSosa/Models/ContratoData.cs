using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class ContratoData : Data
    {
        public ContratoData(IConfiguration configuration) : base(configuration)
        {

        }
        public int alta(Contrato i)
        {
            int res = -1;
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"INSERT INTO Contrato (idInquilino,idInmueble,fechaDesde,fechaHasta,idGarante,precio,estado) VALUES(@idInquilino,@idInmueble,@fechaDesde,@fechaHasta,@idGarante,@precio,@estado);SELECT SCOPE_IDENTITY();";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@idInquilino", i.IdInquilino);
                    com.Parameters.AddWithValue("@idInmueble", i.IdInmueble);
                    com.Parameters.AddWithValue("@fechaDesde", i.FechaDesde);
                    com.Parameters.AddWithValue("@fechaHasta", i.FechaHasta);
                    com.Parameters.AddWithValue("@idGarante", i.IdGarante);
                    com.Parameters.AddWithValue("@precio", i.Precio);
                    com.Parameters.AddWithValue("@estado", 0);

                    con.Open();
                    res = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return res;
        }
        public IList<Contrato> obtenerTodo()
        {
            IList<Contrato> lista = new List<Contrato>();
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"SELECT C.id,C.idInquilino,C.idInmueble,C.fechaDesde,C.fechaHasta,C.idGarante,inq.nombre,inq.apellido,I.direccion,G.nombre,G.apellido,C.precio,C.estado,C.fechaCancelado FROM Contrato AS C INNER JOIN Inmueble AS I ON I.id = C.idInmueble INNER JOIN Inquilino AS inq ON C.idInquilino = inq.idInquilino INNER JOIN Garante AS G ON C.idGarante = G.id;";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    con.Open();
                    var reader = com.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            Contrato i = new Contrato
                            {
                                Id = reader.GetInt32(0),
                                IdInquilino = reader.GetInt32(1),
                                IdInmueble = reader.GetInt32(2),
                                FechaDesde = reader.GetDateTime(3),
                                FechaHasta = reader.GetDateTime(4),
                                IdGarante = reader.GetInt32(5),
                                Inquilino = new Inquilino
                                {
                                    idInquilino = reader.GetInt32(1),
                                    nombre = reader.GetString(6),
                                    apellido = reader.GetString(7)
                                },
                                Inmueble = new Inmueble
                                {
                                    Id = reader.GetInt32(2),
                                    Direccion = reader.GetString(8)
                                },
                                Garante = new Garante
                                {
                                    Id = reader.GetInt32(5),
                                    Nombre = reader.GetString(9),
                                    Apellido = reader.GetString(10)
                                },
                                Precio = reader.GetDecimal(11),
                                Estado = reader.GetByte(12),
                                FechaCancelado = reader["fechaCancelado"] != DBNull.Value ? reader.GetDateTime(13) : null
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
                string sql = $"DELETE FROM Contrato WHERE id = {id}";
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
        public int Modificacion(Contrato e)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                if (e.Estado == 0)
                {
                    string sql = $"UPDATE Contrato SET " +
                        $"idInquilino=@idInquilino, idInmueble=@idInmueble, fechaDesde=@fechaDesde, fechaHasta=@fechaHasta, idGarante=@idGarante, precio=@precio" +
                        $"WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idInquilino", e.IdInquilino);
                        command.Parameters.AddWithValue("@idInmueble", e.IdInmueble);
                        command.Parameters.AddWithValue("@fechaDesde", e.FechaDesde);
                        command.Parameters.AddWithValue("@fechaHasta", e.FechaHasta);
                        command.Parameters.AddWithValue("@idGarante", e.IdGarante);
                        command.Parameters.AddWithValue("@precio", e.Precio);


                        command.Parameters.AddWithValue("@id", e.Id);
                        connection.Open();
                        res = command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                else
                {
                    string sql = $"UPDATE Contrato SET " +
                        $"estado=@estado, fechaCancelado=@fechaCancelado " +
                        $"WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        var fecha = DateTime.Now;
                        command.CommandType = CommandType.Text;
                        
                        command.Parameters.AddWithValue("@estado", e.Estado);
                        command.Parameters.AddWithValue("@fechaCancelado", fecha);


                        command.Parameters.AddWithValue("@id", e.Id);
                        connection.Open();
                        res = command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            return res;
        }
        public Contrato ObtenerPorId(int id)
        {
            Contrato p = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                string sql = @"SELECT C.id,C.idInquilino,C.idInmueble,C.fechaDesde,C.fechaHasta,C.idGarante,inq.nombre,inq.apellido,I.direccion,G.nombre,G.apellido,C.precio,C.estado FROM Contrato AS C INNER JOIN Inmueble AS I ON I.id = C.idInmueble INNER JOIN Inquilino AS inq ON C.idInquilino = inq.idInquilino INNER JOIN Garante AS G ON C.idGarante = G.id WHERE C.id=@id;";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Contrato i = new Contrato
                        {
                            Id = reader.GetInt32(0),
                            IdInquilino = reader.GetInt32(1),
                            IdInmueble = reader.GetInt32(2),
                            FechaDesde = reader.GetDateTime(3),
                            FechaHasta = reader.GetDateTime(4),
                            IdGarante = reader.GetInt32(5),
                            Inquilino = new Inquilino
                            {
                                idInquilino = reader.GetInt32(1),
                                nombre = reader.GetString(6),
                                apellido = reader.GetString(7)
                            },
                            Inmueble = new Inmueble
                            {
                                Id = reader.GetInt32(2),
                                Direccion = reader.GetString(8)
                            },
                            Garante = new Garante
                            {
                                Id = reader.GetInt32(5),
                                Nombre = reader.GetString(9),
                                Apellido = reader.GetString(10)
                            },
                            Precio = reader.GetDecimal(11),
                            Estado = reader.GetByte(12)
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
