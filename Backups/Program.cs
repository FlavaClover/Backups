using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Backups
{
    internal class Program
    {
        private static void Main()
        {
            var storage = new Storage();
            var backupJob = new BackupJob(storage);
            backupJob.AddJobObject(new TxtFile(@"C:\Users\h-b-1\Desktop\A.txt"));
            backupJob.AddJobObject(new TxtFile(@"C:\Users\h-b-1\Desktop\B.txt"));
            backupJob.Backup();
        }
    }
}
