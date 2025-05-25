using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple.Models
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public List<Cuentas> cuentas { get; set; } = new List<Cuentas>();   
    }
}
