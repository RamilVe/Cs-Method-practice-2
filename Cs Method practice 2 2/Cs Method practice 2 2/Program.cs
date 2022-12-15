using System;

namespace Cs_Method_practice_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 6, 98, -2, -4, 344, -65 };

            var newNums = FilterPositive(numbers);

            Console.WriteLine("Positive numbers");
            for (int i = 0; i < newNums.Length; i++)
            {
                Console.WriteLine(newNums[i]);
            }

            Console.WriteLine(TrimLeft(" salam sag ol"));
            Console.WriteLine(FindFirstNonSpaceIndex("     salam sag ol   "));
            Console.WriteLine(FindLastNonSpaceIndex("salam sag ol            "));
            Console.WriteLine(Trim("     salam sagol      "));
        }

        //Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod.
        static int[] FilterPositive(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;

            }

            int j = 0;
            int[] positiveNumbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveNumbers[j] = numbers[i];
                    j++;
                }
            }

            return positiveNumbers;
        }

        //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
        static int FindFirstNonSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length;i++)
            {
                if (str[i] != ' ')
                    return i;
            }

            return -1;
        }
        //Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod

        static int FindLastNonSpaceIndex(string str)
        {
            for (int i = str.Length-1; i < str.Length; i--) 
            {
                if (str[i] == ' ')
                    return i;
            }

            return -1;
        }

        //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string TrimLeft(string str)
        {
            var startIndex = FindFirstNonSpaceIndex(str);
            string newStr = "";
            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        //Verilmiş yazını sol və sağ tərəflərində boşluq olmayan vəziyyətdə qaytaran metod
        static string TrimRight(string str)
        {
            var lastIndex = FindLastNonSpaceIndex(str);
            string newStr = "";
            for (int i = 0; i < lastIndex; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }
        
        static string Trim(string str)
        {
            string newstr = "";
            TrimLeft(str);
            TrimRight(str);

            return newstr;
        }
    }
}
