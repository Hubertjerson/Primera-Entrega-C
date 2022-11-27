using AppSistemaVentas.Models;
using System.Data.SqlClient;

namespace AppSistemaVentas.ADO.NET
{
    public class ADO_ProductosVendidos
    {
        private SqlConnection conexion;

        private string cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
            "Database=hubertjerson_;" +
            "User Id=hubertjerson_;" +
            "Password=02111999;";

        public ADO_ProductosVendidos()
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
        public List<ProductoVendidoModel> ListarProductoVendido()
        {
            List<ProductoVendidoModel> lisProducVendido = new List<ProductoVendidoModel>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ProductoVendidoModel productoVendido = new ProductoVendidoModel();
                            productoVendido.Id = Convert.ToInt32(dr["Id"].ToString());
                            productoVendido.Stock = Convert.ToInt32(dr["Stock"].ToString());
                            productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"].ToString());
                            productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"].ToString());
                            lisProducVendido.Add(productoVendido);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lisProducVendido;
        }
    }
}
