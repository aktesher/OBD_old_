using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBD
{
    class Category
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Money { get; set; }

        public bool IsVisible { get; set; }
    }

    internal class DataBank
    {
        public static string NameUser = "";
        public static int UserId = -1;
        public static string ProfitUser = "0";
        public static string SpendingUser = "0";

        public static List<Category> Category = new List<Category>() { new Category(), new Category(), new Category(), new Category(), new Category(), new Category() };
        public static string MoneyCategory6 = "0";
        public static string MoneyCategory5 = "0";
        public static string MoneyCategory4 = "0";
        public static string MoneyCategory3 = "0";
        public static string MoneyCategory2 = "0";
        public static string MoneyCategory1 = "0";
    }
}
