namespace BancoSimple
{
    partial class formTransferencias
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
            lblOrigen = new Label();
            lblMonto = new Label();
            lblDestino = new Label();
            txtMonto = new TextBox();
            btnRealizarTransferencia = new Button();
            SuspendLayout();
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(53, 23);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(38, 15);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "label1";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(53, 51);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(38, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "label1";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(53, 82);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(38, 15);
            lblDestino.TabIndex = 0;
            lblDestino.Text = "label1";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(264, 48);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(218, 23);
            txtMonto.TabIndex = 1;
            // 
            // btnRealizarTransferencia
            // 
            btnRealizarTransferencia.Location = new Point(86, 123);
            btnRealizarTransferencia.Name = "btnRealizarTransferencia";
            btnRealizarTransferencia.Size = new Size(324, 36);
            btnRealizarTransferencia.TabIndex = 2;
            btnRealizarTransferencia.Text = "Realizar Transferencia";
            btnRealizarTransferencia.UseVisualStyleBackColor = true;
            btnRealizarTransferencia.Click += btnRealizarTransferencia_Click;
            // 
            // formTransferencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 195);
            Controls.Add(btnRealizarTransferencia);
            Controls.Add(txtMonto);
            Controls.Add(lblDestino);
            Controls.Add(lblMonto);
            Controls.Add(lblOrigen);
            Name = "formTransferencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTransferencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrigen;
        private Label lblMonto;
        private Label lblDestino;
        private TextBox txtMonto;
        private Button btnRealizarTransferencia;
    }
}