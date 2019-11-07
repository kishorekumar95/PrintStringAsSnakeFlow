using System;

namespace SnakeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String");
            SnakeString(Console.ReadLine());           
        }

        private static void SnakeString(String enteredString)
        {
            var flag = 0;
            for (var i = 0; i < enteredString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (flag % 2 == 0)
                    {
                        Console.WriteLine(enteredString[i].ToString().PadLeft(1, ' '));
                    }
                    else
                    {
                        Console.WriteLine(enteredString[i].ToString().PadLeft(7, ' '));
                    }
                    flag++;
                }
                else
                {
                    Console.WriteLine(enteredString[i].ToString().PadLeft(4, ' '));
                    flag = flag != 2 ? flag : 0;
                }
            }
        }
    }
}
