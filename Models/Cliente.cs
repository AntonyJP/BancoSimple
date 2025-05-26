using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple.Models
{
    public class Cliente
    {
        // Propiedades de la clase Cliente con sus métodos automáticos get y set.
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identification { get; set; }
        //Listas de cuentas que estan asociadas con el cliente.
        public List<Cuenta> cuenta { get; set; } = new List<Cuenta>();   
    }
}
