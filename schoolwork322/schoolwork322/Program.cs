using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolwork322
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int r1 = rand.Next(0, 43);
            int r2 = rand.Next(0, 43);
            int r3 = rand.Next(0, 43);
            int r4 = rand.Next(0, 43);
            int r5 = rand.Next(0, 43);
            int r6 = rand.Next(0, 43);
            Console.WriteLine();
            Console.WriteLine("                   本期中獎號碼為");
            Console.WriteLine("                -------------------");
            Console.WriteLine("                 {0:00} {1:00} {2:00} {3:00} {4:00} {5:00} ", r1, r2, r3, r4, r5, r6);
            Console.WriteLine("                --------------------");
            Console.WriteLine("                   歡迎下次購買");
            Console.WriteLine();
            Console.WriteLine("              0                0                            ");
            Console.WriteLine("             0  0             0  0                             ");
            Console.WriteLine("            0    0           0    0                        ");
            Console.WriteLine("           0      0 0 0 0 0 0      0                                          ");
            Console.WriteLine("          0                          0                          ");
            Console.WriteLine("         0                            0                          ");
            Console.WriteLine("         0      0 0         0 0       0                     ");
            Console.WriteLine("         0       0           0        0                         ");
            Console.WriteLine("         0                            0                ");
            Console.WriteLine("          0         0 0 0 0          0                ");
            Console.WriteLine("           0                       0                   ");
            Console.WriteLine("             0 0 0 0 0 0 0 0 0 0 0                           ");

            int count = 0;
            while (count<10)
            {
                int a1 = rand.Next(0, 43);
                int c2 = rand.Next(0, 43);
                int c3 = rand.Next(0, 43);
                int c4 = rand.Next(0, 43);
                int c5 = rand.Next(0, 43);
                int c6 = rand.Next(0, 43);
             Console.WriteLine("                 {0:00} {1:00} {2:00} {3:00} {4:00} {5:00} {6:00}", count, a1, c2, c3, c4, c5, c6);
                count = count + 1;
            }
           


            Console.ReadLine();
        }
    }
}
