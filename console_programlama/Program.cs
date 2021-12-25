using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınızı giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba "+name+" "+surname);
        }
    }
}
