using System;
using CustomDialogs;

namespace CloudBackup.Gui {
    public class GroupNode : INode {
        public Group Group { get; set; }

        public INode Parent {
            get {
                if (_parent == null && Group.Parent != null) {
                    _parent = new GroupNode(Group.Parent);
                }

                return _parent;
            }
        }
        private INode _parent;

        public object Node => Group;
        public string DisplayedText => Group.Name;

        public event EventHandler DisplayedTextChanged;

        public GroupNode(Group group) {
            Group = group;

            Group.OnNameChanged += DisplayNameChanged;
        }

        private void DisplayNameChanged(object sender, EventArgs e) {
            DisplayedTextChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose() {
            Group.OnNameChanged -= DisplayNameChanged;
        }
    }
}
