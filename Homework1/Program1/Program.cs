using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "";
            string num2 = "";
            int b = 0;
            int n = 0;
            Console.Write("请输入第一个数字：");
            num1 = Console.ReadLine();
            n = Int32.Parse(num1);
            Console.Write("请输入第二个数字：");
            num2 = Console.ReadLine();
            b = Int32.Parse(num2);
            Console.Write("结果:" + n * b);
        }
    }
}
