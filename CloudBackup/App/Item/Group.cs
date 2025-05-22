using System;
using System.Collections.Generic;
using CommonUtilities;

namespace CloudBackup {
    public sealed class Group : Item {
        public ObservableList<Item> Items { get; private set; }

        public Group(int capacity = 0) : base(ItemID.Group) {
            Items = new ObservableList<Item>(capacity);

            Items.OnItemsAdd += (sender, items) => {
                if (_updating) return;
                foreach (Item item in items) {
                    item.OnContentsChanged += Item_ContentsChanged;
                    item.Parent = this;
                }

                RaiseOnContentsChanged(false);
            };
            Items.OnItemsRemove += (sender, items) => {
                if (_updating) return;
                foreach (Item item in items) {
                    item.OnContentsChanged -= Item_ContentsChanged;
                    item.Parent = null;

                    if(!_moving) item.RaiseOnDeletion();
                }

                RaiseOnContentsChanged(false);
            };
        }

        private void Item_ContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged(false);
        }

        private bool _updating = false;
        private bool _moving = false;
        public void MoveUp(IList<Item> items) {
            int[] indexes = GetIndexes(items);
            if (indexes[0] <= 0) return;

            _updating = true;
            for (int i = 0; i < indexes.Length; i++) {
                Item swap = Items[indexes[i] - 1];
                Item current = Items[indexes[i]];

                Items[indexes[i] - 1] = current;
                Items[indexes[i]] = swap;
            }
            _updating = false;

            RaiseOnContentsChanged(false);
        }
        public void MoveDown(IList<Item> items) {
            int[] indexes = GetIndexes(items);
            if (indexes[indexes.Length - 1] >= Items.Count - 1) return;

            _updating = true;
            for (int i = indexes.Length - 1; i >= 0; i--) {
                Item swap = Items[indexes[i] + 1];
                Item current = Items[indexes[i]];

                Items[indexes[i] + 1] = current;
                Items[indexes[i]] = swap;
            }
            _updating = false;

            RaiseOnContentsChanged(false);
        }
        private int[] GetIndexes(IList<Item> items) {
            int[] indexes = new int[items.Count];
            for (int i = 0; i < items.Count; i++) {
                indexes[i] = Items.IndexOf(items[i]);
            }

            Array.Sort(indexes);
            return indexes;
        }

        public void Move(IEnumerable<Item> children, Group newGroup) {
            _moving = true;

            foreach (var child in children) {
                Items.Remove(child);

                child.Parent = newGroup;
                newGroup.Items.Add(child);
            }

            _moving = false;
        }

        public override object Clone() {
            Group output = new Group(Items.Count);

            foreach (Item child in Items) {
                output.Items.Add((Item)child.Clone());
            }

            CloneToObject(output);

            return output;
        }
        public override bool Equals(Item other) {
            if (ID != other.ID) return false;
            if (!ObjectEquals(other)) return false;

            Group group = other as Group;

            if (Items.Count != group.Items.Count) return false;
            for (int i = 0; i < Items.Count; i++) {
                if (!Items[i].Equals(group.Items[i])) return false;
            }

            return true;
        }
    }
}
