using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStock
{
  public abstract class OrderCommand
    {
        protected ProductReceiver _prod;
        protected int _cant;

        public OrderCommand(ProductReceiver prod, int cant) {
            _prod = prod;
            _cant = cant;
        }
        public abstract void Ejecutar();
        
    }
}
