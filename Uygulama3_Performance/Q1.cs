using System;
using System.Diagnostics;
                                //170541028 ABDULLAH YILDIZ
namespace Uygulama3_Q1
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            //For loop
            sw.Start();
            int i1 = 1; int i2 = 1;
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            for (int i = 1; i<30; i++)
            {
                int i3 = i1 + i2;
                Console.WriteLine(i3);
                i1= i2;
                i2 = i3;
            }
            sw.Stop();
            Console.WriteLine("for dongusu ile gecen sure: " + sw.Elapsed);

            //while loop
            sw.Start();
            i1 = 1; i2 = 1;
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            int j = 1;
            while(j<30)
            {
                int i3 = i1 + i2;
                Console.WriteLine(i3);
                i1 = i2;
                i2 = i3;
                j++;
            }
            sw.Stop();
            Console.WriteLine("while dongusu ile gecen sure" + sw.Elapsed);

            //do-while loop
            sw.Start();
            i1 = 1; i2 = 1;
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            int k = 1;
            do
            {
                int i3 = i1 + i2;
                Console.WriteLine(i3);
                i1 = i2;
                i2 = i3;
                k++;
            } while (k < 30);
            sw.Stop();
            Console.WriteLine("do-while dongusu ile gecen sure"+sw.Elapsed);

        }
    }
}
