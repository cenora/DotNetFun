/**
 * https://learn.microsoft.com/en-us/dotnet/api/system.console.clear?view=net-5.0
 * @author Cenora
 */

using CodigoCenora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Util.DesenhaCaixa(Cores.Azul);
            Util.DesenhaCaixa(Cores.Branco);
            Util.DesenhaCaixa(Cores.Vermelho);
            Console.WriteLine();
            Util.DesenhaCaixa(Cores.Azul);
            Util.DesenhaCaixa(Cores.Branco);
            Util.DesenhaCaixa(Cores.Vermelho);
            
            Console.WriteLine();
            Console.WriteLine();
            Util.DesenhaCaixa(new List<Siglas>{Siglas.b, Siglas.b, Siglas.b });
            Console.ReadKey();
        }


    }

    
}
