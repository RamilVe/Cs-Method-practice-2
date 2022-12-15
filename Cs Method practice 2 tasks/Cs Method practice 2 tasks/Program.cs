using System;

namespace Cs_Method_practice_2_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(2, 4)); 

            //Console.WriteLine(Square(5));

            //Console.WriteLine(HasA("Ramil"));

            //Console.Write(SumofDigits(593));

            //Console.WriteLine(Avg(7, 36, 13, 24));

            //Console.WriteLine(Pow(6, 2));

            //Console.WriteLine(Biggest(24, 5, 19));

            //int[] nums = { 5, 16, 28, 34, 47 };
            //Console.WriteLine(NumSum(nums));

            //Console.WriteLine(FindBiggest(nums));

            //string str = "sagol";
            //string[] arr = { "Salam", "sagol", "Hello" };
            //Console.WriteLine(FindIndex(arr, str));

            //string[] names = { "Abbas", "Hik34met", "Salam1", "Sagol2", "Nermin" };

            //string sentence = "";

            //for (int i = 0; i < names.Length; i++)
            //{
            //    sentence += names[i];
            //}

            //Console.WriteLine(sentence);
            //Console.WriteLine(CountWords(names));

            //int[] numbers = { 3, 6, 24, -2, -4, 377, -65 };

            //var newNums = Positive(numbers);

            //Console.WriteLine("Positive numbers");
            //for (int i = 0; i < newNums.Length; i++)
            //{
            //    Console.WriteLine(newNums[i]);
            //}
        }
        #region Task 1
        //Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod

        //static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        #endregion

        #region Task 2
        //Verilmiş ədədin kvadratını qaytaran metod

        //static int Square(int num)
        //{
        //    return num * num;
        //}
        #endregion

        #region Task 3
        //Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod

        //static bool HasA(string word)
        //{
        //    bool hasA = false;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == 'a')
        //        {
        //            hasA = true;
        //            break;
        //        }
        //    }
        //    return hasA;
        //}
        #endregion

        #region Task 4
        //Verilmiş ədədin rəqəmləri cəmini qaytaran metod

        //static int SumofDigits(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        sum += num % 10;
        //        num = (num - num % 10) / 10;
        //    }
        //    return sum;
        //}
        #endregion

        #region Task 5
        //Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod

        //static int Avg(int num1, int num2, int num3, int num4)
        //{
        //    return (num1 + num2 + num3 + num4) / 4;
        //}
        #endregion

        #region Task 6
        //Verilmiş ədədin verilmiş qüvvətini tapan metod

        //static int Pow(int num, int power)
        //{
        //    int result = 1;
        //    for (int i = 0; i < power; i++)
        //    {
        //        result *= num;
        //    }
        //    return result;
        #endregion
        #region Task 7
        //Verilmiş 3 ədəddən ən böyüyünü tapan metod
        static int Biggest(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else if (num2 > num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        #endregion

        #region Task 8
        //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod

        static int NumSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        #endregion

        #region Task 9
        //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod

        static int FindBiggest(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        #endregion

        #region Task 10
        //Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod

        static int FindIndex(int[] numbers, int bigNum)
        {
            int max = numbers[0];
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == max)
                {
                    max = numbers[i];
                    index = i;
                }
            }
            return index;
        }
        #endregion

        #region Task 11
        //Verilmiş yazılar siyahısındaki(string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın
        static int FindIndex(string[] arr, string str)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == str)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Task 12
        //Verilmiş yazıda rəqəm olub olmadığını qaytaran metod

        static int FindIndex(char[] arr, char wantedChar)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedChar)
                    return i;
            }

            return -1;
        }

        static bool IsDigit(char chr)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            return FindIndex(digits, chr) != -1;
        }



        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        #region Task 13
        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

        static int CountWords(string[] strArr)
        {
            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (HasDigit(strArr[i]))
                {
                    count++;
                }
            }

            return count;
        }
        #endregion

    }
}
