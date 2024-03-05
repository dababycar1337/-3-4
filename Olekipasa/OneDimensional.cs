using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App34;
namespace App34
{
    sealed class OnedimensionalArray<T>: FunctionsForAllArrays
    {
        private T[] array;
        public OnedimensionalArray(int length, bool want = false)
        {
            array = new T[length];
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
            for(int i = 0; i < array.Length; i++)
            {
                if (typeof(T) == typeof(int))
                {
                    array[i] = (T)(object)Convert.ToInt32(Console.ReadLine());
                }
                if (typeof(T) == typeof(string))
                {
                    array[i] = (T)(object)Convert.ToString(Console.ReadLine());
                }
                if (typeof(T) == typeof(bool))
                {
                    array[i] = (T)(object)Convert.ToBoolean(Console.ReadLine());
                }
                if (typeof(T) == typeof(double))
                {
                    array[i] = (T)(object)Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public void AutoMaker()
        { 
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                if (typeof(T) == typeof(int))
                {
                    array[i] = (T)(object)rnd.Next(0, 11);
                }
                if (typeof(T) == typeof(string))
                {
                    array[i] = (T)(object)(rnd.Next(0, 11).ToString());
                }
                if (typeof(T) == typeof(bool))
                {
                    if(rnd.Next(0,2) == 1) 
                    {
                        array[i] = (T)(object)true;
                    }
                    else
                    {
                        array[i] = (T)(object)false;
                    }
                    
                }
                if (typeof(T) == typeof(double))
                {
                    array[i] = (T)(object)rnd.NextDouble();
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Массив: ");
            for(int i  = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
