using System;
using CustomDialogs;

namespace CloudBackup.Gui {
    public static class DialogUtilities {
        public static InputResult<string> ShowLinkInput(string name, string link) { 
            return CustomDialog.ShowTextInput($"{name}'s link", $"Edit {name}'s link", link, Properties.Resources._64pxLink);
        }
        public static InputResult<string> ShowPasswordInput(string name, string password) {
            var profile = PasswordGeneratorDialogProfile.NewPassword;
            profile.Title = $"Password | {name}";
            profile.Message = $"{name}'s password";
            profile.Password = password;

            return CustomDialog.ShowPasswordGenerator(profile);
        }
    }
}
