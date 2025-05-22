using System;
using System.Collections.Generic;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UsersheetDeserializer : IObjectDeserializer<Usersheet> {
        public IObjectDeserializer<ItemInformation> ItemInformationDeserializerr { get; set; }

        public UsersheetDeserializer(Group group) {
            IList<UpdateableItem> updateableItems = new List<UpdateableItem>();
            group.GetUpdateableItems(updateableItems);

            ItemInformationDeserializerr = new ItemInformationDeserializer(updateableItems);
        }

        public Usersheet Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            Usersheet usersheet = new Usersheet() { 
                Link = obj["Link"]
            };

            Tag[] tagArray = obj["Items"];
            foreach (Tag childTag in tagArray) {
                ItemInformation info = ItemInformationDeserializerr.Deserialize(childTag);
                usersheet.Items.Add(info.Item.GeneratedID, info);
            }

            return usersheet;
        }
    }
}
