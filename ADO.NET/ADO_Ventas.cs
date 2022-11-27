using AppSistemaVentas.Models;
using System.Data.SqlClient;

namespace AppSistemaVentas.ADO.NET
{
    public class ADO_Ventas
    {
        private SqlConnection conexion;

        private string cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
            "Database=hubertjerson_;" +
            "User Id=hubertjerson_;" +
            "Password=02111999;";

        public ADO_Ventas()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public List<VentaModel> ventasLista()
        {
            List<VentaModel> listaVenta = new List<VentaModel>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Venta", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            VentaModel ventas = new VentaModel();
                            ventas.Id = Convert.ToInt32(rd["Id"].ToString());
                            ventas.Comentarios = rd["Comentarios"].ToString();
                            ventas.IdUsuario = Convert.ToInt32(rd["IdUsuario"].ToString());
                            listaVenta.Add(ventas);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaVenta;
        }
    }
}
