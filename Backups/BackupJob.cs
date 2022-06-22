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
        private IStorage storage;
        public BackupJob(IStorage storage)
        {
            restorePoints = new List<RestorePoint>();
            jobObjects = new List<IJobObject>();
            this.storage = storage;
        }

        public IJobObject AddJobObject(IJobObject jobObject)
        {
            jobObjects.Add(jobObject);
            return jobObject;
        }

        public void DeleteJobObject(IJobObject jobObject)
        {
            jobObjects.Remove(jobObject);
        }

        public void Backup()
        {
            var p = new RestorePoint(jobObjects);
            storage.CreateBackup(p);
            restorePoints.Add(p);
        }
    }
}
