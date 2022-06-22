using System;
using System.Collections.Generic;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class VirtualSaver : IBackupSaver
    {
        public VirtualSaver() { }
        public void SaveBackup(RestorePoint restorePoint)
        {
            throw new NotImplementedException();
        }
    }
}
