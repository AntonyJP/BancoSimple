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
using System.Text.RegularExpressions;
using BancoSimple.Data;

namespace BancoSimple
{
    public partial class formAgregarCliente : Form
    {
        private BancoSimple2S1Context _db;  //Campo privado para almacenar la instancia del contexto de base de datos
        public Cliente NuevoCliente { get; private set; }
        public formAgregarCliente(BancoSimple2S1Context db)
        {
            _db = db;// Asigna la instancia del contexto recibida al campo privado para usarlo dentro del formulario
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string identificacion = txtIdentificacion.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(identificacion))
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
                return;
            }

            // Validación del nombre: 4 palabras, solo letras, iniciales en mayúscula
            if (!Regex.IsMatch(nombre, @"^([A-Z][a-zA-Z]*\s){3}[A-Z][a-zA-Z]*$"))
            {
                MessageBox.Show("El nombre debe ir completo y con sus parametros ");
                return;
            }

            // Validación de la identificación: 000-000000-0000-X
            if (!Regex.IsMatch(identificacion, @"^\d{3}-\d{6}-\d{4}[A-Z]$"))
            {
                MessageBox.Show("La identificación debe tener el formato 000-000000-0000X");
                return;
            }
            // *** Validación de identificación duplicada ***
            if (_db.Clientes.Any(c => c.Identification == identificacion))
            {
                MessageBox.Show("La identificación ya está registrada.");
                return;
            }

          
            NuevoCliente = new Cliente
            {
                Nombre = nombre,
                Identification= identificacion
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
