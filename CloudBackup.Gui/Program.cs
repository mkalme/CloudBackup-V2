using System;
using System.Windows.Forms;
using CustomDialogs;
using CommonUtilities;

namespace CloudBackup.Gui {
    internal static class Program {
        private static CloudApplication CloudApplication;
        private static GuiApplication GuiApplication;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InputResult<byte[]> result = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator);
            if (result.DialogClosed) return;

            IResourceController controller = new ResourceController();
            ReferenceKey key = new ReferenceKey(result.Value);

            try {
                CloudApplication = new CloudApplication(controller, key);
                if (string.IsNullOrEmpty(CloudApplication.Settings.FolderName) && !CreateFolderName()) {
                    return;
                }
                
                GuiApplication = new GuiApplication(controller, key);

                Application.Run(new ItemExplorer(GuiApplication, CloudApplication));
            } catch (Exception ex) {
                CustomDialog.ShowError(ex);
            }
        }

        private static bool CreateFolderName() {
            InputResult<string> result = CustomDialog.ShowTextInput("Folder name", "Folder name is empty. Enter the name.", "",
                Properties.Resources._64pxRename, name => NameUtilities.ValidateName("Folder", name));
            if (result.DialogClosed) return false;

            CloudApplication.Settings.FolderName = result.Value;

            return true;
        }
    }
}
