using System;
using System.Collections.Generic;
using System.Text;

namespace Backups.Interfaces
{
    public interface IBackupSaver
    {
        void SaveBackup(RestorePoint restorePoint);
    }
}
