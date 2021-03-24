using System;

namespace TestLib1
{
    /// <summary>
    /// Класс для создания персонажа.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя персонажа.
        /// </summary>
        [Obsolete]
        public string FirstName { get; set; } = "Ivan";

        /// <summary>
        /// Фамилия персонажа.
        /// </summary>
        public string LastName { get; set; } = "Petrov";

        /// <summary>
        /// Возраст персонажа.
        /// </summary>
        public int Age { get; } = 20;

        /// <summary>
        /// Базовый конструктор класса Person.
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Конструктор класса Person.
        /// </summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="lastName">Фамилия.</param>
        /// <param name="age">Возраст.</param>
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
