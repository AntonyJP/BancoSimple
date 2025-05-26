    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple.Models
{
    public class Transaccion
    {
        //Propidades de la clase transaccion  con sus metodos automaticos get ,set.
        public int TransaccionId { get; set; }
        public decimal Monto { get; set; }
        
        //Fecha y hora en que se realiza la transacción.Se establece automáticamente al momento de crear la instancia.
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Descripcion { get; set; }
        public int CuentaOrigenId { get; set; }
        public int CuentaDestinoId { get; set; }


    }
}
