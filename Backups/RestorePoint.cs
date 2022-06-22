using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class RestorePoint
    {
        private List<IJobObject> jobObjects;
        private int id = 0;
        private string folderForBU;
        public RestorePoint(List<IJobObject> jobObjects)
        {
            id++;
            folderForBU = Directory.CreateDirectory(@$"C:\Users\h-b-1\Desktop\{id}").FullName;
            TimeCreation = DateTime.Now;
            this.jobObjects = new List<IJobObject>(jobObjects);
        }

        public string FolderForBU { get { return folderForBU; } }
        public DateTime TimeCreation { get; }
        public List<IJobObject> JobObjects { get { return jobObjects; } }
    }
}
