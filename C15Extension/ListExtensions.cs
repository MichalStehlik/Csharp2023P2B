using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C15Extension
{
    internal static class ListExtensions
    {
        public static int OddCount(this List<int> data) 
        {
            int i = 0;
            foreach (var item in data)
            {
                if (item % 2 == 1)
                {
                    i++;
                }
            }
            return i;
        }

        /*
        public static int OddCount(List<int> data)
        {
            int i = 0;
            foreach (var item in data)
            {
                if (item % 2 == 1)
                {
                    i++;
                }
            }
            return i;
        }
        */
        public static int GreaterThen(this List<int> data, int value)
        {
            int i = 0;
            foreach (var item in data)
            {
                if (item > value)
                {
                    i++;
                }
            }
            return i;
        }

        public static int ItemsCount<T>(this List<T> data) 
        { 
            return data.Count; 
        }

        public static List<int> Odd(this List<int> data)
        {
            var list = new List<int>();
            foreach (var item in data)
            {
                if (item % 2 == 1) { list.Add(item); }
            }
            return list;
        }

        public static List<string> LongerThen(this List<string> data, int length)
        {
            var list = new List<string>();
            foreach (var item in data)
            {
                if (item.Length > length) { list.Add(item); }
            }
            return list;
        }
    }
}
