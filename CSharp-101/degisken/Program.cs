using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = string.Empty;

            str1 = "abcdef";

            string name = "abc";
            string surname = "abcdf";
            string fullname = name + " " + surname;
            int integer1 = 10;
            int integer2 = 20;
            int integer3 = integer1 + integer2;

            bool bool1 = 10>2; // True
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine("Yeni Deger: "+yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine("int21 Convert Edilen Degeri: "+int21);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine("int22 Parse Edilen Degeri: "+int21);

            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

        }
    }
}