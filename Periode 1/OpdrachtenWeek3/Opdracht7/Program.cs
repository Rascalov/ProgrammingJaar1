using System;

namespace Opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengte, gewicht, bmi, gezondGewichtMin, gezondGewichtMax, bmiMin, bmiMax;
            string geslacht;



            Console.Write("Enter weight (kg): ");
            gewicht = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Length (cm): ");
            lengte = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter gender (male or female): ");
            geslacht = Console.ReadLine();

            bmi = gewicht / Math.Pow((lengte / 100), 2);

            if (geslacht == "male")
            {
                bmiMin = 20;
                bmiMax = 25;
                gezondGewichtMin = bmiMin * Math.Pow((lengte / 100), 2);
                gezondGewichtMax = bmiMax * Math.Pow((lengte / 100), 2);


            }
            else
            {
                bmiMin = 19;
                bmiMax = 24;
                gezondGewichtMin = bmiMin * Math.Pow((lengte / 100), 2);
                gezondGewichtMax = bmiMax * Math.Pow((lengte / 100), 2);
            }
            // ...

            //output

            Console.WriteLine("bmi-value: {0:0.0} \n" +
                              "normal bmi values (min.. max): {1}..{2} \n" +
                              "healthy weight range: {3:0.0} .. {4:0.0}", bmi, bmiMin, bmiMax, gezondGewichtMin, gezondGewichtMax);

            //loop
            Console.ReadKey();
        }
    }
}
