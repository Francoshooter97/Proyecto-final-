namespace SistemaGestion
{
    partial class Form4
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
            dgvProductosVendidos = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVendidos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductosVendidos
            // 
            dgvProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosVendidos.Location = new Point(33, 74);
            dgvProductosVendidos.Name = "dgvProductosVendidos";
            dgvProductosVendidos.RowTemplate.Height = 25;
            dgvProductosVendidos.Size = new Size(718, 364);
            dgvProductosVendidos.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(47, 21);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(119, 47);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(dgvProductosVendidos);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosVendidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductosVendidos;
        private Button btnVolver;
    }
}