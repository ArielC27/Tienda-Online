using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Persistencia.implementacion
{
    public class ProductoHandler : IProductoHandler
    {
        public string ConnectionString = BD.ConnectionString;
        public bool Create(Producto producto)
        {
            Producto producto1 = new Producto();
            bool result = false;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                var query = "INSERT INTO Producto (Descripcion, Imagen, Precio de Costo, Precio de Venta, Stock)" +
                    " VALUES (@descripcion, @imagen, @precioDeCosto, @precioDeVenta, @stock)";

                SqlParameter descripcion = new SqlParameter("Descripciones", System.Data.SqlDbType.VarChar) { Value = producto.Descripcion };
                SqlParameter imagen = new SqlParameter("Imagen", System.Data.SqlDbType.VarChar) { Value = producto.Imagen };
                SqlParameter precioCosto = new SqlParameter("Costo", System.Data.SqlDbType.Decimal) { Value = producto.PrecioCosto };
                SqlParameter precioVenta = new SqlParameter("PrecioVenta", System.Data.SqlDbType.Decimal) { Value = producto.PrecioVenta };
                SqlParameter stock = new SqlParameter("Stock", System.Data.SqlDbType.Int) { Value = producto.Stock };

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add(descripcion);
                    sqlCommand.Parameters.Add(imagen);
                    sqlCommand.Parameters.Add(precioCosto);
                    sqlCommand.Parameters.Add(precioVenta);
                    sqlCommand.Parameters.Add(stock);

                    int numberOfRows = sqlCommand.ExecuteNonQuery();
                    if (numberOfRows > 0)
                    {
                        result = true;
                    }
                }
                sqlConnection.Close();
            }
            return result;
        }
        public bool Delete(int id)
        {
            bool result = false;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                string query = "DELETE FROM PRODUCTO WHERE ProductoId = @id";
                SqlParameter id = new SqlParameter("ProductoId", System.Data.SqlDbType.Int);
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.Add(id);

                }
            }
            
            return result;
        }

        public List<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
