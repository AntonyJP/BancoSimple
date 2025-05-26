using BancoSimple.Data;
using BancoSimple.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSimple
{
    public partial class formAgregarCuenta : Form
    {
        private BancoSimple2S1Context _db;  

        
        public Cuenta NuevaCuenta { get; private set; }
        private int _clienteId;
        public formAgregarCuenta(BancoSimple2S1Context db, int clienteId)
        {
            _db = db;
            InitializeComponent();
            _clienteId = clienteId;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string numeroCuenta = txtNumeroCuenta.Text.Trim();
            decimal saldo = nudSaldoInicial.Value;

            // Validación del número de cuenta vacío
            if (string.IsNullOrWhiteSpace(numeroCuenta))
            {
                MessageBox.Show("Ingrese el número de cuenta.");
                return;
            }

            // Validación: solo 9 dígitos numéricos exactos
            if (!Regex.IsMatch(numeroCuenta, @"^\d{9}$"))
            {
                MessageBox.Show("El número de cuenta debe contener exactamente 9 dígitos numéricos.");
                return;
            }

            // Validación: al menos 5 dígitos distintos de 0
            int digitosDistintosDeCero = numeroCuenta.Count(c => c != '0');
            if (digitosDistintosDeCero < 5)
            {
                MessageBox.Show("El número de cuenta debe contener al menos 5 dígitos diferentes de 0.");
                return;
            }
            //Validacion para revisar si el numero de la cuenta esta repetido.
            if (_db.Cuentas.Any(c => c.NumeroCuenta == numeroCuenta))
            {
                MessageBox.Show("El número de cuenta ya está registrada.");
                return;
            }

            // Validación del saldo mínimo
            if (saldo < 1000)
            {
                MessageBox.Show("El saldo inicial debe ser mayor o igual a 1000.");
                return;
            }
            if (saldo >= 1000000)
            {
                MessageBox.Show("El saldo maximo de la cuenta es de 1,000,000.00");
                return;
            }

        NuevaCuenta = new Cuenta //Crea una nueva instancia de la clase Cuenta y asigna sus propiedades
        {
            NumeroCuenta = txtNumeroCuenta.Text,
            Saldo = nudSaldoInicial.Value,
            ClienteId = _clienteId,
            Activa = true
        };

            DialogResult = DialogResult.OK;// Nos dice que el formulario se termino y se cerro.
            Close();
        }
        //Con este boton cancelamos la creacion de la cuenta
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
