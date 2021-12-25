using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; //1 byte
            sbyte c = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2;   //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2;   //4 byte
            Int64 i64 = 2;   //8 byte

            uint ui = 2;   //4 byte
            long l = 4;    //8 byte
            ulong ul = 4;  //8 byte

            //REEL SAYILAR
            float f = 5;    //4 byte
            double d = 5;   //8 byte
            decimal de = 5; //16 byte

            char ch = '2'; //2 byte
            string st = "ipek";  //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //STRİNG İFADELER
            string str1 = string.Empty;
            str1 = "ipek serttaş";
            string ad = "ipek";
            string soyad = "serttaş";
            string tamIsim = ad + " " +soyad;

            //integer tanımlama şekilleri
            int integer1=5;
            int integer2=3;
            int integer3=integer1 * integer2;

            //boolean
            bool bool1=10>2;

            //değişken dönüşümleri
            string str20 = "20";
            int int20=20;
            string yeniDeger=str20+int20.ToString();
            Console.WriteLine(yeniDeger); //çıktısı 2020


            int int21=int20+Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22= int20 + int.Parse(str20);  //çıktısı 40

            //datetime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    }
}
