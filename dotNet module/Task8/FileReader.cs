using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task8
{
    public class FileReader : IDisposable, IEnumerable<string>, IEnumerator<string>
    {
        public string Path { get; set; }

        private bool disposed = false;

        private StreamReader reader;

        public string Line { get; set; }

        public FileReader(string path)
        {
            this.Path = path;
            this.reader = new StreamReader(this.Path, System.Text.Encoding.Default);
        }

        //public List<string> LineFilterByDateSortedByTime(DateTime date)
        //{
        //    this.reader = new StreamReader(this.Path, System.Text.Encoding.Default);
        //    var list = new List<string>();
        //    while ((this.Line = this.reader.ReadLine()) != null)
        //        list.Add(this.Line);
        //    return list.Where(line => line.Substring(0, 10) == date.ToString("dd.MM.yyyy"))
        //        .OrderByDescending(time => time.Substring(12, 8))
        //        .ToList();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public IEnumerator<string> GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get
            {
                return this.Line;
            }
        }

        //object IEnumerator.Current => throw new NotImplementedException();

        string IEnumerator<string>.Current => this.Line;

        public bool MoveNext()
        {
            if ((this.Line = this.reader.ReadLine()) != null)

                return true;
            else
                return false;
        }

        public void Reset()
        {
            this.reader.BaseStream.Position = 0;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.reader.Close();
                }
                this.disposed = true;
            }
        }

 
    }
}
