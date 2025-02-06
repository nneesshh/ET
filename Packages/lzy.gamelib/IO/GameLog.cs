using System;

namespace GameUtils.IO
{
    public static class GameLog
    {
        private static ILoger logger;

        public static void SetLogger(ILoger newLogger)
        {
            logger = newLogger;
        }

        public static void LogError(string log)
        {
            EnsureLogger();
            logger.LogError(log);
        }

        public static void LogError(object log)
        {
            EnsureLogger();
            logger.LogError(log);
        }

        public static void Log(string log)
        {
            EnsureLogger();
            logger.Log(log);
        }

        public static void Log(object log)
        {
            EnsureLogger();
            logger.Log(log);
        }

        public static void LogWarning(string log)
        {
            EnsureLogger();
            logger.LogWarning(log);
        }

        public static void LogWarning(object log)
        {
            EnsureLogger();
            logger.LogWarning(log);
        }

        private static void EnsureLogger()
        {
            if (logger == null)
            {
                throw new InvalidOperationException("Logger has not been set. Call SetLogger before using the log methods.");
            }
        }
    }
}
