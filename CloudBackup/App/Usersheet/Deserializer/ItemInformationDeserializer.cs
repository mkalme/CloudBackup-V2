using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class ItemInformationDeserializer : IObjectDeserializer<ItemInformation> {
        public IList<UpdateableItem> UpdateableItems { get; set; }

        public ItemInformationDeserializer(IList<UpdateableItem> updateableItems) { 
            UpdateableItems = updateableItems;
        }

        public ItemInformation Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            string generatedId = obj["GeneratedID"];

            IEnumerable<UpdateableItem> item = UpdateableItems.Where(x => x.GeneratedID == generatedId);
            if (!item.Any()) return null;

            return new ItemInformation(item.First()) { 
                LastPassword = obj["LastPassword"],
                LastPath = obj["LastPath"],
                LastPathInProgram = obj["LastPathInProgram"],
                LastLink = obj["LastLink"],
                LastLength = obj["LastLength"],
                LastUpdated = obj["LastUpdated"]
            };
        }
    }
}
