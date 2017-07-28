using System;

namespace GuardCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Guard.Evaluate<DivideByZeroException>(true, "Cannot divide by zero.");
        }
    }
}
