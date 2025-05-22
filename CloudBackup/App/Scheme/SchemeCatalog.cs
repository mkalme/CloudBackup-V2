using System;
using CommonUtilities;

namespace CloudBackup {
    public class SchemeCatalog : ObservableResource {
        public ObservableList<Scheme> Schemes { get; private set; }

        public SchemeCatalog() {
            Schemes = new ObservableList<Scheme>();
            Schemes.OnItemsAdd += (sender, items) => {
                RaiseOnContentsChanged();
            };
            Schemes.OnItemsRemove += (sender, items) => {
                RaiseOnContentsChanged();
            };
        }

        public void SwapChildItems(Scheme child, Scheme otherChild) {
            int index = Schemes.IndexOf(child);
            int otherIndex = Schemes.IndexOf(otherChild);

            ApplyUpdateMode();

            Schemes[index] = otherChild;
            Schemes[otherIndex] = child;

            SuspendUpdateMode();
        }
    }
}
