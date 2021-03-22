using System;
using System.Linq;

namespace Task12
{
    /// <summary>
    /// Основной класс с методом Main.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Параметры запуска.</param>
        public static void Main(string[] args)
        {
            var tom = new Person("Tom", "Jonson", 30);
            Console.WriteLine(GetPropertiesTypesAndValues(tom));

            MakeInstanceAndGetPropertiesValues("Task12", "Task12.Person");
        }

        /// <summary>
        /// Получение имен и значений read-write свойств объекта, не помеченных аттрибутом absolete.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="obj">Имя объекта.</param>
        /// <returns name="string">Имена и значения read-write свойств объекта.</returns>
        private static string GetPropertiesTypesAndValues<T>(T obj)
        {
            var result = string.Empty;
            var myType = obj.GetType();
            Console.WriteLine("Свойства:");
            foreach (var prop in myType.GetProperties()
                .Where(prop => !prop.GetCustomAttributes(false)
                .OfType<ObsoleteAttribute>().Any()))
            {
                if (prop.CanWrite && prop.CanRead)
                    result += $"{prop.Name} {prop.GetValue(obj)}\n";
            }

            return result;
        }

        /// <summary>
        /// Создание объекта и вывод значений его свойств.
        /// </summary>
        /// <param name="assamblyPath">Путь к сборке.</param>
        /// <param name="className">Имя класса.</param>
        private static void MakeInstanceAndGetPropertiesValues(string assamblyPath, string className)
        {
            var myType = Type.GetType($"{className}, {assamblyPath}", false, true);
            var obj = Activator.CreateInstance(myType);
            foreach (var prop in myType.GetProperties())
            {
                Console.WriteLine($"{prop.GetValue(obj)}\n");
            }
        }
    }
}
