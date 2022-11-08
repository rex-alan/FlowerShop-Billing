using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_bill
{
    class Bouqute
    {
        // PROPERTIES FOR METHOD( bouqute_amount() )
        int Rate_per_bouqute = 150;
        int amount_of_bouqutes, count_of_bouqutes;
        int min_count = 1;
        int max_count = 20;

        //PROPERTIES FOR METHOD( bouqute_design() )   
        int amount_of_empty_bouqute = 100;
        int rate_of_single_flower_holder = 10;
        int total_no_of_flowers = 0;
        int minimum_flowers = 1;
        int maximum_flowers = 20;

        public void bouqute_amount()
        {
            Console.WriteLine("RATE PER BOUQUTE IS 150 ");
            do
            {
                Console.WriteLine();
                Console.Write("How many bouqutes do you want : ");
                count_of_bouqutes = int.Parse(Console.ReadLine());
                if (count_of_bouqutes >= min_count && count_of_bouqutes <= max_count)
                {
                    amount_of_bouqutes = count_of_bouqutes * Rate_per_bouqute;
                    Console.WriteLine();
                    Console.WriteLine("Amount of your bouqute is : " + amount_of_bouqutes);
                }
                else
                {
                    Console.WriteLine("Enter the no.of bouqute inbetween 1 to 20 ");
                }
            } while (count_of_bouqutes < min_count || count_of_bouqutes > max_count);

        }

        public int bouqute_design()
        {
            do
            {
                Console.WriteLine();
                Console.Write("How many flowers do you want to add on to your bouqute : ");
                total_no_of_flowers = int.Parse(Console.ReadLine());
                if (total_no_of_flowers >= minimum_flowers && total_no_of_flowers <= maximum_flowers)
                {
                    amount_of_empty_bouqute = amount_of_empty_bouqute + total_no_of_flowers * rate_of_single_flower_holder;
                    Console.WriteLine();
                    Console.WriteLine("Amount of your Designed Bouqute is : " + amount_of_empty_bouqute);
                }
                else
                {
                    Console.WriteLine("Please enter the no.of flowers inbetween 1 to 20");
                }
            } while (total_no_of_flowers < minimum_flowers || total_no_of_flowers > maximum_flowers);
            return amount_of_empty_bouqute;
        }
    }
}
