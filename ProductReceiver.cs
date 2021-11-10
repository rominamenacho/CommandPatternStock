using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStock
{
   public class ProductReceiver
    {
        public double Cantidad { get; set; }
        public String Nombre{ get; set; }

    public ProductReceiver() { }

        public void RestarStock(int cant) {

            Cantidad = Cantidad - cant;
            Console.WriteLine(string.Format("Quitando {0} unidades", cant));
        }

        public void SumarStock(int cant)
        {
            Cantidad = Cantidad + cant;
            Console.WriteLine(string.Format("Agregando {0} unidades ", cant));
        }
    }
}
