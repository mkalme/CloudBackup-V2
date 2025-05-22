using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class GroupDeserializer : IObjectDeserializer<Group> {
        public IObjectDeserializer<Item> ItemDeserializer { get; set; }

        public GroupDeserializer(IObjectDeserializer<Item> itemDeserializer) { 
            ItemDeserializer = itemDeserializer;
        }

        public Group Deserialize(Tag tag) {
            ObjectTag[] objArray = tag;

            Group group = new Group(objArray.Length);
            for (int i = 0; i < objArray.Length; i++) {
                Tag child = objArray[i]["Child"];

                group.Items.Add(ItemDeserializer.Deserialize(child));
            }

            return group;
        }
    }
}
