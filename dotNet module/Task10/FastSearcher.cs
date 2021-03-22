using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task10
{
    /// <summary>
    /// Поиск элементов в коллекции.
    /// </summary>
    /// <typeparam name="T">Тип элементов в коллекции.</typeparam>
    public class FastSearcher<T>
    {
        private IEnumerable<T> Data { get; set; }

        /// <summary>
        /// Условие поиска.
        /// </summary>
        /// <param name="x">Элемент коллекции.</param>
        /// <returns>Булевое значение.</returns>
        public delegate bool SearchCondition(T x);

        /// <summary>
        /// Максимальное количество задач.
        /// </summary>
        public int MaxTasks { get; }

        /// <summary>
        /// Минимальное количество значений в задаче.
        /// </summary>
        public int MinNumberOfValues { get; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="data">Заданная коллекция.</param>
        /// <param name="maxTasks">Максимальное количество задач.</param>
        /// <param name="minNumberOfValues">Минимальное количество значений в задаче.</param>
        public FastSearcher(IEnumerable<T> data, int maxTasks, int minNumberOfValues)
        {
            this.Data = data;
            this.MaxTasks = maxTasks;
            this.MinNumberOfValues = minNumberOfValues;
        }

        /// <summary>
        /// Поиск элементов в коллекции.
        /// </summary>
        /// <param name="sc">Условие поиска.</param>
        /// <returns>Отфильтрованная коллекция.</returns>
        public IEnumerable<T> Search(SearchCondition sc)
        {
            var result = new List<T>();
            var numberOfTasks = this.Data.Count() / this.MinNumberOfValues;
            if (numberOfTasks > this.MaxTasks) numberOfTasks = this.MaxTasks;
            var elementsInTask = (int)Math.Ceiling(this.Data.Count() / (decimal)numberOfTasks);
            var tasks = new Task[numberOfTasks];
            var dataPart = this.Data;
            for (int i = 0; i < tasks.Length; i++)
            {
                dataPart = this.Data.Skip(i * elementsInTask)
                    .Take(elementsInTask);
                var task = new Task(() => this.SearchInternal(sc, dataPart, result));
                tasks[i] = task;
                task.Start();
            }

            Task.WaitAll(tasks);
            return result;
        }

        private void SearchInternal(
            SearchCondition sc,
            IEnumerable<T> dataPart, 
            List<T> result)
        {
            foreach (var item in dataPart)
                if (sc(item))
                    result.Add(item);
        }
    }
}
