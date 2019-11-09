using System;
using System.Runtime.InteropServices;

namespace Kolokwium_Paweł_Skalski
{
    class MyClassFirst
    {
        public static float MakeNumberStandard(float number)
        {
            if (50 > number || number > 150)
            {
                throw new Exception("Number out of range, please give number between 50 and 150");
            }
            else
            {
                return (number - 50) / (150 - 50);
            }
        }
    }

    class MyClassSecond
    {
        public bool DoNumberAreCorrect(float[] array)
        {
            var index = 0;
            var result = true;
            foreach (var number in array)
            {
                if (number % index + 1 == 0)
                {
                    Console.WriteLine("Liczba: " + number + " o indeksie: " + index + " spełnia warunek");
                }
                else
                {
                    Console.WriteLine("Liczba: " + number + " o indeksie: " + index + " nie spełnia warunku");
                    result = false;
                }

                index -= -1;
            }

            return result;
        }
    }

    class MyClassThird
    {
        public void TryingMyLuck(int[][] array)
        {
            var max = 0;
            var bigestDepartmendId = 0;
            var newestWorkerId = -1;
            var index = 0;
            var newsestWordkerDepartmentId = 0;
            foreach (var subArray in array)
            {
                if (subArray.Length > max)
                {
                    max = subArray.Length;
                    bigestDepartmendId = index;
                }

                foreach (var worker in subArray)
                {
                    if (worker > newestWorkerId)
                    {
                        newestWorkerId = worker;
                        newsestWordkerDepartmentId = index;
                    }
                }

                index += 1;
            }

            Console.WriteLine("Dział z największą ilością pracowników to dział ma ID: " + bigestDepartmendId + " ma: " +
                              max + " pracowników");
            Console.WriteLine("Pracownik z najkrótszym stażem ma id: " + newestWorkerId + " pracuje w dziale o id: " +
                              newsestWordkerDepartmentId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
//            Zadanie pierwsze
            float[] table = new float[] {1, 2, 3, 4, 5};
            Console.WriteLine(MyClassFirst.MakeNumberStandard(22));


//            Zadanie drugie
            MyClassSecond myClassSecond = new MyClassSecond();
            myClassSecond.DoNumberAreCorrect(table);

//            Zadaanie trzecie
            int[][] array = new int[][] {new int[] {20, 2, 3, 4, 5, 7, 8}, new int[] {9, 10, 11, 12, 13, 14, 15, 16}};
            MyClassThird myClassThird = new MyClassThird();
            myClassThird.TryingMyLuck(array);
        }
    }
}