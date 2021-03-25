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

        public static string GetSettings()
        {
            string result = string.Empty;
            var settings = ConfigurationManager.AppSettings;
            foreach (var key in settings.AllKeys)
            {
                result += $"Имя: {key}\nЗначение: {settings[key]}";
            }

            return result;
        }
    }
}
