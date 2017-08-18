  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring
{
    class Program
    {
        static void Main(string[] args)
        {
            float salad = 5.12f;
            float totalNow = 27.10f;
            Console.WriteLine(totalNow + salad);

            float monty = 16.72f;
            float larry = 4.12f;
            Console.WriteLine(larry + monty);


            int middleNum = (8640/ 3);
            int smallNum = (middleNum - 1);
            int largeNum = (middleNum + 1);
            Console.WriteLine(smallNum);
            Console.WriteLine(middleNum);
            Console.WriteLine(largeNum);
        }
    }
}
