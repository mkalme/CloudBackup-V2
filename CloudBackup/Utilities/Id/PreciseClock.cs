using System;
using System.Diagnostics;

namespace CloudBackup {
    public class PreciseClock {
        private DateTime _startTime;
        private Stopwatch _stopWatch = null;
        private TimeSpan _maxIdle = TimeSpan.FromSeconds(10);

        public DateTime UtcNow {
            get {
                if ((_stopWatch == null) ||
                    (_startTime.Add(_maxIdle) < DateTime.UtcNow)) {
                    Reset();
                }
                return _startTime.AddTicks(_stopWatch.Elapsed.Ticks);
            }
        }

        private void Reset() {
            _startTime = DateTime.UtcNow;
            _stopWatch = Stopwatch.StartNew();
        }
    }
}
