using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStock
{
    public class AltaStockCommand : OrderCommand
    {
        public AltaStockCommand(ProductReceiver prod, int cant):base(prod, cant)
        {
        }

        public override void Ejecutar()
        {
            _prod.SumarStock(_cant);
        }
    }
}
