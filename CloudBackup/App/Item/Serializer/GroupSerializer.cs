using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class GroupSerializer : IObjectSerializer<Group> {
        public IObjectSerializer<Item> ItemSerializer { get; set; }

        public GroupSerializer(IObjectSerializer<Item> itemSerializer) {
            ItemSerializer = itemSerializer;
        }

        public Tag Serialize(Group item) {
            ObjectTag[] output = new ObjectTag[item.Items.Count];

            for (int i = 0; i < output.Length; i++) {
                Item child = item.Items[i];

                ObjectTag childObject = new ObjectTag() {
                    { "Child", ItemSerializer.Serialize(child) }
                };

                output[i] = childObject;
            }

            return output;
        }
    }
}
