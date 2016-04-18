using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Drive
{
    public partial class Editing : Form
    {
        public DriveInfo[] Drives { get; private set; }
        public DriveInfo CurrentDrive { get; private set; }
        public DirectoryInfo CurrentDirectory { get; private set; }
        public FileSystemInfo[] AllFilesAndDirs { get; private set; }
        //public FileSystemInfo[] SelectedFilesAndDirs { get; private set; }
        public FileSystemInfo SelectedFileOrDir { get; private set; }

        public Editing()
        {
            InitializeComponent();
        }

        private void ShowDirectory(DirectoryInfo dir)
        {
            CurrentDirectory = dir;
            pathTextBox.Text = CurrentDirectory.FullName;
            AllFilesAndDirs = CurrentDirectory.GetFileSystemInfos();
            contentListBox.DataSource = AllFilesAndDirs;
        }

        private void Editing_Load(object sender, EventArgs e)
        {
            Drives = DriveInfo.GetDrives();
            driveComboBox.DataSource = Drives;
        }

        private void driveComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CurrentDrive = (DriveInfo)driveComboBox.SelectedItem;
            ShowDirectory(CurrentDrive.RootDirectory);
        }

        private void contentListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedFileOrDir = (FileSystemInfo) contentListBox.SelectedItem;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (SelectedFileOrDir is DirectoryInfo)
            {
                ShowDirectory((DirectoryInfo)SelectedFileOrDir);
            }
            else if (SelectedFileOrDir is FileInfo)
            {
                FileInfo file = (FileInfo)SelectedFileOrDir;
                ContentForm form = new ContentForm(file);
                form.ShowDialog();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (CurrentDirectory.Parent != null)
            {
                ShowDirectory(CurrentDirectory.Parent);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string question = string.Format("Are you sure want to delete '{0}'?", SelectedFileOrDir.Name);
            DialogResult result = MessageBox.Show(question, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                SelectedFileOrDir.Delete();
                ShowDirectory(CurrentDirectory);
            }
        }

        private void contentListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                openButton_Click(sender, e);
            }
            else if (e.KeyCode.Equals(Keys.Back))
            {
                backButton_Click(sender, e);
            }
        }
    }
}
