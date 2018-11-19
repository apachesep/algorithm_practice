using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Controls;
using System.Net.Http;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Xml;
using System.Data;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Collections;

namespace Algorithm
{
    public class Hand {
        public string ObjectName { get; set; }
    }

    public class HandInventory : IEnumerable
    {
        public Hand Right { get; set; }
        public Hand Left { get; set; }
        public IEnumerator GetEnumerator()
        {
            return new HandInventoriator(this);
        }
    }
    public class HandInventoriator : IEnumerator
    {
        private HandInventory _instance { get; set; }

        private int index { get; set; } = -1;

        public HandInventoriator(HandInventory obj) {
            _instance = obj;
        }


        object IEnumerator.Current
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return _instance.Left;
                    case 1:
                        return _instance.Right;
                    default:
                        return null;
                }
            }
        }

        public bool MoveNext()
        {
     
            return ++index < 2;
        }

        public void Reset()
        {
            index = -1;
        }

    }

    public static class ExtensionLib {
        public static string GetClassName(this Type objType)
        {
            
            string result = objType.Name;
            if (objType.IsGenericType)
            {
                var name = objType.Name.Substring(0, objType.Name.IndexOf('`'));
                var genericTypes = objType.GenericTypeArguments;
                result = $"{name}<{string.Join(",", genericTypes.Select(GetClassName))}>";
            }
            return result;
        }
    }

    public static class ExtenstionArray
    {
        public static string ToRequestContent<T>(this T model) {
            var list = model.GetType().GetProperties()
                   .Select(x => new
                   {
                       val = x.GetValue(model).ToString(),
                       name = x.Name
                   })
                   .Select(z => string.Join("=", z.name, z.val));

            return string.Join("&", list);
        }

        public static void Swap(this IList<int> _arr, int a, int b)
        {
            if (a == b)
                return;
            _arr[a] ^= _arr[b];
            _arr[b] ^= _arr[a];
            _arr[a] ^= _arr[b];
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this
    IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();

            foreach (var element in source)
            {
                if (keySelector != null && seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T, int> action)
        {
            int i = 0;
            foreach (T item in sequence)
            {
                action(item, i);
                i++;
            }
        }
    }

    public class Posts
    {

        public string BTC { get; set; }
        public string DASH { get; set; }
        public string ETH { get; set; }
        public string LTC { get; set; }

    }


    class Program
    {
        
        static void Main(string[] args)
        {
            var jsonResponse = new Posts();

            

            var myDict = new Dictionary<string, string>();

            foreach (var prop in jsonResponse.GetType().GetProperties())
            {
                myDict.Add(prop.Name, prop.GetValue(jsonResponse)?.ToString());
            }


            var input = new int[] { 5, 4, 3, 2, 1 };
          
            MergeSort sort = new MergeSort();
            // , Username and message.
            var result = sort.Sort(input);
            //    Dictionary<MenuSelection, string> dict = new Dictionary<MenuSelection, string>();
            //    dict.Add(MenuSelection.CreateCustomer, "Create Customer");
            //    dict.Add(MenuSelection.CreateAccount, "Create Account");
            //    dict.Add(MenuSelection.SetAccountBalance, "Set Account Balance");
            //    dict.Add(MenuSelection.DisplayAccountBalance, "Display Account Balance");
            //    dict.Add(MenuSelection.Exit, "Exit");


            //    string showValue = string.Empty;
            //    for (int i = 1; i <= (int)MenuSelection.MaxMenuSelection; i++)
            //    {

            //        Console.WriteLine($"[{i}] { dict[(MenuSelection)i]}"); 
            //    }

            //左正常 右邊加一

            //float fl = 9.81234567f;//小數點最多到第六位 
            //float f2 = 9.81234568f;//小數點最多到第六位
            //Console.WriteLine(fl == f2);
            //decimal d1 = 1.2345678912234567891234568848m;
            //decimal d2 = 1.23456789122345678912345684m;
            //Console.WriteLine(d1==d2);



            Console.ReadKey();
        }
    }

}
