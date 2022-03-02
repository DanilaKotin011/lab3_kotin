using System;


namespace lab2
{    class Program
    {
        static int Main(string[] args)
        {
            RomanNumber testr = new RomanNumber(10);
            Console.WriteLine($"Num1 = {testr}");
            RomanNumber testr2 = new RomanNumber(6);
            Console.WriteLine($"Num2 = {testr2}");
            Console.WriteLine($"\nAdd = {testr + testr2}");
            Console.WriteLine($"Sub = {testr - testr2}");
            Console.WriteLine($"Mul = {testr * testr2}");
            Console.WriteLine($"Div = {testr / testr2}");

            Console.WriteLine($"\nOriginal is {testr2.ToString()}");
            var clon = (RomanNumber)testr2.Clone();
            Console.WriteLine($"Copy is {clon.ToString()}\n");


            RomanNumber sort1 = new RomanNumber(12);
            RomanNumber sort2 = new RomanNumber(5);
            RomanNumber sort3 = new RomanNumber(10);
            RomanNumber[] mas = { sort1, sort2, sort3 };
            Console.WriteLine($"\nOriginal massive");
            for (int i = 0; i < 3; i++) Console.WriteLine($"{mas[i].ToString()}");
            Array.Sort(mas);
            Console.WriteLine($"\nSorted massive");
            for (int i = 0; i < 3; i++) Console.WriteLine($"{mas[i].ToString()}");
            return 0;

        }
    }
}
