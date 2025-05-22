using System;
using CommonUtilities;

public class AppInformation : ObservableResource {
    public DateTime CreationDate { get; set; }
    public DateTimeHistory KeyChangeHistory {
        get => _keyChangeHistory;
        set {
            if (_keyChangeHistory != null && _keyChangeHistory.Equals(value)) return;

            if (_keyChangeHistory != null) _keyChangeHistory.OnContentsChanged -= Nodes_ContentsChanged;
            _keyChangeHistory = value;
            _keyChangeHistory.OnContentsChanged += Nodes_ContentsChanged;

            RaiseOnContentsChanged();
        }
    }
    private DateTimeHistory _keyChangeHistory;

    public AppInformation() {
        CreationDate = DateTime.Now;
        KeyChangeHistory = new DateTimeHistory(new DateTime[0]);
    }

    private void Nodes_ContentsChanged(object sender, EventArgs e) {
        RaiseOnContentsChanged();
    }
}
