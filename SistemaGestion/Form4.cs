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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public void CargaProductosVendidos()
        {
            try
            {
                var productosVendidos = ProductoVendidoData.ObtenerProductosVendidos();
                dgvProductosVendidos.AutoGenerateColumns = true;
                dgvProductosVendidos.DataSource = productosVendidos;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            CargaProductosVendidos();

        }
    }
}
