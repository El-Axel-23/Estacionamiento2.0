using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento2._0
{
    internal class Automovil:vehiculo
    {
        public string Placa { get; set; }

        public Automovil(float horasestacionado, string placa): base(horasestacionado)
        {
            Placa = placa;
        }

        public override float CalcularTarifa()
        {
            return HorasEstacionado * 30.00f;
        }
    }
}
