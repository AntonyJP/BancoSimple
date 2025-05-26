using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple.Models
{
    public class Cuenta
    {
        //Propidades de la clase cuenta con sus metodos automaticos get ,set.
        // El identificador de la cuenta 
        public int CuentaId { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        //Nos dice si la cuenta esta activa o no 
        public bool Activa { get; set; } = true;
        public int ClienteId { get; set; }
        // Objeto que reprenta al cliente de la cuenta 
        public Cliente Cliente { get; set; }
    }
}
