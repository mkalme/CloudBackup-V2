using System;
using CloudServiceProvider;
using CommonUtilities;

namespace CloudBackup {
    public class CloudApplication {
        public ICloudServiceProvider CloudServiceProvider { get; private set; }

        public GroupResource GroupResource { get; private set; }
        public Group Group => GroupResource.Group;

        public UsersheetResource UsersheetResource { get; private set; }
        public Usersheet Usersheet => UsersheetResource.Usersheet;

        public SchemeCatalogResource SchemeCatalogResource { get; private set; }
        public SchemeCatalog SchemeCatalog => SchemeCatalogResource.SchemeCatalog;

        public SettingsResource SettingsResource { get; private set; }
        public Settings Settings => SettingsResource.Settings;

        public IUpdater Updater { get; private set; }

        public IResourceController ResourceController { get; private set; }
        public ReferenceKey Key { get; private set; }

        public CloudApplication(IResourceController resourceController, ReferenceKey key) {
            ResourceController = resourceController;
            Key = key;

            NamedStreamProviderController namedStreamProviderController = new NamedStreamProviderController("Storage\\CloudServiceProvider", Key, ResourceController);
            CloudServiceProvider = new CloudServiceProvider.GoogleCloud.GoogleCloudServiceProvider();
            CloudServiceProvider.Initialize(namedStreamProviderController);

            GroupResource = new GroupResource(this, new EncryptedStreamProvider(new FileStreamProvider("Storage\\Items"), Key));
            GroupResource.Load();
            GroupResource.Group.OnContentsChanged += Group_OnContentsChanged;
            ResourceController.AddResource(GroupResource);

            UsersheetResource = new UsersheetResource(Group, new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\Usersheet"), Key));
            UsersheetResource.Load();
            UsersheetResource.Usersheet.OnContentsChanged += Usersheet_OnContentsChanged;
            ResourceController.AddResource(UsersheetResource);

            SchemeCatalogResource = new SchemeCatalogResource(Group, new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\Schemes"), Key));
            SchemeCatalogResource.Load();
            SchemeCatalogResource.SchemeCatalog.OnContentsChanged += SchemeCatalog_OnContentsChanged;
            ResourceController.AddResource(SchemeCatalogResource);

            SettingsResource = new SettingsResource(new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\Settings"), Key));
            SettingsResource.Load();
            SettingsResource.Settings.OnContentsChanged += Settings_OnContentsChanged;
            ResourceController.AddResource(SettingsResource);

            Updater = new Updater(this);
        }

        private void Group_OnContentsChanged(object sender, EventArgs e) {
            GroupResource.Save();
        }
        private void Usersheet_OnContentsChanged(object sender, EventArgs e) {
            UsersheetResource.Save();
        }
        private void SchemeCatalog_OnContentsChanged(object sender, EventArgs e) {
            SchemeCatalogResource.Save();
        }
        private void Settings_OnContentsChanged(object sender, EventArgs e) {
            SettingsResource.Save();
        }
    }
}
