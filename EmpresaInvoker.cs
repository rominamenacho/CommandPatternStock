using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStock
{
    class EmpresaInvoker
    {

        private List<OrderCommand> ordenes = new List<OrderCommand>();

        public  EmpresaInvoker() { }

        public void ProcesarOrdenes() { 
            foreach(var order in ordenes)
            {
                order.Ejecutar();
            }
            ordenes.Clear();
        }

        public void TomarOrden(OrderCommand orderCommand) {
            ordenes.Add(orderCommand);
        }
    }
}
