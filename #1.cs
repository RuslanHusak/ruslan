using System;

namespace еліпс
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x*x/4+y*y/1<1)||(x>1)&&(x<-1)
            Console.WriteLine("YES");
            else
            Console.WriteLine("NO");
            
        }
    }
}
