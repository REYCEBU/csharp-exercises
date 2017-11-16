using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double Area;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            Area = (3.14) * r * r;
            Console.WriteLine("The Area of circle of given radius is=" + Area);
            Console.ReadLine();

        }
    }
}
