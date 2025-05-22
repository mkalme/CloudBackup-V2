using System;
using System.Collections.Generic;
using System.Drawing;
using CloudServiceProvider.GoogleCloud.Common;
using CommonUtilities;

namespace CloudServiceProvider.GoogleCloud {
    public class GoogleCloudServiceProvider : ICloudServiceProvider {
        public string Name { get; } = "Google Cloud";
        public Image Icon { get; } = Properties.Resources._64pxGoogleCloudStorage;

        public ICloudProvider CloudProvider { get; private set; }
        public IEnumerable<ICommand> Commands { get; private set; }

        private Credentials _credentials;

        public void Initialize(INamedStreamProviderController namedStreamProviderController) {
            ProviderApplication application = new ProviderApplication(namedStreamProviderController);

            Commands = new List<ICommand>() { new CredentialsCommand(application.Credentials) };

            _credentials = application.Credentials;
            CloudProvider = new GoogleCloudProvider(_credentials);
        }
    }
}
