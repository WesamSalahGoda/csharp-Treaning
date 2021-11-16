using System;

namespace pointer_visual_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'W';
            unsafe
            {
                char* ptr = &a;
                Console.WriteLine((long)ptr);
                Console.WriteLine(*ptr);
            }
        }
    }
}
