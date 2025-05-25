namespace BancoSimple
{
    partial class formAgregarCliente
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            lblIdentificacion = new Label();
            txtIdentificacion = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(54, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(279, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(81, 111);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(143, 36);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(26, 64);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(82, 15);
            lblIdentificacion.TabIndex = 0;
            lblIdentificacion.Text = "Identificacion:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(166, 61);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(279, 23);
            txtIdentificacion.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(264, 111);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // formAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 171);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblNombre);
            Name = "formAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAgregarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Label lblIdentificacion;
        private TextBox txtIdentificacion;
        private Button btnCancelar;
    }
}