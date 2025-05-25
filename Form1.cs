using BancoSimple.Data;
using Microsoft.EntityFrameworkCore;

namespace BancoSimple
{
    public partial class Form1 : Form
    {
        private BancoSimple2S1Context _db = new BancoSimple2S1Context();

        public Form1()
        {
            InitializeComponent();
            CargarInfo();
        }

        private void CargarInfo()
        {
            var cuentas = _db.Cuentas.Include(c => c.Cliente).Where(c => c.Activa).Select(c => new
            {
                c.CuentaId,
                c.NumeroCuenta,
                c.Saldo,
                NombreCliente = c.Cliente.Nombre,
                c.Activa,
                c.ClienteId
            }).ToList();
            dgvClientes.DataSource = _db.Clientes.ToList();
            dgvCuentas.DataSource = cuentas;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var form = new formAgregarCliente();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var nuevoCliente = form.NuevoCliente;
                _db.Clientes.Add(nuevoCliente);
                _db.SaveChanges();
                CargarInfo();
            }
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            var clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
            var form = new formAgregarCuenta(clienteId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var nuevaCuenta = form.NuevaCuenta;
                _db.Cuentas.Add(nuevaCuenta);
                _db.SaveChanges();
                CargarInfo();
            }
        }

        private void btnDesactivarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta primero.");
                return;
            }
            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value; 
            var cuenta = _db.Cuentas.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.Activa = false;
                _db.SaveChanges();
                CargarInfo();
            }
        }
    }
}
