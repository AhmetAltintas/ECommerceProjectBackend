﻿namespace Business.CCS
{
    public class DatabaseLoger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
