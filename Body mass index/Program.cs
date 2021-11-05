using System;

namespace Body_mass_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int kg;
            int cm;
            //int imc;

            Console.WriteLine("Hello, press ENTER to make the calculation of your BMI");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Enter your weight in KG.");
            kg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter your height in CM.");
            cm = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int imc = kg / cm * cm;

            if (imc < 17 )
            {
                Console.WriteLine("Your IMC is " + imc + " You are very underweight.");
                Console.ReadLine();
            }
            else if (imc == 17 || imc <= 18.49)
            {
                Console.WriteLine("Your IMC is " + imc + "You are underweight.");
                Console.ReadLine();
            }
            else if (imc == 18.50 || imc <= 24.99)
            {
                Console.WriteLine("Your IMC is " + imc + "Normal weight.");
                Console.ReadLine();
            }
            else if (imc == 25 || imc <= 24.99)
            {
                Console.WriteLine("Your IMC is " + imc + "Overweight");
                Console.ReadLine();
            }
            else if (imc == 30 || imc <= 24.99)
            {
                Console.WriteLine("Your IMC is " + imc + "Obesity |");
                Console.ReadLine();
            }
            else if (imc == 35 || imc <= 24.99)
            {
                Console.WriteLine("Your IMC is " + imc + "Obesity || (severe)");
                Console.ReadLine();
            }
            else if (imc > 40)
            {
                Console.WriteLine("Your IMC is " + imc + "Obesity ||| (morbid)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}
