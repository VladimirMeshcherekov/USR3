using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string c;

            Console.WriteLine("Введите температуру");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите систему перевода");
            c = Console.ReadLine();

            if (c == "кельвин" | c == "к" | c == "k")
            {
                Console.WriteLine(a + 274);
            }


            if (c == "не кельвин" | c == "ф" | c == "f")
            {
                Console.WriteLine((a * 1.8) + 32);
            }
            else
            {
                Console.WriteLine("кажите правильно систему для перевода");
            }







        }
    }
}