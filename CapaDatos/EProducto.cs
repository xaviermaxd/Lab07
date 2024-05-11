using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaDatos
{
    public class EProducto
    {
        public List<Producto> ListarProductos()
        {
            List<Producto> productos = new List<Producto>();

            try 
            {
                SqlConnection connection = new SqlConnection(BD.connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("USP_GetProducts", connection);
                command.CommandType = CommandType.StoredProcedure;


                //CONECTADA
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int product_id = reader.GetInt32("product_id");
                    string name = reader.GetString("name");
                    decimal price = reader.GetDecimal("price");
                    int stock = reader.GetInt32("stock");
                    //bool active = reader.GetBoolean("active");

                    productos.Add(new Producto { product_id = product_id, name = name, price = price, stock = stock });

                }
                connection.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return productos;
        }

        public void EliminarProducto(int product_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(BD.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("USP_DeleteProductos", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", product_id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void InsertarProducto(Producto producto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(BD.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_InsertProduct", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", producto.name);
                    command.Parameters.AddWithValue("@price", producto.price);
                    command.Parameters.AddWithValue("@stock", producto.stock);
                    
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
