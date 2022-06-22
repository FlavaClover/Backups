using System;
using System.IO;
using System.IO.Compression;
using Backups.Interfaces;

namespace Backups
{
    public class Split : IStorage
    {
        public Split() { }
        public void CreateBackup(RestorePoint point)
        {
            for (int i = 0; i < point.JobObjects.Count; i++)
            {
                string sourceFile = point.JobObjects[i].Path; // исходный файл из RestorePoint
                string directory = point.FolderForBU;
                string zipFile = Path.Combine(directory, Path.GetFileNameWithoutExtension(sourceFile) + ".zip");
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
