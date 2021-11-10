using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternStock
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresa = new EmpresaInvoker();
            var producto = new ProductReceiver();
            producto.Cantidad = 100;

            var ordenAlta = new AltaStockCommand(producto, 10);
            empresa.TomarOrden(ordenAlta);

            var ordenBaja = new BajaStockCommand(producto, 50);
            empresa.TomarOrden(ordenBaja);

            empresa.ProcesarOrdenes();

            Console.WriteLine(string.Format("Total stock es {0} ", producto.Cantidad));
            Console.ReadKey();
        }
    }
}
