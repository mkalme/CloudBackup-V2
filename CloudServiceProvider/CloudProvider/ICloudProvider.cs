using System;

namespace CloudServiceProvider {
    public interface ICloudProvider {
        void Upload(UploadFileRequest uploadFileRequest);
        void Download(DownloadFileRequest downloadFileRequest);
        RequestStatus Delete(ObjectRequest objectRequest);
    }
}
