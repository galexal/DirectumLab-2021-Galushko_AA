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
            var numberOfTasks = this.Data.Count() / this.MinNumberOfValues;
            if (numberOfTasks > this.MaxTasks) numberOfTasks = this.MaxTasks;
            var tasks = new Task[numberOfTasks];
            var dataPart = this.Data;
            for (int i = 0; i < tasks.Length; i++)
            {
                dataPart = this.Data.Skip(i * this.MinNumberOfValues)
                    .Take(this.MinNumberOfValues);
                var task = new Task(() => this.SearchInternal(sc, dataPart, result));
                tasks[i] = task;
                task.Start();
            }
            Task.WaitAll(tasks);
            return result;
        }

        private void SearchInternal(SearchCondition sc, 
            IEnumerable<T> dataPart, List<T> result)
        {
            foreach (var item in dataPart)
                if (sc(item))
                    result.Add(item);
        }
    }
}
