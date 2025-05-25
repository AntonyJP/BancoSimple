using BancoSimple.Data;

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
            dgvClientes.DataSource = _db.Clientes.ToList();
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

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
