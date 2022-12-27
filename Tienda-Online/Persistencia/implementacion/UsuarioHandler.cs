using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Persistencia.implementacion
{
    public class UsuarioHandler : IUsuarioHandler
    {
        public string ConnectionString = BD.ConnectionString;

        public bool Create(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
        public Usuario LoginUser(string email, string contraseña)
        {
            Usuario usuario = new Usuario();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                //---Consulta a la base de datos para ver si el usuario existe

                var query = @"SELECT * FROM Usuario WHERE Email = @email AND Contraseña = @contraseña";

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add(new SqlParameter("Email", SqlDbType.VarChar) { Value = email });
                    sqlCommand.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = contraseña });
                    sqlCommand.ExecuteNonQuery();

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                usuario.UsuarioId = Convert.ToInt32(sqlDataReader["UsuarioId"]);
                                usuario.Email = sqlDataReader["Email"].ToString()!;
                                usuario.Contraseña = sqlDataReader["Contraseña"].ToString()!;
                            }
                        }
                        else
                        {
                            usuario.UsuarioId = 0;
                            usuario.Email = "Usuario y/o contraseña incorrectos";
                        }
                    }
                }
                sqlConnection.Close();
            }
            return usuario;
        }

    }
}
