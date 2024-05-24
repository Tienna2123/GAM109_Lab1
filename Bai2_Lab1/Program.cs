using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai2_Lab1
{

    internal class Program
    {
        public class Maps
        {
            public string ID;
            public string Name;
            private static string _inGame = "Liên minh huyền thoại";

            public Maps(string id, string name)
            {
                ID = id;
                Name = name;
            }

            public string ShowData()
            {
                return "ID: " + ID + " Name: " + Name + " |inGame:  " + _inGame;
            }
        }
        static void Main(string[] args)
        {
            //bài 2
            var map1 = new Maps("2024", "URF");
            Console.WriteLine(map1.ShowData());

            var map2 = new Maps("2025", "ARAM");
            Console.WriteLine(map2.ShowData());
        }
    }
}
