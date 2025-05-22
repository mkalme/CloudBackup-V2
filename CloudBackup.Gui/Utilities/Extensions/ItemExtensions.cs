using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CustomDialogs;

namespace CloudBackup.Gui {
    public static class ItemExtensions {
        public static Image GetIcon(this Item item) {
            switch (item.ID) {
                case ItemID.Group:
                    return Properties.Resources._64pxGroup;
                default:
                    switch ((item as UpdateableItem).UpdateableItemID) {
                        case UpdateableItemID.Folder:
                            return Properties.Resources._64pxFolderClosed;
                        case UpdateableItemID.FilteredFolder:
                            return Properties.Resources._64pxFilteredFolder;
                        default:
                            return Properties.Resources._64pxItemBundle;
                    }
            }
        }
        public static string GetTypeString(this Item item) {
            switch (item.ID) {
                case ItemID.Group:
                    return "Group";
                default:
                    switch ((item as UpdateableItem).UpdateableItemID) {
                        case UpdateableItemID.Folder:
                            return "Folder";
                        case UpdateableItemID.FilteredFolder:
                            return "Filtered folder";
                        default:
                            return "Item bundle";
                    }
            }
        }
        public static string GetImageChacheKey(this Item item) {
            return $"type.item.{item.GetType().FullName}";
        }

        public static string GetLastUpdatedString(this UpdateableItem item) {
            if (item.UpdateHistory.Dates.Count == 0) return "Never";

            return (DateTime.Now - item.UpdateHistory.Dates.Last()).ToRelativeTimeString();
        }

        public static string GetPath(this Item item) {
            return item.Parent == null ? item.Name : $"{GetPath(item.Parent)}\\{item.Name}";
        }
        public static long GetSize(this IEnumerable<UpdateableItem> items, Usersheet usersheet) {
            long size = 0;
            foreach (var item in items) {
                size += usersheet.ReceiveItemInformation(item)?.LastLength ?? 0;
            }

            return size;
        }
        public static void GetUpdateableItems(this IEnumerable<Item> items, IList<UpdateableItem> output) {
            foreach (Item item in items) {
                if (item.ID == ItemID.UpdateableItem) {
                    output.Add(item as UpdateableItem);
                } else if (item.ID == ItemID.Group) {
                    GetUpdateableItems((item as Group).Items, output);
                }
            }
        }
    }
}
