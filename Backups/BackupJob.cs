using System;
using System.Collections.Generic;
using System.IO;
using Backups.Interfaces;

namespace Backups
{
    public class BackupJob
    {
        private List<IJobObject> jobObjects;

        // private List<RestorePoint> restorePoints;
        public BackupJob()
        {
            jobObjects = new List<IJobObject>();
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
            if (!Directory.Exists("\\BU"))
            {
                Directory.CreateDirectory("\\BU");
            }

            int i = 1;
            foreach (IJobObject jobObject in jobObjects)
            {
                File.Copy(jobObject.FilePath, $@"\BU\{i}.txt", true);
                i++;
            }
        }
    }
}
