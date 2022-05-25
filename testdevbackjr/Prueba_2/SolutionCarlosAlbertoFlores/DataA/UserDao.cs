using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataA
{
    public class UserDao : ConnectioToSql
    {
        
        public void EditProfile(int userId, string Nombre, string Paterno, string Materno, string Login)
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = Connection;
                    command.CommandText = "UPDATE usuarios SET Nombre=@Nombre, Paterno=@Paterno, Materno=@Materno, Login=@Login where Login=@Login";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Paterno", Paterno);
                    command.Parameters.AddWithValue("@Materno", Materno);
                    command.Parameters.AddWithValue("@Login", Login);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddProfile(int userId, string Nombre, string Paterno, string Materno, string Login, string Sueldo, string Fecha_Ingreso)
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = Connection;
                    command.CommandText = "INSERT INTO usuarios (Nombre, Paterno, Materno, Login)VALUES(@Nombre, @Paterno, @Materno, @Login)";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Paterno", Paterno);
                    command.Parameters.AddWithValue("@Materno", Materno);
                    command.Parameters.AddWithValue("@Login", Login);
                    command.Parameters.AddWithValue("@userId", userId);

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public void complemen(int userId, string Nombre, string Paterno, string Materno, string Login, string Sueldo, string Fecha_Ingreso)
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = Connection;
                    command.CommandText = "INSERT INTO empleados (Login, Sueldo, Fecha_Ingreso)VALUES(@Nombre, @Paterno, @Materno, @Login)";
                    command.Parameters.AddWithValue("@Nombre", Login);
                    command.Parameters.AddWithValue("@Paterno", Sueldo);
                    command.Parameters.AddWithValue("@Materno", Fecha_Ingreso);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }    
    }
}
