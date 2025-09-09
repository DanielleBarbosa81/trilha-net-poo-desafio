using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Testando Nokia ###");
            Smartphone nokia = new Nokia("1199999999", "Nokia Tijolão", "1234567890", 32);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n### Testando iPhone ###");
            Smartphone iphone = new Iphone("2198888888", "iPhone 14", "9876543210", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
