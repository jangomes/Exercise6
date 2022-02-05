using System;

namespace Exercise6
{
    class Program
    {

        /*
         * Write a program for a lawn-mowing service. The lawn-mowing season lasts 20 weeks.
         * The weekly fee for mowing a lot under 400 square feet is $25. The fee for a lot that
         * is 400 square feet or more, but under 600 square feet, is $35 per week. The
         * fee for a lot that is 600 square feet or over is $50 per week. Prompt
         * the user for the length and width of a lawn, and then display the weekly mowing
         * fee, as well as the total fee for the 20-week season.
         * */
        static void Main(string[] args)
        {
            string a = "y";
            while (a == "y")
            {
                Console.WriteLine("Hello welcome to the lawn-mowing service!\n");

                Console.WriteLine("Please inform the lenght of the lot!");
                double l = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please inform the width of the lot!");
                double w = Convert.ToDouble(Console.ReadLine());

                double r = l * w;
                if (r < 400)
                {
                    Console.WriteLine("The weekly Price is 25 ");
                }
                else if ((r > 400) && (r < 600))
                {
                    Console.WriteLine("The weekly Price is 35");
                }
                else if ((r > 600))
                {
                    Console.WriteLine("The weekly Price is 50");
                }
                else
                {
                    Console.WriteLine("Sorry that was an error! ");
                }

                Console.WriteLine("Do you wanna start again? ");
                a =(Console.ReadLine());
                Console.Clear();
            }



        }
    }
}
