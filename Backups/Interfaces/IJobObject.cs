using System;
using System.Collections.Generic;
using System.Text;

namespace Backups.Interfaces
{
    public interface IJobObject
    {
        public string FilePath { get; set; }
    }
}
