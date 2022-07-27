using System;

namespace method_overloading_return_type
{
    class Employee
    {
        public int MyMethod(int a,int b)
        {
            return a + b;
        }

        public string MyMethod(string a, string b)
        {
            return a + b;
        }

        public float MyMethod(float a, float b)
        {
            return a + b;
        }

        public double MyMethod(double a, double b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee();
            Console.WriteLine(E.MyMethod(1,3));
            Console.WriteLine(E.MyMethod("deep", "arun"));
            Console.WriteLine(E.MyMethod(1.5F, 2.5F));
            Console.WriteLine(E.MyMethod(12.5D, 13.5));
            Console.ReadLine();

        }
    }
}
