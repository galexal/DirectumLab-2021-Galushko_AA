using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Task8
{
    public class FileReader : IDisposable, IEnumerable, IEnumerator
    {
        public string Path { get; set; }

        public List<string> Lines { get; set; } = new List<string>();

        private int position = -1;

        private bool disposed = false;

        public FileReader(string path)
        {
            this.Path = path;
        }

        public void Read()
        {
            using (StreamReader sr = new StreamReader(this.Path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    this.Lines.Add(line);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this.Lines.GetEnumerator();
        }

        public object Current
        {
            get
            {
                if (this.position == -1 || this.position >= this.Lines.Count)
                    throw new InvalidOperationException();
                return this.Lines[this.position];
            }
        }

        public bool MoveNext()
        {
            if (this.position < this.Lines.Count - 1)
            {
                this.position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            this.position = -1;
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
                    // какие ресурсы нужно в данном случае освобождать?
                }
                this.disposed = true;
            }
        }
    }
}
