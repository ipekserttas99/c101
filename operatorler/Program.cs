using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 7;

            int a = y + 55;
            Console.WriteLine(a);
            int b = y / 7;
            Console.WriteLine(b);

            int c = x * 2;
            Console.WriteLine(c);

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }

            int sonuc = 20 % 3;
            Console.WriteLine(sonuc);

            int g = 30;
            int s = 98;
            bool sonuc2 = g < s;
            bool sonuc3 = g >= s;
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
        }
    }
}
