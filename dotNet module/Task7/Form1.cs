using System;
using System.IO;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.richTextBox1.Rtf = LoadGZippedText("q2.rtf.gz");
        }

        public string LoadGZippedText(string filename)
        {
            try
            {
                using (var sourceStream = new System.IO.FileStream(filename,
                System.IO.FileMode.Open, System.IO.FileAccess.Read,
                System.IO.FileShare.Read))
                using (var uncompressedStream = new System.IO.Compression.GZipStream(
                        sourceStream, System.IO.Compression.CompressionMode.Decompress, true))
                using (var textReader = new System.IO.StreamReader(uncompressedStream, true))
                    return textReader.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                throw new LoadFileException(ex.Message, ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new LoadFileException(ex.Message, ex);
            }
        }
    }
}
