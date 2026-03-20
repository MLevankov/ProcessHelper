namespace ProcessHelper
{
    public class Logging
    {
        public enum LogType
        {
            Error = 0,
            Warning = 1,
            Info = 2,
            Success = 3
        }

        public static void Log(string path, string message, LogType type)
        {
            string date = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}";
            string time = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            string fullDate = $"Date: {date}\nTime: {time}";
            string prefix = type switch
            {
                LogType.Error => "[ERROR]",
                LogType.Warning => "[WARNING]",
                LogType.Info => "[INFO]",
                LogType.Success => "[SUCCESS]"
            };
            string fullMessage = $@"
{fullDate}

{prefix} {message}
";

            File.AppendAllText(path, fullMessage);
        }
    }
}
