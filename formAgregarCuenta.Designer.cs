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
            lblNumeroCuenta.Location = new Point(40, 33);
            lblNumeroCuenta.Name = "lblNumeroCuenta";
            lblNumeroCuenta.Size = new Size(139, 20);
            lblNumeroCuenta.TabIndex = 0;
            lblNumeroCuenta.Text = "Numero De Cuenta:";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(175, 29);
            txtNumeroCuenta.Margin = new Padding(3, 4, 3, 4);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(292, 27);
            txtNumeroCuenta.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(111, 107);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(144, 59);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // nudSaldoInicial
            // 
            nudSaldoInicial.Location = new Point(175, 68);
            nudSaldoInicial.Margin = new Padding(3, 4, 3, 4);
            nudSaldoInicial.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            nudSaldoInicial.Name = "nudSaldoInicial";
            nudSaldoInicial.Size = new Size(293, 27);
            nudSaldoInicial.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(275, 107);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 59);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblSaldoInicial
            // 
            lblSaldoInicial.AutoSize = true;
            lblSaldoInicial.Location = new Point(85, 71);
            lblSaldoInicial.Name = "lblSaldoInicial";
            lblSaldoInicial.Size = new Size(93, 20);
            lblSaldoInicial.TabIndex = 0;
            lblSaldoInicial.Text = "Saldo Inicial:";
            // 
            // formAgregarCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 205);
            Controls.Add(nudSaldoInicial);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(lblSaldoInicial);
            Controls.Add(lblNumeroCuenta);
            Margin = new Padding(3, 4, 3, 4);
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