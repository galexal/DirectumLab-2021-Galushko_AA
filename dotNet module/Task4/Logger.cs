using System;
using System.IO;

namespace Task4
{
    public class Logger : IDisposable
    {
        private FileStream logFile;

        private StreamWriter logWriter;

        public Logger(string fileName)
        {
            this.logFile = new FileStream(fileName, FileMode.Append);
            this.logWriter = new StreamWriter(this.logFile);
        }

        public void WriteString(string data)
        {
            this.logWriter.WriteLine(data);
        }

        private bool disposed;

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.logWriter.Close();
                    this.logFile.Close();
                }
                this.disposed = true;
            }
        }
    }
}
