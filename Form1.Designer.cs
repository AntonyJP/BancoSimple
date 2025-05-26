namespace BancoSimple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            btnAgregarCliente = new Button();
            dgvCuentas = new DataGridView();
            btnAgregarCuenta = new Button();
            btnDesactivarCuenta = new Button();
            btnCloseForm1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(29, 32);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(413, 396);
            dgvClientes.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(29, 436);
            btnAgregarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(145, 65);
            btnAgregarCliente.TabIndex = 1;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(494, 32);
            dgvCuentas.Margin = new Padding(3, 4, 3, 4);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(413, 396);
            dgvCuentas.TabIndex = 0;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Location = new Point(494, 436);
            btnAgregarCuenta.Margin = new Padding(3, 4, 3, 4);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(145, 65);
            btnAgregarCuenta.TabIndex = 2;
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += btnAgregarCuenta_Click;
            // 
            // btnDesactivarCuenta
            // 
            btnDesactivarCuenta.Location = new Point(677, 436);
            btnDesactivarCuenta.Margin = new Padding(3, 4, 3, 4);
            btnDesactivarCuenta.Name = "btnDesactivarCuenta";
            btnDesactivarCuenta.Size = new Size(145, 65);
            btnDesactivarCuenta.TabIndex = 3;
            btnDesactivarCuenta.Text = "Desactivar Cuenta";
            btnDesactivarCuenta.UseVisualStyleBackColor = true;
            btnDesactivarCuenta.Click += btnDesactivarCuenta_Click;
            // 
            // btnCloseForm1
            // 
            btnCloseForm1.Location = new Point(1010, 436);
            btnCloseForm1.Name = "btnCloseForm1";
            btnCloseForm1.Size = new Size(134, 65);
            btnCloseForm1.TabIndex = 4;
            btnCloseForm1.Text = "Cerrar Sistema";
            btnCloseForm1.UseVisualStyleBackColor = true;
            btnCloseForm1.Click += btnCloseForm1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 659);
            Controls.Add(btnCloseForm1);
            Controls.Add(btnDesactivarCuenta);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(btnAgregarCliente);
            Controls.Add(dgvCuentas);
            Controls.Add(dgvClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnAgregarCliente;
        private DataGridView dgvCuentas;
        private Button btnAgregarCuenta;
        private Button btnDesactivarCuenta;
        private Button btnCloseForm1;
    }
}
