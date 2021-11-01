using System;

namespace FuncVoorbeeld
{
    class Program
    {
    
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Som som1 = new Som(5, 3);
            som1.RekenUit(som1.Optellen);
            som1.RekenUit(som1.Aftrekken);
            som1.RekenUit(som1.Vermenigvuldigen);
            som1.RekenUit(som1.Machtsverheffen);
        }
    }
}
