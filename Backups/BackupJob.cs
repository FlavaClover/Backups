using System;
using System.Collections.Generic;
using System.IO;
using Backups.Interfaces;

namespace Backups
{
    public class BackupJob
    {
        private List<IJobObject> jobObjects;
        private List<RestorePoint> restorePoints;
        public BackupJob()
        {
            jobObjects = new List<IJobObject>();
        }

        public void AddJobObject(IJobObject jobObject)
        {
            jobObjects.Add(jobObject);
        }

        public void DeleteJobObject(IJobObject jobObject)
        {
            jobObjects.Remove(jobObject);
        }
    }
}
