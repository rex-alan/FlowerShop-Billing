using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_bill
{
    class Flower
    {
        int no_of_flower;
        string name_of_flower;
        int total = 0;
        int amount_per_flower = 0;
        int minimum_flower = 1;
        int maximum_flower = 20;
       
        public int getting_input()
        {
            do
            {
                Console.Write("Select no of flowers : ");
                no_of_flower = int.Parse(Console.ReadLine());
                if (no_of_flower >= minimum_flower && no_of_flower <= maximum_flower)
                {
                    for (int i = 1; i <= no_of_flower; i++)
                    {
                        Console.WriteLine();
                        Console.Write("Name of flower " + i + " is : ");
                        name_of_flower = Console.ReadLine();
                        Console.Write("Amount of flower " + name_of_flower + " is : ");
                        amount_per_flower = int.Parse(Console.ReadLine());
                        total = total + amount_per_flower;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Your total amount for flowers is : " + total);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the no.of flowers inbetween 1 to 20");
                }
            } while (no_of_flower < minimum_flower || no_of_flower > maximum_flower);
            return total;
        }
    }
}
