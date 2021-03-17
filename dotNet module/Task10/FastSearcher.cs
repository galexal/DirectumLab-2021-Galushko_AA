using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task10
{
    public class FastSearcher<T>
    {
        private IEnumerable<T> Data { get; set; }


        public delegate bool SearchCondition(T x);

        public int MaxTasks { get; }

        public int MinNumberOfValues { get; }

        public FastSearcher(IEnumerable<T> data, int maxTasks, int minNumberOfValues)
        {
            this.Data = data;
            this.MaxTasks = maxTasks;
            this.MinNumberOfValues = minNumberOfValues;
        }

        public IEnumerable<T> Search(SearchCondition sc)
        {
            var result = new List<T>();
            var numberOfTasks = Enumerable.Count(this.Data) / this.MinNumberOfValues;
            if (numberOfTasks > this.MaxTasks) numberOfTasks = this.MaxTasks;
            var tasks = new Task[numberOfTasks];
            for (int i = 0; i < tasks.Length; i++)
            {
                var partOfData = this.Data;
                if (i == 0)
                    partOfData = this.Data.Take(this.MinNumberOfValues);
                else
                    partOfData = this.Data.Skip(i * this.MinNumberOfValues);

                var task = new Task(() => this.SearchInternal(sc, partOfData, result));
                tasks[i] = task;
                task.Start();
            }
            Task.WaitAll(tasks);
            return result;
        }

        private void SearchInternal(SearchCondition sc, IEnumerable<T> partOfData, List<T> result)
        {
            for (int i = 0; i < Enumerable.Count(partOfData); i++)
            {
                if (sc(Enumerable.ElementAt(partOfData, i)))
                {
                    result.Add(Enumerable.ElementAt(partOfData, i));
                }
            }
        }
    }
}
