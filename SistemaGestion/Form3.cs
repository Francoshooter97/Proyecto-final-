using SistemaGestionData;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void CargaProductos()
        {
            try
            {
                var productos = ProductoData.ObtenerProducto();
                dgvProductos.AutoGenerateColumns = true;
                dgvProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargaProductos();

        }
    }
}
