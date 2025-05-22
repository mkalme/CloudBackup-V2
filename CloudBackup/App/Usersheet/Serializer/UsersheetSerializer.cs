using System;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UsersheetSerializer : IObjectSerializer<Usersheet> {
        public IObjectSerializer<ItemInformation> ItemInformationSerializer { get; set; }

        public UsersheetSerializer() { 
            ItemInformationSerializer = new ItemInformationSerializer();
        }

        public Tag Serialize(Usersheet item) {
            Tag[] itemTags = new Tag[item.Items.Count];

            for (int i = 0; i < item.Items.Count; i++) { 
                itemTags[i] = ItemInformationSerializer.Serialize(item.Items.Values.ElementAt(i));
            }

            return new ObjectTag() {
                { "Items", itemTags },
                { "Link", item.Link }
            };
        }
    }
}
