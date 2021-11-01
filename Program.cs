using System;

namespace Section_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Convertion();
        }


        private static void Convertion()

        {            

            Console.WriteLine("Please, enter a temperature in Fahrenheit to convert to Celsius."); 
            double tempF = double.Parse(Console.ReadLine());           
            Console.WriteLine("The equivalent temperature in Celsius is: {0:0.00} C.", (tempF - 32.0) * 5 / 9);

            Console.WriteLine("Please, enter a temperature in Celsius to convert to Fahrenheit.");
            double tempC = double.Parse(Console.ReadLine()); // Temperature in Celsius
            Console.WriteLine("The equivalent temperature in Fahrenheit is: {0:0.00} F.", (tempC * 9 / 5) + 32.0);


        }


        private static void Comparison()

        {
            
            Console.Write("Please, enter a temperature value in Celsius:");

            double tempC = double.Parse(Console.ReadLine()); // Temperature in Celsius

            Console.Write("Please, enter a temperature value in Fahrenheit:");

            double tempF = double.Parse(Console.ReadLine()); //Temperature in Fahrenheit

            double tempCtoF;
            double tempFtoC;

            tempCtoF = (tempC * 9 / 5) + 32.0;
            tempFtoC = (tempF - 32.0) * 5 / 9;
            

            if (tempC > tempF)
            {
                Console.Write("The temperature in Celsius is bigger that the temperature in Fahrenheit.\n");
                Console.Write($"The temperature difference in Celsius is: {tempC - tempFtoC: 0.00}\n");
                Console.Write($"The temperature difference in Fahrenheit is: {tempCtoF - tempF: 0.00}\n");

            }

            else if (tempF > tempC)
            {
                Console.Write("The temperature in Fahrenheit is bigger that the temperature in Celsius.\n");
                Console.Write($"The temperature difference in Fahrenheit is: {tempF - tempCtoF: 0.00}\n");
                Console.Write($"The temperature difference in Celsius is: {tempFtoC - tempC: 0.00}\n");
                

            }

            else 
            {
                Console.WriteLine("Both of the temperatures are equal.");
            }

        }

        private static void MpGandKMpL()
            //US (miles per gallon) and EU (100km per liter) parameters for fuel consumption

        {          
                Console.Write("Please enter a EU 100km per liter pаrаmeter:");
                double OneHundredKMpL = double.Parse(Console.ReadLine());
                Console.Write("\nThe equivalent US pаrаmеter is: {0}", 282.48 / OneHundredKMpL);                       
            
                Console.Write("\nPlease enter a US miles per gallon pаrаmeter:");
                double MPG = double.Parse(Console.ReadLine());
                Console.Write("\nThe equivalent EU pаrаmeter is: {0}", 282.48 / MPG);           

        }                        
    }
}
