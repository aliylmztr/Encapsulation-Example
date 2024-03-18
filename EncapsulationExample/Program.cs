using System;

namespace EncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();

            p1.TCKIMLIKNO = "12345678900";

            Console.WriteLine("TC kimlik numaranız: " + p1.TCKIMLIKNO);
            Console.ReadLine();
        }
    }
}
