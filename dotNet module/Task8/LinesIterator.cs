using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class LinesIterator
    {
        public List<string> Lines { get; set; } = new List<string>();

        public LinesIterator(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
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
    }
}
