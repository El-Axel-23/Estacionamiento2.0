using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento2._0
{
    internal abstract class vehiculo
    {
        public float HorasEstacionado { get; set; }

        public vehiculo(float horasestacionado)
        {
            HorasEstacionado = horasestacionado;
        }

        public abstract float CalcularTarifa();
    }
}
