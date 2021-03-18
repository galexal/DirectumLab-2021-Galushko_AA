using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

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
