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

        
    }
}
