using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace SeekAndArchive
{
    class Program
    {
        static List<FileInfo> foundFiles;
        static List<FileSystemWatcher> watchers;
        static List<DirectoryInfo> archiveDirs;

        static void Main(string[] args)
        {
            string fileName = args[0];
            string directoryName = args[1];
            foundFiles = new List<FileInfo>();

            DirectoryInfo rootDir = new DirectoryInfo(directoryName);
            if (!rootDir.Exists)
            {
                System.Console.WriteLine("The specified directory does not exist.");
                return;
            }

            RecursiveSearch(foundFiles, fileName, rootDir);
            Console.WriteLine("Found {0} files.", foundFiles.Count);
            foreach (FileInfo fil in foundFiles)
            {
                Console.WriteLine("{0}", fil.FullName);
            }

            watchers = new List<FileSystemWatcher>();

            archiveDirs = new List<DirectoryInfo>();

            for (int i = 0; i < foundFiles.Count; i++)
            {
                archiveDirs.Add(Directory.CreateDirectory("archive" +
                i.ToString()));
            }

            foreach (FileInfo fil in foundFiles)
            {
                FileSystemWatcher newWatcher = new FileSystemWatcher(fil.DirectoryName, fil.Name);
                newWatcher.Changed += new FileSystemEventHandler(WatcherChanged);

                newWatcher.EnableRaisingEvents = true;
                watchers.Add(newWatcher);
            }

            Console.ReadKey();
        }

        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            foreach (FileInfo fil in currentDirectory.GetFiles())
            {
                if (fil.Name == fileName)
                    foundFiles.Add(fil);
            }

            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                RecursiveSearch(foundFiles, fileName, dir);
            }
        }

        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("{0} has been changed!", e.FullPath);

            FileSystemWatcher senderWatcher = (FileSystemWatcher)sender;
            int index = watchers.IndexOf(senderWatcher, 0);

            ArchiveFile(archiveDirs[index], foundFiles[index]);
        }


        static void ArchiveFile(DirectoryInfo archiveDir, FileInfo fileToArchive)
        {
            FileStream input = fileToArchive.OpenRead();
            FileStream output = File.Create(archiveDir.FullName + @"\" + fileToArchive.Name + ".gz");

            GZipStream compressor = new GZipStream(output, CompressionMode.Compress);

            int b = input.ReadByte();

            while (b != -1)
            {
                compressor.WriteByte((byte)b);
                b = input.ReadByte();
            }

            compressor.Close();
            input.Close();
            output.Close();
        }

    }
}
