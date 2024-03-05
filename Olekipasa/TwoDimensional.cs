using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App34;
namespace App34
{
    sealed class TwoDimensionalArray<T>: FunctionsForAllArrays
    {
        private T[,] array;
        public TwoDimensionalArray(int length1, int length2, bool want = false)
        {
            array = new T[length1, length2];
            if (want)
            {
                UserMaker();
            }
            else
            {
                AutoMaker();
            }
        }

        public void UserMaker()
        {
            Console.WriteLine("Выбранный тип данных: " + typeof(T));
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (typeof(T) == typeof(int))
                    {
                        array[i, j] = (T)(object)Convert.ToInt32(Console.ReadLine());
                    }
                    if (typeof(T) == typeof(string))
                    {
                        array[i, j] = (T)(object)Convert.ToString(Console.ReadLine());
                    }
                    if (typeof(T) == typeof(bool))
                    {
                        array[i, j] = (T)(object)Convert.ToBoolean(Console.ReadLine());
                    }
                    if (typeof(T) == typeof(double))
                    {
                        array[i, j] = (T)(object)Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
        }

        public void AutoMaker()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (typeof(T) == typeof(int))
                    {
                        array[i, j] = (T)(object)rnd.Next(0, 11);
                    }
                    if (typeof(T) == typeof(string))
                    {
                        array[i, j] = (T)(object)(rnd.Next(0, 11).ToString());
                    }
                    if (typeof(T) == typeof(bool))
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            array[i, j] = (T)(object)true;
                        }
                        else
                        {
                            array[i, j] = (T)(object)false;
                        }

                    }
                    if (typeof(T) == typeof(double))
                    {
                        array[i, j] = (T)(object)rnd.NextDouble();
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}

