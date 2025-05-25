using BancoSimple.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple
{
    public partial class formAgregarCuenta : Form
    {

        public Cuenta NuevaCuenta { get; private set; }
        private int _clienteId;
        public formAgregarCuenta(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroCuenta.Text))
            {
                MessageBox.Show("Ingrese el numero de cuenta");
                return;
            }
            NuevaCuenta = new Cuenta
            {
                NumeroCuenta = txtNumeroCuenta.Text,
                Saldo = nudSaldoInicial.Value,
                ClienteId = _clienteId,
                Activa = true
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
