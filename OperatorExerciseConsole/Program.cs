using System;

namespace OperatorExerciseConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            // -------------Exercise 1-------------

            var a = 17;

            var b = 4;

            var add = a + b;

            var sub = a - b;

            var mult = a * b;
             
            var div = a / b;

            var mod = a % b;

            Console.WriteLine(add);

            Console.WriteLine(sub);

            Console.WriteLine(mult);

            Console.WriteLine($"{a} / {b} is {div} remainder { mod}");


            // --------------Exercise 2--------------

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r );

            Console.WriteLine($"The area of the Circle with radius of { r} is {areaOfCircle }");
        }
    }
}
