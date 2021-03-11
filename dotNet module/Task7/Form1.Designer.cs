
using System;
using System.IO;
using System.Windows.Forms;

namespace Task7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 426);
            this.richTextBox1.TabIndex = 0;
            var file = "q2.rtf.gz";
            try
            {
                LoadGZippedText(file, this.richTextBox1);
            }
            catch (FileNotFoundException ex)
            {
                System.Console.WriteLine(ex.Message);
                throw new FileLoadException (ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                System.Console.WriteLine(ex.Message);
                throw new FileLoadException(ex.Message);
            }
            finally
            {
                // Ресурсы освобождаются в самом методе в директивах using.
            }
            //this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        public void LoadGZippedText(string filename, RichTextBox edit)
        {
            using (var sourceStream = new System.IO.FileStream(filename,
                    System.IO.FileMode.Open, System.IO.FileAccess.Read,
                    System.IO.FileShare.Read))
            using (var uncompressedStream = new System.IO.Compression.GZipStream(
                    sourceStream, System.IO.Compression.CompressionMode.Decompress, true))
            using (var textReader = new System.IO.StreamReader(uncompressedStream, true))
                edit.Rtf = textReader.ReadToEnd();
        }


        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

