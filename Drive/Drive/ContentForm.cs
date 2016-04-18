using System;
using System.IO;
using System.Windows.Forms;

namespace Drive
{
    public partial class ContentForm : Form
    {
        public FileInfo File { get; }
        public string Content { get; }

        public ContentForm(FileInfo file)
        {
            InitializeComponent();
            File = file;
            ReadContent();
        }

        private void ReadContent()
        {
            using (StreamReader reader = File.OpenText())
            {
                contentBox.Text = reader.ReadToEnd();
            }
        }
    }
}
