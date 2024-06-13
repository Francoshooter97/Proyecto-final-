namespace SistemaGestion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new Button();
            btnProducto = new Button();
            btnProductosVendidos = new Button();
            btnVenta = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(82, 193);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(97, 47);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuarios";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(260, 193);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(97, 47);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Productos";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.Location = new Point(441, 193);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(97, 47);
            btnProductosVendidos.TabIndex = 3;
            btnProductosVendidos.Text = "Productos Vendidos";
            btnProductosVendidos.UseVisualStyleBackColor = true;
            btnProductosVendidos.Click += btnProductosVendidos_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(608, 193);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(97, 47);
            btnVenta.TabIndex = 4;
            btnVenta.Text = "Ventas";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVenta);
            Controls.Add(btnProductosVendidos);
            Controls.Add(btnProducto);
            Controls.Add(btnUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnProducto;
        private Button btnProductosVendidos;
        private Button btnVenta;
    }
}