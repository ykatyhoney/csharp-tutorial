using System;
using System.Collections;

namespace csharp.net
{
    public class Statement
    {
        static void Main(string[] args)
        {
            //int number;

            //Console.WriteLine("please enter a number between 0 and 10");

            //Console.WriteLine("Do you enjoy C#?(yes/or/maybe)");

            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "yes":
            //    case "maybe":
            //        Console.WriteLine("great");
            //        break;

            //    case "No":
            //        Console.WriteLine("Too bad!");
            //        break;
            //}

            //number = int.Parse(Console.ReadLine());

            ////if (number > 10)
            ////    Console.WriteLine("Hey! The number should be 10 or less!");

            ////else
            ////if (number < 0)
            ////    Console.WriteLine("Hey! The number should be 0 or more!");

            ////else
            ////    Console.WriteLine("good job!");

            //if (number > 10 || (number < 0))
            //    Console.WriteLine("Hey! the number should be 0 or more and 10 or less!");
            //else
            //    Console.WriteLine("Good job!");

            //Console.ReadLine();

            //int number = 5;

            //while (number < 5)
            //{
            //    Console.WriteLine(number);
            //    number = number + 1;

            //}
            //Console.ReadLine();

            //do
            //{
            //    Console.WriteLine(number);
            //    number = number + 1;
            //} while (number < 5);

            //for(int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadLine();
            //}

            ArrayList list = new ArrayList();

            list.Add("john doe");
            list.Add("jane doe");
            list.Add("someone else");

            foreach (string name in list)
                Console.ReadLine();
        }
    }
}
