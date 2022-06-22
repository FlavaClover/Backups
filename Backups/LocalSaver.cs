using System;
using System.Collections.Generic;
using System.Text;
using Backups.Interfaces;

namespace Backups
{
    public class LocalSaver : IBackupSaver
    {
        public LocalSaver() { }
        public void SaveBackup(RestorePoint restorePoint)
        {
            throw new NotImplementedException();
        }
    }
}
