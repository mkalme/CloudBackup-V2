using System;
using CustomDialogs;

namespace CloudBackup.Gui {
    public static class NameUtilities {
        public static bool ValidateName(string type, string name) {
            if (string.IsNullOrEmpty(name)) {
                CustomDialog.ShowError("Error", $"{type}'s name cannot be empty.");

                return false;
            }

            if (name.Contains("\\")) {
                CustomDialog.ShowError("Error", "The item's name cannot contain the following character: '\\'");

                return false;
            }

            return true;
        }
    }
}
