using System;

namespace CloudServiceProvider {
    public enum RequestStatus {
        Successfull,
        InProgress,
        FileNotFound,
        NoInternetConnection,
        OtherError,
        Canceled
    }
}
