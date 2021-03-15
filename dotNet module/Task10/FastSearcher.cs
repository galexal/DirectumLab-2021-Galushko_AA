using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task10
{
    public class FastSearcher
    {
        public List<int> Data { get; set; }

        public List<int> Result { get; set; } = new List<int>();

        public delegate bool SearchCondition(int x);

        public int MaxTasks { get; set; } = 1;

        public int MinNumberOfValues { get; set; } = 10;

        public FastSearcher(List<int> data, int maxTasks = 1, int minNumberOfValues = 10)
        {
            this.Data = data;
            this.MaxTasks = maxTasks;
            this.MinNumberOfValues = minNumberOfValues;
        }

        public void TaskMaker(SearchCondition sc)
        {
            var tasks = new Task[this.MaxTasks];
            for (int i = 0; i < this.MaxTasks; i++)
            {
                Task task = new Task(() => this.Find(sc));
                tasks[i] = task;
                task.Start();
                if (this.Data.Count <= this.MinNumberOfValues) break;
            }
            if (tasks != null) Task.WaitAll(tasks);
        }

        public void Find(SearchCondition sc)
        {
            for (int i = 0; i < this.Data.Count; i++)
            {
                if (sc(this.Data[i]))
                {
                    this.Result.Add(this.Data[i]);
                }
            }
        }
    }
}
