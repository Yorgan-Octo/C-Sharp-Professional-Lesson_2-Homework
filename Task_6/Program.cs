using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{

    public class SortComparer<T> : IComparer<T>
    {

        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(T x, T y)
        {
            return comparer.Compare(y, x);
        }


    }


    internal class Program
    {
        static void Main()
        {

            SortedList<string, int> myColection = new SortedList<string, int>();

            myColection.Add("Магнус Карлсен", 2847);
            myColection.Add("Фабиано Каруана", 2820);
            myColection.Add("Левон Аронян", 2797);
            myColection.Add("Вишванатан Ананд", 2753);
            myColection.Add("Шхрияр Мамедьяров", 2750);


            SortedList<string, int> myColectionRevers = new SortedList<string, int>(new SortComparer<string>());

            myColectionRevers.Add("Магнус Карлсен", 2847);
            myColectionRevers.Add("Фабиано Каруана", 2820);
            myColectionRevers.Add("Левон Аронян", 2797);
            myColectionRevers.Add("Вишванатан Ананд", 2753);
            myColectionRevers.Add("Шхрияр Мамедьяров", 2750);


            foreach (var item in myColection)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine(new String('-', 50));

            foreach (var item in myColectionRevers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }


            Console.WriteLine(new String('-', 50));

            //як вариант 
            myColection.IsDescendingSort();


            Console.WriteLine(new String('-', 50));

            //туплватый але як вариант 
            myColection.IsDesForSort();

            Console.ReadKey();
        }

    }

    public static class Extenthis
    {
        public static void IsDescendingSort<T, R>(this SortedList<T, R> sortedList)
        {
            var temp = sortedList;

            sortedList = new SortedList<T, R>(new SortComparer<T>());

            foreach (var item in temp)
            {
                sortedList.Add(item.Key, item.Value);
            }
            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }


        public static void IsDesForSort<T, R>(this SortedList<T, R> sortedList)
        {
            T[] key = new T[sortedList.Count];
            R[] val = new R[sortedList.Count];

            int i = sortedList.Count -1;
            foreach (var item in sortedList)
            {
                key[i] = item.Key;
                val[i] = item.Value;
                i--;
            }

            key.Reverse();
            val.Reverse();

            for (int j = 0; j < sortedList.Count; j++)
            {
                Console.WriteLine($"{key[j]} - {val[j]}");
            }
        }
    }
}
