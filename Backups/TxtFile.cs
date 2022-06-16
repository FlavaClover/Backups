using System;
using System.Collections.Generic;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class TxtFile : IJobObject
    {
        private string name;
        public TxtFile(string filePath, string name)
        {
            FilePath = filePath;
            this.name = name;
        }

        public string FilePath { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
