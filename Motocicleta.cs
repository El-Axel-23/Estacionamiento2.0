using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento2._0
{
    internal class Motocicleta : vehiculo
    {
        public int cilindrada;
        public decimal tarifaFija = 15.0m;
        private decimal horasestacionado;

        

        public Motocicleta(float horasestacionado) : base(horasestacionado)
        {
            HorasEstacionado = horasestacionado;
        }

        public override float CalcularTarifa()
        {
            return (float)(horasestacionado * tarifaFija);
        }
    }
}
