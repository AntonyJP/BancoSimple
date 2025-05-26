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
            //Obtenemos la lista de cuentas activasy  los datos del cliente asociado
            var cuentas = _db.Cuentas.Include(c => c.Cliente).Where(c => c.Activa).Select(c => new //Obtenemos los datos de las cuentas del cliente y si estan activas
            { // Nos proyecta los datos 
                c.CuentaId,
                c.NumeroCuenta,
                c.Saldo,
                NombreCliente = c.Cliente.Nombre,
                c.Activa,
                c.ClienteId
            }).ToList();
            dgvClientes.DataSource = _db.Clientes.ToList();//Carga todos los clientes en el dgvClientes
            dgvCuentas.DataSource = cuentas;//Carga las cuentas filtradas y formateadas en el dgvCuentas
        }

        private void RealizarTransferencia(int cuentaOrigen, int cuentaDestino, decimal monto)
        {
        /*
        * Implementa la lógica de una transferencia bancaria entre dos cuentas.
        * Usa el nivel de aislamiento Serializable para evitar problemas de concurrencia,
        * garantizando que no se modifiquen los datos por otras transacciones mientras esta se ejecuta.
        */
            using var transferencia = _db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                //busca las cuetnas por su ID
                var cuentaOrigenId = _db.Cuentas.FirstOrDefault(c => c.CuentaId == cuentaOrigen);
                var cuentaDestinoId = _db.Cuentas.FirstOrDefault(c => c.CuentaId == cuentaDestino);

                // Verifica si la cuenta origen tiene saldo suficiente
                if (cuentaOrigenId.Saldo < monto) throw new Exception("Saldo insuficiente");

                cuentaOrigenId.Saldo -= monto;
                cuentaDestinoId.Saldo += monto;

                // Registra la transacción en la tabla de transacciones
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

                // Confirma la transacción
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
            //Instancia la clase del nuevo cliente para obtener su informacion y añadirla en la base de datos
            var form = new formAgregarCliente(_db);  
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
            // Validar que se tenga seleccionado un id de cliente.
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }
            // Obtenemos el valor del id del cliente para asignarle su cuenta.
            var clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
            var form = new formAgregarCuenta(_db, clienteId);  
            // Si no hay errres se guarda correctamente 
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
            //Valida que se tenga seleccionada una cuenta.
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta primero.");
                return;
            }

            //Obtenermos el estado de la cuenta y se valida la cuenta si esta activa para desactivarla.

            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuenta = _db.Cuentas.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.Activa = false;
                _db.SaveChanges();
                CargarInfo();
            }
        }


        private void btnCloseForm1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // Verifica que se hayan seleccionado dos cuetnas en el DataGridView
            if (dgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione dos cuentas para realizar la transferencia.");
                return;
            }
            else
            {
                //obtiene las cuentas de origen y de destino de sus respectivas filas
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
