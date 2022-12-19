

namespace Licom
{
    public class length
    {
        public static void LineComparison()
        {
            Console.WriteLine("Enter the first coordinates (x1 & y1) : ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second coordinates (x2 & y2) : ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());

            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(temp1 + temp2);

            Console.WriteLine(result);


        }

    }
}

 

    

