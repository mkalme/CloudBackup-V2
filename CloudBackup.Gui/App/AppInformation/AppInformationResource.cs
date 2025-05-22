using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup.Gui {
    public class AppInformationResource : SerializeableResource {
        public AppInformation AppInformation { get; private set; }

        public AppInformationResource(IStreamProvider streamProvider) : base(streamProvider) { }

        protected override void SetDefaultState() {
            AppInformation = new AppInformation();
            AppInformation.KeyChangeHistory.Dates.Add(DateTime.Now);
        }
        protected override void SetState(Stream inputStream) {
            AppInformation = new AppInformationDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new AppInformationSerializer().Serialize(AppInformation).WriteToStream(outputStream);
        }
    }
}
