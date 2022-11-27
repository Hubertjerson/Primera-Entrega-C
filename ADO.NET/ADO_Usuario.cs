using AppSistemaVentas.Models;
using System.Data.SqlClient;

namespace AppSistemaVentas.ADO.NET
{
    public class ADO_Usuario
    {
        private SqlConnection conexion;

        private string cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" + 
            "Database=hubertjerson_;" + 
            "User Id=hubertjerson_;" + 
            "Password=02111999;";

        public ADO_Usuario()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
            }
            catch(Exception ex)
            {
            Console.WriteLine(ex.Message);
            }
        }

        public List<UsuarioModel> listarUsuario()
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader()) 
                    {
                        while(rd.Read())
                        {
                            UsuarioModel usuario = new UsuarioModel();
                            usuario.Id = Convert.ToInt32(rd["Id"].ToString());
                            usuario.Nombre = rd["Nombre"].ToString();
                            usuario.Apellido = rd["Apellido"].ToString();
                            usuario.NombreUsuario = rd["NombreUsuario"].ToString();
                            usuario.Contrasenia = rd["Contraseña"].ToString();
                            usuario.Mail = rd["Mail"].ToString();
                            lista.Add(usuario);
                            
                        }
                    }
                }
                conexion.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }
    }
}
