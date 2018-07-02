using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BigInteger n = 5;
            double n1 = (double)n + 1;
            BigInteger biganswer;
            int donut = (int)n1;
            BigInteger sum = 0; ;
            for (int i = donut; i >0; i--)
            {
                double phi = (1 + Math.Sqrt(5)) * 0.5;
                double answer = (Math.Pow(phi, i) - Math.Pow((1 - phi), i)) / (Math.Sqrt(5));
                biganswer = (BigInteger)answer * 4;
                sum = sum + biganswer;
            }
            return (sum);*/

            string num1 = "101";
            string num2 = "10";

            char[] array1 = num1.ToCharArray();
            char[] array2 = num2.ToCharArray();
            Array.Reverse(array1);
            num1 = new string(array1);
            Array.Reverse(array2);
            num2 = new string(array2);
            int[] cool = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384};
            int final1 = 0;
            int final2 = 0;
            int final = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                string convert1 = array1[i].ToString();
                int parse1 = int.Parse(convert1);
                int bin1 = parse1 * cool[i];
                final1 = final1 + bin1;
            }
            for (int j = 0; j < array2.Length; j++)
            {
                string convert2 = array2[j].ToString();
                int parse2 = int.Parse(convert2);
                int bin2 = parse2 * cool[j];
                final2 = final2 + bin2;
            }

            final = final1 + final2;
            Console.WriteLine(final);
            Console.ReadLine();

        }
    }
}
