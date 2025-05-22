using System;
using System.Drawing;
using CommonUtilities;

namespace CloudBackup.Gui {
    public class GuiSettings : ObservableResource {
        public int DefaultPasswordLength {
            get => _defaultPasswordLength;
            set {
                if (_defaultPasswordLength == value) return;

                _defaultPasswordLength = value;
                RaiseOnContentsChanged();
            }
        }
        private int _defaultPasswordLength;

        public Color ProgressBarColor {
            get => _progressBarColor;
            set {
                if (_progressBarColor == value) return;

                _progressBarColor = value;
                RaiseOnContentsChanged();
            }
        }
        private Color _progressBarColor;

        public GuiSettings() {
            _defaultPasswordLength = 0;
            _progressBarColor = Color.DarkSeaGreen;
        }
    }
}
