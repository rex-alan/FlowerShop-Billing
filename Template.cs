using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_bill
{
    class Template
    {
        int amount_of_flowers;
        int designed_bouqute;
        int Total_amount;

        public void template_amount()
        {
            Flower flower_obj2 = new Flower();
            amount_of_flowers = flower_obj2.getting_input();

            Bouqute bouqute_obj_2 = new Bouqute();
            designed_bouqute = bouqute_obj_2.bouqute_design();

            Total_amount = amount_of_flowers + designed_bouqute;
            Console.WriteLine("Your Bill Amount(amount of flowers + designes botique) : " + Total_amount);
        }   
    }
}
