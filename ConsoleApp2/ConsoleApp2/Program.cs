using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 clase = new Class1();
            Assembly assembly = Assembly.LoadFrom("ClassLibrary1.dll");
            Type claseType = clase.GetType();

            PropertyInfo[] properties = claseType.GetProperties();
            MethodInfo[] methods = claseType.GetMethods();
        }
    }
}
