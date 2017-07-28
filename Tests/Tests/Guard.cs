namespace Tests
{
    using System;

    public static class Guard
    {
        public static void Evaluate<T>(bool condition) where T : Exception, new()
        {
            if (!condition)
            {
                return;
            }

            var instance = (T)Activator.CreateInstance(typeof(T));
            throw instance;
        }

        public static void Evaluate<T>(bool condition, string message) where T : Exception, new()
        {
            if (!condition)
            {
                return;
            }

            var instance = (T)Activator.CreateInstance(typeof(T), message);
            throw instance;
        }
        
        public static void Evaluate<T>(bool condition, string message, Exception innerException) where T : Exception, new()
        {
            if (!condition)
            {
                return;
            }

            var instance = (T)Activator.CreateInstance(typeof(T), message, innerException);
            throw instance;
        }
    }
}
