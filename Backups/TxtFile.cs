using System;
using System.Collections.Generic;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class TxtFile : IJobObject
    {
        public TxtFile(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; set; }
    }
}
