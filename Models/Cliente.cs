using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Identification { get; set; }
        public List<Cuenta> cuenta { get; set; } = new List<Cuenta>();   
    }
}
