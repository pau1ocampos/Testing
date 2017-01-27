namespace Tests
{
    using System;

    public class CookieMealException : Exception
    {
        public CookieMealException() : base() { }

        public CookieMealException(string message) : base (message) { }
    }
}
