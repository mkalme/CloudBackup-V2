using System;

namespace CloudBackup {
    public readonly struct CompressionResult {
        public bool Successfull { get; }
        public string Output { get; }

        public CompressionResult(bool successfull, string output) {
            Successfull = successfull;
            Output = output;
        }
    }
}
