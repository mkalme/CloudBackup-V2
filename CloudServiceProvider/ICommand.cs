using System;
using System.Drawing;

namespace CloudServiceProvider {
    public interface ICommand {
        string Name { get; }
        Image Image { get; }

        void Execute();
    }
}
