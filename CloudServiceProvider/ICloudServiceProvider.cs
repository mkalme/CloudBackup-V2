using System;
using System.Collections.Generic;
using System.Drawing;
using CommonUtilities;

namespace CloudServiceProvider {
    public interface ICloudServiceProvider {
        string Name { get; }
        Image Icon { get; }

        ICloudProvider CloudProvider { get; }
        IEnumerable<ICommand> Commands { get; }

        void Initialize(INamedStreamProviderController streamProviderController);
    }
}
