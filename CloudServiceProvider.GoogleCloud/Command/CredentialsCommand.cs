using System;
using System.Drawing;
using CloudServiceProvider.GoogleCloud.Common;

namespace CloudServiceProvider.GoogleCloud {
    public class CredentialsCommand : ICommand {
        public string Name => "Credentials and bucket";
        public Image Image => Properties.Resources._16pxCredentials;

        public Credentials Credentials { get; set; }

        public CredentialsCommand(Credentials credentials) { 
            Credentials = credentials;
        }

        public void Execute() {
            new CredentialsEditor(Credentials).ShowDialog();
        }
    }
}
