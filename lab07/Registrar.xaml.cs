using BusinessLayer;
using CapaEntidades;
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

namespace lab07
{
    /// <summary>
    /// Lógica de interacción para Registrar.xaml
    /// </summary>
    public partial class Registrar : Window
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void RegistrarProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             
                Producto producto = new Producto
                {
                    name = txtName.Text,
                    price = decimal.Parse(txtPrice.Text),
                    stock = int.Parse(txtStock.Text)
                };

                ProductBusiness business = new ProductBusiness();
                business.InsertarProducto(producto);

                MessageBox.Show("Producto registrado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el producto: " + ex.Message);
            }
        }
    }
}
