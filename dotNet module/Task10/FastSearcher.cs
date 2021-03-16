using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task10
{
    public class FastSearcher<T>
    {
        private List<T> Data { get; set; }


        public delegate bool SearchCondition(T x);

        public int MaxTasks { get; }

        public int MinNumberOfValues { get; }

        public FastSearcher(IEnumerable<T> data, int maxTasks = 2, int minNumberOfValues = 10)
        {
            this.Data = (List<T>)data;
            this.MaxTasks = maxTasks;
            this.MinNumberOfValues = minNumberOfValues;
        }

        public List<T> Search(SearchCondition sc)
        {
            var result = new List<T>();
            var tasks = new Task[this.MaxTasks];
            for (int i = 0; i < this.MaxTasks; i++)
            {
                var startIndex = i * (this.Data.Count / this.MaxTasks);
                Task task = new Task(() => this.Find(sc, result, startIndex));
                tasks[i] = task;
                task.Start();
                if (this.Data.Count <= this.MinNumberOfValues) break;
            }
            if (tasks != null) Task.WaitAll(tasks);
            return result;
        }

        public void Find(SearchCondition sc, List<T> result, int startIndex)
        {
            for (int i = startIndex; i < startIndex + (this.Data.Count / this.MaxTasks); i++)
            {
                if (sc(this.Data[i]))
                {
                    result.Add(this.Data[i]);
                }
            }
        }
    }
}
