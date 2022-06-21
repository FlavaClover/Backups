using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class Storage : IStorage
    {
        public void CreateBackup(RestorePoint point)
        {
            string folderForCompress = "C:\\Users\\h-b-1\\Desktop\\Backup";
            string zipFolder = "C:\\Users\\h-b-1\\Desktop\\Backup.zip";

            for (int i = 0; i < point.JobObjects.Count; i++)
            {
                string sourceFile = point.JobObjects[i].Path; // исходный файл из RestorePoint
                string directory = Path.GetDirectoryName(sourceFile) + "\\Backup"; // путь до папки
                string fileInFolder = directory + "\\" + Path.GetFileName(sourceFile); // файл в папке
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // копирование файлов в папку
                CopyToFolder(sourceFile, fileInFolder);

                static void CopyToFolder(string sourceFile, string fileInFolder)
                {
                    File.Copy(sourceFile, fileInFolder, true);
                }
            }

            // архивирование папки
            ZipFile.CreateFromDirectory(folderForCompress, zipFolder);
        }

        public void SaveStorage(IBackupSaver backupSaver, List<IJobObject> filesToSave, RestorePoint restorePoint)
        {
            throw new NotImplementedException();
        }
    }
}
