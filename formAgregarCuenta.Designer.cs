namespace BancoSimple
{
    partial class formAgregarCuenta
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
            lblNumeroCuenta = new Label();
            txtNumeroCuenta = new TextBox();
            btnAceptar = new Button();
            nudSaldoInicial = new NumericUpDown();
            btnCancelar = new Button();
            lblSaldoInicial = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSaldoInicial).BeginInit();
            SuspendLayout();
            // 
            // lblNumeroCuenta
            // 
            lblNumeroCuenta.AutoSize = true;
            lblNumeroCuenta.Location = new Point(35, 25);
            lblNumeroCuenta.Name = "lblNumeroCuenta";
            lblNumeroCuenta.Size = new Size(112, 15);
            lblNumeroCuenta.TabIndex = 0;
            lblNumeroCuenta.Text = "Numero De Cuenta:";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(153, 22);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(256, 23);
            txtNumeroCuenta.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(97, 80);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(126, 44);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // nudSaldoInicial
            // 
            nudSaldoInicial.Location = new Point(153, 51);
            nudSaldoInicial.Name = "nudSaldoInicial";
            nudSaldoInicial.Size = new Size(256, 23);
            nudSaldoInicial.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(241, 80);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 44);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblSaldoInicial
            // 
            lblSaldoInicial.AutoSize = true;
            lblSaldoInicial.Location = new Point(74, 53);
            lblSaldoInicial.Name = "lblSaldoInicial";
            lblSaldoInicial.Size = new Size(73, 15);
            lblSaldoInicial.TabIndex = 0;
            lblSaldoInicial.Text = "Saldo Inicial:";
            // 
            // formAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 154);
            Controls.Add(nudSaldoInicial);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(lblSaldoInicial);
            Controls.Add(lblNumeroCuenta);
            Name = "formAgregarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAgregarCuenta";
            ((System.ComponentModel.ISupportInitialize)nudSaldoInicial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroCuenta;
        private TextBox txtNumeroCuenta;
        private Button btnAceptar;
        private NumericUpDown nudSaldoInicial;
        private Button btnCancelar;
        private Label lblSaldoInicial;
    }
}