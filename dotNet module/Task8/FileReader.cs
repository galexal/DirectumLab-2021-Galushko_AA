using System;
using System.Collections;
using System.IO;

namespace Task8
{
    public class FileReader : IDisposable, IEnumerable, IEnumerator
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

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get
            {
                if ((this.Line = this.reader.ReadLine()) != null)
                    return this.Line;
                else
                    throw new InvalidOperationException();
            }
        }

        public bool MoveNext()
        {
            if ((this.Line = this.reader.ReadLine()) != null)

                return true;
            else
                return false;
        }

        public void Reset()
        {
            this.reader.Dispose();
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
