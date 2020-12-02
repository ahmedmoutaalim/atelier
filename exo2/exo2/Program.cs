using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
             float number1 = 1;



        for (var num = 200; num > 0; num -= 15)
        {


            Console.Write(num);
            Console.WriteLine("enfin !!! ");


        }

        while (number1 < 10)
        {

            number1 += number1 / 2;
            Console.WriteLine(number1);


        }

        }
    }
}