using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Lab1
{
    public class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            MyClass obj = new MyClass(a, b);
            int kqcong = obj.cong(a,b);
            System.Console.WriteLine(kqcong);
            int kqtru = obj.tru(a,b);
            System.Console.WriteLine(kqtru);
            
        }
    }
}
