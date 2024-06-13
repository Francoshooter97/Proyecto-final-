using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void CargaProductos()
        {
            List<Producto> productos = ProductoBussiness.GetProductos();

            dgvProducto.AutoGenerateColumns = true;
            dgvProducto.DataSource = productos;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargaProductos();
        }
    }
}