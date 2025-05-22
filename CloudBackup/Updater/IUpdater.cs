using System;

namespace CloudBackup {
    public interface IUpdater {
        bool Update(UpdateableItem updateableItem, IProgress<ProgressReport> progress);
        bool Download(UpdateableItem updateableItem, string outputDirectory, IProgress<ProgressReport> progress);
        bool Delete(UpdateableItem updateableItem);
    }
}
