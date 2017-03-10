using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Class contain the code for the assignment 1
    /// </summary>
    class Program
    {  
        /// <summary>
        /// Print in the console the results
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Firts say hello
            Console.WriteLine("WELCOME! this simple app can help you to calculate the distance between two points");
            //Get the x value from the user
            Console.WriteLine("Please enter the value in x for the FIRST point (1x): ");
            string value1X = Console.ReadLine();
            Console.WriteLine("Please enter the value in y for the FIRST point (1y): ");
            string value1Y = Console.ReadLine();
            Console.WriteLine("Please enter the value in x for the SECOND point (2x): ");
            string value2X = Console.ReadLine();
            Console.WriteLine("Please enter the value in y for the SECOND point (2y): ");
            string value2Y = Console.ReadLine();
            //Declare vars x and y
            float point1x;
            float point1y;
            float point2x;
            float point2y;
            //Parsing the values from string to float, if can't send console error
            if (float.TryParse(value1X, out point1x))
            {
                if (float.TryParse(value1Y, out point1y))
                {
                    if (float.TryParse(value2X, out point2x))
                    {
                        if (float.TryParse(value2Y, out point2y))
                        {
                            // calculate the delta values for the points
                            float deltaX = point2x - point1x;
                            float deltaY = point2y - point1y;
                            //distance between points
                            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
                            //Arctan to go from point 1 to point 2
                            double angle = Math.Atan2(deltaY, deltaX) * 180.0 / Math.PI;
                            //show results
                            Console.WriteLine("The deltaX is: " + deltaX + " and the deltaY is: " + deltaY);
                            Console.WriteLine("The distance between point is: " + distance.ToString("N03", CultureInfo.InvariantCulture));
                            Console.WriteLine("The distance to go from point 1 to point 2 is: " + angle.ToString("N03", CultureInfo.InvariantCulture));
                            Console.Read();
                        }
                        else
                        {
                            Console.WriteLine("Sorry your value for 2Y is wrong, please close and try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry your value for 2X is wrong, please close and try again");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry your value for 1Y is wrong, please close and try again");
                }
            }
            else
            {
                Console.WriteLine("Sorry your value for 1X is wrong, please close and try again");
            }
        }
    }
}
