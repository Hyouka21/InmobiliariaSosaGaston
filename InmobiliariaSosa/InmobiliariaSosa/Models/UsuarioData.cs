﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InmobiliariaSosa.Models
{
    public class UsuarioData : Data, IUsuarioData
    {


        public UsuarioData(IConfiguration configuration) : base(configuration)
        {

        }

        public int alta(Usuario e)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"INSERT INTO Usuarios (nombre, apellido, avatar, email, clave, rol) " +
                    $"VALUES (@nombre, @apellido, @avatar, @email, @clave, @rol);" +
                    "SELECT SCOPE_IDENTITY();";//devuelve el id insertado (LAST_INSERT_ID para mysql)
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombre", e.Nombre);
                    command.Parameters.AddWithValue("@apellido", e.Apellido);
                    if (String.IsNullOrEmpty(e.Avatar))
                        command.Parameters.AddWithValue("@avatar", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@avatar", e.Avatar);
                    command.Parameters.AddWithValue("@email", e.Email);
                    command.Parameters.AddWithValue("@clave", e.Clave);
                    command.Parameters.AddWithValue("@rol", e.Rol);
                    connection.Open();
                    res = Convert.ToInt32(command.ExecuteScalar());
                    e.Id = res;
                    connection.Close();
                }
            }
            return res;
        }
        public int Baja(int id)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"DELETE FROM Usuarios WHERE id = @id";
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
        public int Modificacion(Usuario e)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"UPDATE Usuarios SET nombre=@nombre, apellido=@apellido, avatar=@avatar, email=@email, clave=@clave, rol=@rol " +
                    $"WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombre", e.Nombre);
                    command.Parameters.AddWithValue("@apellido", e.Apellido);
                    command.Parameters.AddWithValue("@avatar", e.Avatar);
                    command.Parameters.AddWithValue("@email", e.Email);
                    command.Parameters.AddWithValue("@clave", e.Clave);
                    command.Parameters.AddWithValue("@rol", e.Rol);
                    command.Parameters.AddWithValue("@id", e.Id);
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }

        public IList<Usuario> obtenerTodo()
        {
            IList<Usuario> res = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"SELECT id, nombre, apellido, avatar, email, clave, rol" +
                    $" FROM Usuarios";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Usuario e = new Usuario
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Avatar = reader["Avatar"].ToString(),
                            Email = reader.GetString(4),
                            Clave = reader.GetString(5),
                            Rol = reader.GetInt32(6),
                        };
                        res.Add(e);
                    }
                    connection.Close();
                }
            }
            return res;
        }

        public Usuario ObtenerPorId(int id)
        {
            Usuario e = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"SELECT id, nombre, apellido, avatar, email, clave, rol FROM Usuarios" +
                    $" WHERE id=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        e = new Usuario
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Avatar = reader["Avatar"].ToString(),
                            Email = reader.GetString(4),
                            Clave = reader.GetString(5),
                            Rol = reader.GetInt32(6),
                        };
                    }
                    connection.Close();
                }
            }
            return e;
        }

        public Usuario ObtenerPorEmail(string email)
        {
            Usuario e = null;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string sql = $"SELECT id, nombre, apellido, avatar, email, clave, rol FROM Usuarios" +
                    $" WHERE email=@email";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        e = new Usuario
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Avatar = reader["Avatar"].ToString(),
                            Email = reader.GetString(4),
                            Clave = reader.GetString(5),
                            Rol = reader.GetInt32(6),
                        };
                    }
                    connection.Close();
                }
            }
            return e;
        }
    }
}

