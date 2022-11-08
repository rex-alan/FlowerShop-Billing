using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_bill
{
    class Billing
    {
        static void Main(string[] args)
        {
            int minimum_option = 1;
            int maximum_option = 3;
            int result;
            do
            {
                result = options();
                switch (result)
                {
                    case 1:
                        Flower flower_obj = new Flower();
                        flower_obj.getting_input();
                        break;

                    case 2:
                        Bouqute bouqute_obj = new Bouqute();
                        bouqute_obj.bouqute_amount();
                        break;

                    case 3:
                        Template template_obj = new Template();
                        template_obj.template_amount();
                        break;

                    default:
                        Console.WriteLine("WARNING : Enter a valid input ");
                        break;
                }
            }while(result < minimum_option || result > maximum_option );
        }
        public static int options() 
        {
            Console.WriteLine();
            Console.WriteLine("Select the options ");
            Console.WriteLine("Flower : 1    Bouquet : 2    Template : 3");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
     }
}
