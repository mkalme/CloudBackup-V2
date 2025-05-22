using System;
using System.Collections.Generic;
using System.Linq;
using CustomDialogs;

namespace CloudBackup.Gui {
    public class GroupViewNode : IViewNode {
        public object Node => _node;
        private Group _node;

        public object Parent => _node.Parent;

        public ICollection<object> Items => _node.Items.Cast<object>().ToArray();

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        public GroupViewNode(Group group) {
            _node = group;

            _node.OnContentsChanged += Node_OnContentsChanged;
            _node.OnDeletion += Node_OnDeletion;
        }

        private void Node_OnContentsChanged(object sender, EventArgs e) {
            ContentsChanged?.Invoke(Node, EventArgs.Empty);
        }
        private void Node_OnDeletion(object sender, EventArgs e) {
            Removed?.Invoke(Node, EventArgs.Empty);
        }

        public IViewNode CreateNode(object group) => new GroupViewNode(group as Group);

        public void Dispose() {
            _node.OnContentsChanged -= Node_OnContentsChanged;
            _node.OnDeletion -= Node_OnDeletion;
        }
    }
}
