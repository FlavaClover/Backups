using System;
using System.Collections.Generic;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class TxtFile : IJobObject
    {
        private string filePath;
        private string name;
        public TxtFile(string path, string name)
        {
            filePath = path;
            this.name = name;
        }
    }
}
