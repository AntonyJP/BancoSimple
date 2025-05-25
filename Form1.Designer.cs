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
            btnTransferir = new Button();
            btnVerTransferencias = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(25, 24);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(361, 297);
            dgvClientes.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(25, 327);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(127, 49);
            btnAgregarCliente.TabIndex = 1;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(432, 24);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.Size = new Size(361, 297);
            dgvCuentas.TabIndex = 0;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Location = new Point(432, 327);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(127, 49);
            btnAgregarCuenta.TabIndex = 2;
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += btnAgregarCuenta_Click;
            // 
            // btnDesactivarCuenta
            // 
            btnDesactivarCuenta.Location = new Point(592, 327);
            btnDesactivarCuenta.Name = "btnDesactivarCuenta";
            btnDesactivarCuenta.Size = new Size(127, 49);
            btnDesactivarCuenta.TabIndex = 3;
            btnDesactivarCuenta.Text = "Desactivar Cuenta";
            btnDesactivarCuenta.UseVisualStyleBackColor = true;
            btnDesactivarCuenta.Click += btnDesactivarCuenta_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(432, 382);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(127, 49);
            btnTransferir.TabIndex = 4;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnVerTransferencias
            // 
            btnVerTransferencias.Location = new Point(592, 382);
            btnVerTransferencias.Name = "btnVerTransferencias";
            btnVerTransferencias.Size = new Size(127, 49);
            btnVerTransferencias.TabIndex = 5;
            btnVerTransferencias.Text = "Ver Transferencia";
            btnVerTransferencias.UseVisualStyleBackColor = true;
            btnVerTransferencias.Click += btnVerTransferencias_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 494);
            Controls.Add(btnVerTransferencias);
            Controls.Add(btnTransferir);
            Controls.Add(btnDesactivarCuenta);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(btnAgregarCliente);
            Controls.Add(dgvCuentas);
            Controls.Add(dgvClientes);
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
        private Button btnTransferir;
        private Button btnVerTransferencias;
    }
}
