using System;

namespace var_local_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            char a1 = 'W';
            var a2 = 'M';
            Console.WriteLine(a2);
            Console.WriteLine("The Type of a2 {0}", a2.GetType().ToString());
            var agree = true;
            Console.WriteLine("The Type of agree {0}", agree.GetType().ToString());
            var courses = new[] { "Wesam", "Salah", "Anas" };
            Console.WriteLine("The Type of courses {0}", courses.GetType().ToString());
            var s1 = new { name = "Wesam Salah", age = 47 };
            Console.WriteLine("my name is {0}", s1.name);
        }
    }
}
