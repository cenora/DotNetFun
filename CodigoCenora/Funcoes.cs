using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoCenora
{
    public class Util
    {
        /// <summary>
        /// Informe a cor a ser desenhada como parâmetro ao método
        /// A cor padrão é Branco.
        /// </summary>
        /// <param name="cor">Nome da Cor</param>
        public static void DesenhaCaixa(Cores cor=Cores.Branco)
        {
            switch (cor)
            {
                case Cores.Azul:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("██");
                    break;
                case Cores.Vermelho:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("██");
                    break;
                case Cores.Branco:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("██");
                    break;
                case Cores.Verde:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("██");
                    break;
                case Cores.Amarelo:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("██");
                    break;
                case Cores.Preto:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("██");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Recebe uma lista de cores, com no mínimo 1 cor 
        /// </summary>
        /// <param name="cores"></param>
        public static void DesenhaCaixa(List<Siglas> cores)
        {
            if (cores.Count >= 1)
            {
                foreach (var cor in cores)
                {
                    switch (cor)
                    {
                        case Siglas.b:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("██");
                            break;
                        case Siglas.r:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("██");
                            break;
                        case Siglas.w:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("██");
                            break;
                        case Siglas.g:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("██");
                            break;
                        case Siglas.y:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("██");
                            break;
                        case Siglas.k:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("██");
                            break;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }

    public enum Cores
    {
        Azul,
        Vermelho,
        Branco,
        Verde,
        Amarelo,
        Preto
    }

    public enum Siglas
    {
        b,
        r,
        w,
        g,
        y,
        k
    }
}
