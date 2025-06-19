using System;

namespace SingletonPatternExample
{
    // Logger class ensures only one instance exists
    public sealed class Logger
    {
        private static Logger _instance = null;
        private static readonly object _syncLock = new object();

        // Private constructor prevents external creation
        private Logger() {}

        // Public method to get the single Logger instance
        public static Logger GetLogger()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        // Simple logging method
        public void Write(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Get Logger instances
            var log1 = Logger.GetLogger();
            var log2 = Logger.GetLogger();

            // Use the Logger
            log1.Write("First message from log1.");
            log2.Write("Second message from log2.");

            // Confirm both refer to the same instance
            Console.WriteLine(log1 == log2
                ? "Both log1 and log2 are the same instance."
                : "Different instances detected!");
        }
    }
}
