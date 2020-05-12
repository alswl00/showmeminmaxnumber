using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int max, min;
            for(int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            max = num[0]; min = num[0];
            for(int i=1;i<5;i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("가장 큰 수: "+ max);
            Console.WriteLine("가장 작은 수: " + min);
        }
    }
}
