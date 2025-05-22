using System;

namespace CloudServiceProvider {
    public class ObjectRequest {
        public virtual ObjectType ObjectType { get; set; }
        public virtual string CloudObjectPath { get; set; }
    }
}
