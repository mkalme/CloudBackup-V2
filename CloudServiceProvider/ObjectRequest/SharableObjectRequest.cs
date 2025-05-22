using System;

namespace CloudServiceProvider {
    public class SharableObjectRequest : ObjectRequest {
        public virtual bool ShareLink { get; set; }
        public virtual string SharedLink { get; set; }
    }
}
