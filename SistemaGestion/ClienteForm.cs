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
    public partial class ClienteForm : Form
    {
        public int id;
        public string datoscargados;
        public ClienteForm()
        {
            InitializeComponent();
        }

        internal void CargaProductos()
        {
            throw new NotImplementedException();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
