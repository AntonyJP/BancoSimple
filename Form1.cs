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
    }
}
