namespace GameUtils.IO
{
    public interface ILoger
    {
        void Log(string log);

        void Log(object log);

        void LogError(string log);

        void LogError(object log);

        void LogWarning(string log);

        void LogWarning(object log);
    }
}
