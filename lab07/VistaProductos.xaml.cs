using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CapaDatos;
using CapaEntidades;


using BusinessLayer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab07
{

    public partial class VistaProductos : Window
    {
        public VistaProductos()
        {
            InitializeComponent();
        }

        private void MostrarProductos(object sender, RoutedEventArgs e)
        {
            try
            {
                // Crear una instancia de DEmpleado
                ProductBusiness eProducto = new ProductBusiness();

                // Obtener la lista de empleados
                string nombre = txtFilter.Text;
                List<Producto> productos = eProducto.getByName(nombre);

                
                // Asignar la lista de empleados como la fuente de datos del DataGrid
                dataGrid.ItemsSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
