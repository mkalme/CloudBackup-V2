using System;
using CustomDialogs;
using CommonUtilities;

namespace CloudBackup.Gui {
    public class GuiApplication {
        public AppInformationResource AppInformationResource { get; private set; }
        public AppInformation AppInformation => AppInformationResource.AppInformation;

        public GuiSettingsResource GuiSettingsResource { get; private set; }
        public GuiSettings GuiSettings => GuiSettingsResource.GuiSettings;

        public ItemClipboard Clipboard { get; private set; }

        public IResourceController ResourceController { get; private set; }
        public ReferenceKey Key { get; private set; }

        public GuiApplication(IResourceController resourceController, ReferenceKey key) {
            ResourceController = resourceController;
            Key = key;

            AppInformationResource = new AppInformationResource(new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\AppInformation"), Key));
            AppInformationResource.Load();
            AppInformationResource.AppInformation.OnContentsChanged += AppInformation_OnContentsChanged;
            ResourceController.AddResource(AppInformationResource);

            GuiSettingsResource = new GuiSettingsResource(new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\GuiSettings"), Key));
            GuiSettingsResource.Load();
            GuiSettingsResource.GuiSettings.OnContentsChanged += GuiSettingsResource_OnContentsChanged;
            ResourceController.AddResource(GuiSettingsResource);

            Clipboard = new ItemClipboard(
                (item, ev) => ((Item)item).OnDeletion += ev,
                (item, ev) => ((Item)item).OnDeletion -= ev
            );
        }

        private void AppInformation_OnContentsChanged(object sender, EventArgs e) {
            AppInformationResource.Save();
        }
        private void GuiSettingsResource_OnContentsChanged(object sender, EventArgs e) {
            GuiSettingsResource.Save();
        }

        public void ChangeKey(byte[] key) {
            Key.Key = key;
            ResourceController.SaveAll();

            AppInformation.KeyChangeHistory.Dates.Add(DateTime.Now);
        }
    }
}
