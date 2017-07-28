namespace Tests
{
    using System;

    public class CookieMealException : Exception
    {
        public CookieMealException() { }

        public CookieMealException(string message) : base (message) { }
    }
}
