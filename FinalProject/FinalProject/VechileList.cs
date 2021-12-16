using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class VechileList
    {
        public static List<Vechile> list;
        public static Vechile Searched = null;
        public static void AddVechile(Vechile vec)
        {
            list.Add(vec);
        }
        public static List<Vechile> vechilelist()
        {
            return list;
        }

        public static void SetSearch(Vechile vech)
        {
            Searched = vech;
        }

        public static Boolean search;

        public static string SearchedItem;
    }
}
