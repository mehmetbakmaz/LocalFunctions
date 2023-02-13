using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            localFuncKullanimi(12, 23);
        }
        static void localFuncKullanimi(int sayi1, int sayi2)
        {
            int topla(int gelensayi1, int gelensayi2)
            {
                return gelensayi1 + gelensayi2;
            }
            int toplamdeger = topla(sayi1, sayi2);
            Console.WriteLine(toplamdeger);
        }
    }
}
