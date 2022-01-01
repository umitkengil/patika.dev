using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World\n");
            Console.WriteLine("Adınızı Giriniz:\n");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz:\n");
            string surname = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Adınız: "+name +" Soyadınız:"+surname);
        }
    }
}