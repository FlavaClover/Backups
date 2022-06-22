using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class Single : IStorage
    {
        public Single() { }
        public void CreateBackup(RestorePoint point)
        {
            for (int i = 0; i < point.JobObjects.Count; i++)
            {
                string sourceFile = point.JobObjects[i].Path; // исходный файл из RestorePoint
                string directory = point.FolderForBU;
                string zipFile = Path.Combine(directory + "\\" + "Backup.zip");

                using (var zipToOpen = new FileStream(zipFile, FileMode.OpenOrCreate))
                {
                    using (var archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        archive.CreateEntryFromFile(sourceFile, Path.GetFileName(sourceFile));
                    }
                }
            }
        }
    }
}
