using System;
using System.IO;

namespace CloudServiceProvider {
    public class UploadFileRequest : SharableObjectRequest {
        public override ObjectType ObjectType { get; set; } = ObjectType.File;
        public Stream InputStream { get; set; }

        public virtual IProgress<ByteProgressReport> Progress { get; set; }
    }
}
