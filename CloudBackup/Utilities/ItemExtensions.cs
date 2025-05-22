using System;
using System.Collections.Generic;

namespace CloudBackup {
    public static class ItemExtensions {
        public static void GetUpdateableItems(this Group group, IList<UpdateableItem> output) {
            foreach (Item item in group.Items) {
                if (item is UpdateableItem updateableItem) output.Add(updateableItem);
                else GetUpdateableItems(item as Group, output);
            }
        }
    }
}
