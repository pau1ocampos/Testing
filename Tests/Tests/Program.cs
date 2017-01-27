using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Guard.Against<NullReferenceException>(1 == 3, "Error 1");
            Guard.Against<DivideByZeroException>(1 == 2, "Error");
        }
    }
}
