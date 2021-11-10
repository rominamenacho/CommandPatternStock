using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStock
{
   public class BajaStockCommand : OrderCommand
    {
        public BajaStockCommand(ProductReceiver prod, int cant):base(prod, cant) { }
        public override void Ejecutar()
        {
            _prod.RestarStock(_cant);
        }
    }
}
