using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class PagoData : Data
    {
        public PagoData(IConfiguration configuration) : base(configuration)
        {

        }
        public int alta(Pago i)
        {
            int res = -1;
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"INSERT INTO Pago (numeroPago,fechaPago,monto,contratoId) VALUES(@numeroPago,@fechaPago,@monto,@contratoId);SELECT SCOPE_IDENTITY();";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@numeroPago", i.NumeroPago);
                    com.Parameters.AddWithValue("@fechaPago",  DateTime.Now);
                    com.Parameters.AddWithValue("@monto", i.Monto);
                    com.Parameters.AddWithValue("@contratoId", i.ContratoId);

                    con.Open();
                    res = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return res;
        }
        public IList<Pago> obtenerTodoXId(int id)
        {
            IList<Pago> lista = new List<Pago>();
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string sql = @"SELECT p.id,p.numeroPago,p.fechaPago,p.monto,p.contratoId,c.idInquilino,i.dni,c.idInmueble,inm.direccion,c.precio,p.fechaUpdate
                FROM Pago p inner join Contrato c on p.contratoId = c.id
                inner join Inquilino i on c.idInquilino= i.idInquilino 
                inner join Inmueble inm on inm.id=c.idInmueble where p.contratoId = @id;";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@id", id);
                    con.Open();
                    var reader = com.ExecuteReader();
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                           
                                Pago i = new Pago
                                {
                                    Id = reader.GetInt32(0),
                                    NumeroPago = reader.GetInt32(1),
                                    FechaPago = reader.GetDateTime(2),
                                    Monto = reader.GetDecimal(3),
                                    ContratoId = reader.GetInt32(4),
                                    Contrato = new Contrato
                                    {
                                        Id = reader.GetInt32(4),
                                        IdInquilino = reader.GetInt32(5),
                                        IdInmueble = reader.GetInt32(7),
                                        Inquilino = new Inquilino
                                        {
                                            idInquilino = reader.GetInt32(5),
                                            dni = reader.GetString(6)
                                        },
                                        Inmueble = new Inmueble
                                        {
                                            Id = reader.GetInt32(7),
                                            Direccion = reader.GetString(8)
                                        },
                                        Precio = reader.GetDecimal(9)

                                    },
                                    FechaUpdate = reader["fechaUpdate"] != DBNull.Value ? reader.GetDateTime(10) : null


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
                string sql = $"DELETE FROM Pago WHERE id = {id}";
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
        public int Modificacion(Pago e)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                string sql = $"UPDATE Pago SET " +
                    "numeroPago=@numeroPago, fechaUpdate=@fechaUpdate, monto=@monto " +
                    $"WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;

                    var fecha = DateTime.Now;
                    command.Parameters.AddWithValue("@numeroPago", e.NumeroPago);
                    command.Parameters.AddWithValue("@fechaUpdate", fecha);
                    command.Parameters.AddWithValue("@monto", e.Monto);

                    

                    command.Parameters.AddWithValue("@id", e.Id);
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public Pago ObtenerPorId(int id)
        {
            Pago p = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                string sql = @"SELECT p.id,p.numeroPago,p.fechaPago,p.monto,p.contratoId,c.idInquilino,i.dni,c.idInmueble,inm.direccion,c.precio,p.fechaUpdate
                FROM Pago p inner join Contrato c on p.contratoId = c.id
                inner join Inquilino i on c.idInquilino= i.idInquilino 
                inner join Inmueble inm on inm.id=c.idInmueble where p.id=@id;";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                            Pago i = new Pago
                            {
                                Id = reader.GetInt32(0),
                                NumeroPago = reader.GetInt32(1),
                                FechaPago = reader.GetDateTime(2),
                                Monto = reader.GetDecimal(3),
                                ContratoId = reader.GetInt32(4),
                                Contrato = new Contrato
                                {
                                    Id = reader.GetInt32(4),
                                    IdInquilino = reader.GetInt32(5),
                                    IdInmueble = reader.GetInt32(7),
                                    Inquilino = new Inquilino
                                    {
                                        idInquilino = reader.GetInt32(5),
                                        dni = reader.GetString(6)
                                    },
                                    Inmueble = new Inmueble
                                    {
                                        Id = reader.GetInt32(7),
                                        Direccion = reader.GetString(8)
                                    },
                                    Precio = reader.GetDecimal(9)

                                },
                                FechaUpdate = reader["fechaUpdate"]!= DBNull.Value ? reader.GetDateTime(10) : null
                                
                                // se compara con null para que devuelva el valor

                            };
                        
                            return i;
                       
                       
                    }

                    
                    }
                    connection.Close();
                }
            
            return p;
        }

    }
}
