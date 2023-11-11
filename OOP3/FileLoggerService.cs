namespace OOP3
{
    public partial class DataBaseLoggerService
    {
        public class FileLoggerService : ILoggerService
        {
            public void Log()
            {
                Console.WriteLine("Dosyaya loglandı.");
            }
        }
    }
}
