using System;

namespace ConvertNumberInCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            //necessary variables
            int n, r, sum = 0;

            //print show message
            Console.Write("Please Enter number: ");

            //get input from user
            n = int.Parse(Console.ReadLine());

            //create a while loop
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            n = sum;

            while (n > 0)
            {
                r = n % 10;

                switch (r)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 0:
                        Console.Write("Zero");
                        break;
                    default:
                        Console.Write("tttt");
                        break;

                }
                n = n / 10;
                Console.Write(" ");
            }

        }
    }
}
