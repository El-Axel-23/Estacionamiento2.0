using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento2._0
{
    internal class Camioneta :vehiculo
    {
        //atributo
        public int Num_Ejes {  get; set; }

        //Constructor
        public Camioneta(int ejes, int horasestacionado):base(horasestacionado)
        {
            Num_Ejes = ejes;
        }
        //Retorno del calcular tarifa 
        public override float CalcularTarifa()
        {
            return HorasEstacionado * 45;
        }
    }
}
