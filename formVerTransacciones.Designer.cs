namespace BancoSimple
{
    partial class formVerTransacciones
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
            dgvVerTransacciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVerTransacciones).BeginInit();
            SuspendLayout();
            // 
            // dgvVerTransacciones
            // 
            dgvVerTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerTransacciones.Dock = DockStyle.Fill;
            dgvVerTransacciones.Location = new Point(0, 0);
            dgvVerTransacciones.Name = "dgvVerTransacciones";
            dgvVerTransacciones.Size = new Size(653, 308);
            dgvVerTransacciones.TabIndex = 0;
            // 
            // formVerTransacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 308);
            Controls.Add(dgvVerTransacciones);
            Name = "formVerTransacciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formVerTransacciones";
            ((System.ComponentModel.ISupportInitialize)dgvVerTransacciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVerTransacciones;
    }
}