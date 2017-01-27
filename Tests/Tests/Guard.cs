namespace Tests
{
    using System;

    public static class Guard
    {
        public static void Against<T>(bool condition) where T : Exception, new()
        {
            if (condition)
            {
                var instance = (T)Activator.CreateInstance(typeof(T));
                throw instance;
            }
        }

        public static void Against<T>(bool condition, string message) where T : Exception, new()
        {
            if (condition)
            {
                var instance = (T)Activator.CreateInstance(typeof(T), new object[] { message });
                throw instance;
            }
        }
        
        public static void Against<T>(bool condition, string message, Exception innerException) where T : Exception, new()
        {
            if (condition)
            {
                var instance = (T)Activator.CreateInstance(typeof(T), new object[] { message, innerException });
                throw instance;
            }
        }
    }
}
