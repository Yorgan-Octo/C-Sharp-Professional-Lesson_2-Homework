using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {

        //public class Comparison : IEqualityComparer<int>
        //{

        //    CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        //    public int GetHashCode(int obj)
        //    {
        //        return obj.GetHashCode();
        //    }

        //    public bool Equals(int x, int y)
        //    {
        //        return comparer.Compare(x, y) == 0;
        //    }
        //}




        static void Main(string[] args)
        {

            Dictionary<int, double> companyAccount = new Dictionary<int, double>()
            {
                { 123954, 5443.34},
                { 457954, 1243.11},
                { 566754, 12343.24},
                { 562354, 5343.37},
                { 737895, 5443.78},
                { 856894, 5553343.56},
                { 563455, 54132453.45}

            };

            companyAccount.Add(1234567, 5443.34);

            //companyAccount.Add(1234567, 5443.34); //буде помилка

            foreach (var item in companyAccount)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }



            SortedDictionary<int, double> sortedDict = new SortedDictionary<int, double>()
            {
                { 123954, 5443.34},
                { 457954, 1243.11},
                { 566754, 12343.24},
                { 562354, 5343.37},
                { 737895, 5443.78},
                { 856894, 5553343.56},
                { 563455, 54132453.45}
            };

            sortedDict.Add(163455, 1000.5);
            sortedDict.Add(113455, 10800.5);
            //sortedDict.Add(563455, 10800.41); //буде помилка

            Console.WriteLine();
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }



            Console.ReadKey();
        }
    }
}
