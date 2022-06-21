using System;
using System.Collections.Generic;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class RestorePoint
    {
        private List<IJobObject> jobObjects;
        public RestorePoint(List<IJobObject> jobObjects)
        {
            TimeCreation = DateTime.Now;
            this.jobObjects = new List<IJobObject>(jobObjects);
        }

        public DateTime TimeCreation { get; }
        public List<IJobObject> JobObjects { get { return jobObjects; } }
    }
}
