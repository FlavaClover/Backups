using System;
using System.Collections.Generic;
using System.IO;
using Backups.Interfaces;

namespace Backups
{
    public class BackupJob
    {
        private List<IJobObject> jobObjects;
        public BackupJob()
        {
            jobObjects = new List<IJobObject>();
        }
    }
}
