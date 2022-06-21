using System;
using System.Collections.Generic;
using System.Text;

namespace Backups.Interfaces
{
    public interface IStorage
    {
        void CreateBackup(RestorePoint point);
        void SaveStorage(IBackupSaver backupSaver, List<IJobObject> filesToSave, RestorePoint restorePoint);
    }
}
