using System;
using System.IO;

namespace CloudServiceProvider {
    public class DownloadFileRequest : ObjectRequest {
        public override ObjectType ObjectType { get; set; } = ObjectType.File;
        public Stream OutputStream { get; set; }

        public virtual IProgress<ByteProgressReport> Progress { get; set; }
    }
}
