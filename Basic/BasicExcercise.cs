using System;

/*
link for the excercises
https://www.w3resource.com/csharp-exercises/basic/index.php
 */
namespace c_sharp_learning.Basic
{
    public class BasicExcercise
    {
        public void Ex1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Polite Sambo");
        }

        public void Ex2(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

        public void Ex3(int a, int b)
        {
            int div = a / b;
            Console.WriteLine(div);
        }

        public void Ex4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        public void Ex5()
        {
           Console.WriteLine("Input the First Number");
           String first = Console.ReadLine();

           Console.WriteLine("Input the Second Number");
           String second = Console.ReadLine();

           string swap = null;

           swap = first;
           first = second;
           second = swap;

           Console.WriteLine("After Swapping");
           Console.Write("First Number: ");
           Console.WriteLine(first);
           Console.Write("Second Number: ");
           Console.WriteLine(second);

        }

        public void Ex6()
        {
            Console.WriteLine("Input the first number to multiply");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the third number to multiply");
            int third = Convert.ToInt32(Console.ReadLine());

            int multiply = first * second * third;

            Console.Write(first );
             Console.Write(" ");
            Console.Write("x" );
            Console.Write(" ");
            Console.Write(second );
            Console.Write(" ");
            Console.Write("x" );
            Console.Write(" ");
            Console.Write(third );
            Console.Write(" ");
            Console.Write("=" );
            Console.Write(" ");
            Console.WriteLine(multiply);

        }

        public void Ex7()
        {
            Console.WriteLine("Input the first number");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number");
            int second = Convert.ToInt32(Console.ReadLine());

            int add = first + second;
            int minus = first - second;
            int mult = first * second;
            int div = first / second;
            int mod = first % second;

            Console.Write(first);
            Console.Write(" ");
            Console.Write("+");
            Console.Write(" ");
            Console.Write(second);
            Console.Write(" ");
            Console.Write("=" );
            Console.Write(" ");
            Console.WriteLine(add);

            Console.Write(first);
            Console.Write(" ");
            Console.Write("-");
            Console.Write(" ");
            Console.Write(second);
            Console.Write(" ");
            Console.Write("=" );
            Console.Write(" ");
            Console.WriteLine(minus);

            Console.Write(first);
            Console.Write(" ");
            Console.Write("x");
            Console.Write(" ");
            Console.Write(second);
            Console.Write(" ");
            Console.Write("=" );
            Console.Write(" ");
            Console.WriteLine(mult);

            Console.Write(first);
            Console.Write(" ");
            Console.Write("/");
            Console.Write(" ");
            Console.Write(second);
            Console.Write(" ");
            Console.Write("=" );
            Console.Write(" ");
            Console.WriteLine(div);

            Console.Write(first);
            Console.Write(" ");
            Console.Write("mod");
            Console.Write(" ");
            Console.Write(second);
            Console.Write(" ");
            Console.Write("=" );
            Console.Write(" ");
            Console.WriteLine(mod);

        }

        public void Ex8()
        {

            Console.WriteLine("Enter the number");
            int mult = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i <= 10)
            {
                int ans = i * mult;
                Console.Write(mult);
                Console.Write(" ");
                Console.Write("*");
                Console.Write(" ");
                Console.Write(i);
                Console.Write(" ");
                Console.Write("=");
                Console.Write(" ");
                Console.WriteLine(ans);
                i++;
            }
        }

        public void Ex9(){
            //. In other words it is the sum divided by the count.

            Console.WriteLine("Enter the First number");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the four number");
            int four = Convert.ToInt32(Console.ReadLine());

            int add = first + second + third + four;

            int average = add / 4;
            Console.WriteLine("The average of" + " " +first + ","  + second + ","+ third + "," + four + " "+ "is:" + " " + average);
        }

        public void Ex10()
        {
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int z = Convert.ToInt32(Console.ReadLine());

            int a = x + y;
            int aa = a * z;
            int b = x * y;
            int c = y * z;
            int d = b + c;

            Console.WriteLine("Result of specified numbers" + " " + x + "," + " " + y +
             " " + "and" + " " + z + " " + "," + "(x+y).z" + " " + "is" + " " + aa + " " + "and" + " " +
             "x.y" + " " + "+" + " " + "y.z" + " " + "is" + " " + d);
        }

        public void Ex11()
        {
            Console.WriteLine("Enter a digit");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than" + " " + age);
        }

        // public void Ex12()
        // {
        //     Console.WriteLine("Enter a digit");
        //     int num = Convert.ToInt32(Console.ReadLine());

        //     int a = num + num  + num  + num;

        // }
    }
}