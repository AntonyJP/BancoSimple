using BancoSimple.Data;
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
    public partial class formVerTransacciones : Form
    {

        private BancoSimple2S1Context context = new BancoSimple2S1Context();
        public formVerTransacciones()
        {
            InitializeComponent();
            CargarTransacciones();
        }

        private void CargarTransacciones()
        {
            dgvVerTransacciones.DataSource = context.Transacciones.ToList();    
        }
        
    }
}
