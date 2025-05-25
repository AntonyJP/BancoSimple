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
    }
}
