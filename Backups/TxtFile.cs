using System;
using System.Collections.Generic;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class TxtFile : IJobObject
    {
        public TxtFile(string path)
        {
            Path = path;
        }

        public string Path { get; set; }
    }
}
