using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
             * Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
             
            Console.Write("Bir pozitif sayı adeti giriniz: ");           
            int aa = Convert.ToInt32(Console.ReadLine());
            if(aa > 0)
            {
                int[] array1 = new int[aa];
                for (int i = 0; i < aa; i++)
                {
                    Console.WriteLine("Bir sayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    array1[i] = sayi;                   
                }
                for (int j = 0; j < aa; j++)
                {
                    if(array1[j] % 2 == 0)
                    {
                        Console.WriteLine(array1[j]);
                    }
                }
            }
            
           /* 2 - Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */
            
            Console.Write("Bir pozitif sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir pozitif sayı giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (m == array2[i] || m % array2[i] == 0)
                {
                    Console.WriteLine(array2[i]);
                }
            }
            /* 3 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
                Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
                Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */
            
            Console.Write("Bir pozitif sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] array3 = new string[n];
            for (int i = 0; i < a; i++)
            {
                Console.Write("Bir kelime giriniz: ");
                array3[i] = Convert.ToString(Console.ReadLine());
            }
            foreach (var i in array3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************************");
            Array.Reverse(array3);
            foreach(var i in array3)
            {
                Console.WriteLine(i);
            }
            
            /* 4 - Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
                Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */
            

            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Convert.ToString(Console.ReadLine());

            string[] parcalanan = cumle.Split(" ");
            char[] harfler = cumle.ToCharArray();
            int kelimeToplami = 0;
            int harfToplami = 0;


            foreach (var item in parcalanan)
            {
                kelimeToplami++;
            }

            foreach (var item in harfler)
            {
                if(item == ' ')
                {
                    continue;
                }
                harfToplami++;
            }

            Console.WriteLine("Kelime sayısı: " +kelimeToplami);
            Console.WriteLine("Harf Toplamı: " +harfToplami);


        }
    }
}
