using System;
using System.Configuration;

namespace Task12
{
    /// <summary>
    /// Чтение настроек файла конфигурации.
    /// </summary>
    public class ConfigReader
    {
        /// <summary>
        /// Чтение настроек файла конфигурации.
        /// </summary>
        public static void PrintSettings()
        {
            var settings = ConfigurationManager.AppSettings;
            foreach (var key in settings.AllKeys)
            {
                Console.WriteLine($"Имя: {key}\nЗначение: {settings[key]}");
            }
        }
    }
}
