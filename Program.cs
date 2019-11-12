using System;
using System.Linq;
using System.Text;

namespace SnakeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String");
            MString(Console.ReadLine());
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

        private static void MString(string enteredString)
        {
            var lineOne = new StringBuilder();
            var lineThree = new StringBuilder();
            var lineTwo = new StringBuilder();

            var j = 0;
            var k = 0;
            var l = 0;
            var space = " ";

            for (int i = 0; i < enteredString.Length; i++,j++,k++,l++)
            {

                lineOne = j % 4 == 0 ? lineOne.Append(enteredString[j]) : lineOne.Append(space);
                lineTwo = k % 2 == 1 ? lineTwo.Append(enteredString[k]) : lineTwo.Append(space);
                lineThree = l % 2 == 0 && l % 4 != 0 ? lineThree.Append(enteredString[l]) : lineThree.Append(space);
            }

            Console.WriteLine(lineThree);
            Console.WriteLine(lineTwo);
            Console.WriteLine(lineOne);
        }
    }
}
