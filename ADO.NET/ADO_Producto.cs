using AppSistemaVentas.Models;
using System.Data.SqlClient;

namespace AppSistemaVentas.ADO.NET
{
    public class ADO_Producto
    {
        private SqlConnection conexion;

        private string cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
            "Database=hubertjerson_;" +
            "User Id=hubertjerson_;" +
            "Password=02111999;";

        public ADO_Producto()
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
        public List<ProductoModel> ListarProducto()
        {
            List<ProductoModel> lisProducto = new List<ProductoModel>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ProductoModel producto = new ProductoModel();
                            producto.Id = Convert.ToInt32(dr["Id"].ToString());
                            producto.Descripciones = dr["Descripciones"].ToString();
                            producto.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                            producto.Costo = Convert.ToDouble(dr["Costo"]);
                            producto.Stock = Convert.ToInt32(dr["Stock"].ToString());
                            producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                            lisProducto.Add(producto);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lisProducto;
        }
    }
}
