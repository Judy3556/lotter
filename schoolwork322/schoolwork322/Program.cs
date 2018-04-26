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
            //創建一個新的隨機亂數生成器
            Random rand = new Random();

            //在0到43之間產生6個亂數作為中獎號碼
            int r1 = rand.Next(0, 43);
            int r2 = rand.Next(0, 43);
            int r3 = rand.Next(0, 43);
            int r4 = rand.Next(0, 43);
            int r5 = rand.Next(0, 43);
            int r6 = rand.Next(0, 43);

            //列出所產生的中獎號碼
            Console.WriteLine("                    超級大樂透");
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

            //定義一個計算數量的數
            int count = 0;

            //定義該程式隨機在0到43範圍內生成6個數且該程式只能運行10次
            while (count < 10)
            {
                int a1 = rand.Next(0, 43);
                int c2 = rand.Next(0, 43);
                int c3 = rand.Next(0, 43);
                int c4 = rand.Next(0, 43);
                int c5 = rand.Next(0, 43);
                int c6 = rand.Next(0, 43);
                Console.WriteLine("              {0:00} {1:00} {2:00} {3:00} {4:00} {5:00} {6:00}", count, a1, c2, c3, c4, c5, c6);
                count = count + 1;
            }

            //觀察結果
            Console.ReadLine();
        }
    }
}
