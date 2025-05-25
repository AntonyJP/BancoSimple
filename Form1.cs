using BancoSimple.Data;
using Microsoft.EntityFrameworkCore;
using BancoSimple.Models;   

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

        private void RealizarTransferencia(int cuentaOrigen, int cuentaDestino, decimal monto)
        {
            /*implementar la logica de transferencia
            *niveles de aislamiento  (Serializable se utiliza para operaciones financieras)* 
            */
            using var transferencia = _db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                var cuentaOrigenId = _db.Cuentas.FirstOrDefault(c => c.CuentaId == cuentaOrigen);
                var cuentaDestinoId = _db.Cuentas.FirstOrDefault(c => c.CuentaId == cuentaDestino);

                if (cuentaOrigenId.Saldo < monto) throw new Exception("Saldo insuficiente");

                cuentaOrigenId.Saldo -= monto;
                cuentaDestinoId.Saldo += monto;

                _db.Transacciones.Add(new Transaccion
                {
                    Monto = monto,
                    Fecha = DateTime.Now,
                    Descripcion = "Transferencia",
                    CuentaOrigenId = cuentaOrigen,
                    CuentaDestinoId = cuentaDestino
                });

                _db.SaveChanges();
                //Transaccion Completa

                transferencia.Commit();
                MessageBox.Show("Transferencia realizada con éxito.");

                CargarInfo();

            }
            catch (Exception ex)
            {
                //reversion de transacciones
                transferencia.Rollback();
                MessageBox.Show($"Error al realizar la transferencia: {ex.Message}");
            };
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

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione dos cuentas para realizar la transferencia.");
                return;
            }
            else
            {
                var cuentaOrigenId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
                var cuentasDestinoId = (int)dgvCuentas.SelectedRows[1].Cells["CuentaId"].Value;
                var form = new formTransferencias(cuentaOrigenId, cuentasDestinoId);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RealizarTransferencia(cuentaOrigenId, cuentasDestinoId, form.Monto);
                }
            }
        }

        private void btnVerTransferencias_Click(object sender, EventArgs e)
        {
            var form = new formVerTransacciones();
            form.ShowDialog();
        }
    }
}
