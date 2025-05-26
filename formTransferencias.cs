using BancoSimple.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class formTransferencias : Form
    {
        public decimal Monto { get; private set; }
        private int _cuentaOrigenId;
        private int _cuentaDestinoId;
        // Contexto de base de datos para acceder a las cuentas
        private BancoSimple2S1Context _db;

        public formTransferencias(int cuentaOrigenId, int cuentaDestinoId)
        {
            InitializeComponent();
            // Asignación de los IDs a las variables privadas
            _cuentaDestinoId = cuentaDestinoId;
            _cuentaOrigenId = cuentaOrigenId;
            // Inicializa el contexto de la base de datos
            _db = new BancoSimple2S1Context();

            CargarCuenta();
        }

        private void CargarCuenta()
        {
            // Buscar la cuenta de origen y incluye la informacion del cliente asociado
            var cuentaOrigen = _db.Cuentas.Include(c => c.Cliente).FirstOrDefault(c => c.CuentaId == _cuentaOrigenId);
            //Bucsa la cuenta de destino y incluye la informacion del cliente asociado
            var cuentaDestino = _db.Cuentas.Include(c => c.Cliente).FirstOrDefault(c => c.CuentaId == _cuentaDestinoId);

            //carga la informacion del cliente y el numero de cuenta
            lblOrigen.Text = $"{cuentaOrigen.Cliente.Nombre} - {cuentaOrigen.NumeroCuenta}";
            lblDestino.Text = $"{cuentaDestino.Cliente.Nombre} - {cuentaDestino.NumeroCuenta}";
            //muestra el saldo disponible en la cuenta de origen
            lblMonto.Text = $"Saldo disponible: {cuentaOrigen.Saldo:C}";
        }

        private void btnRealizarTransferencia_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal monto) && monto > 0)
            {
                Monto = monto;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido.");
            }   
        }
    }
}
