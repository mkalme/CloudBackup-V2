using System;

namespace CloudBackup {
    public static class ShortIdUtilities {
        private static readonly char[] _padding = { '=' };
        private static readonly PreciseClock _preciseClock = new PreciseClock();

        public static string GenerateShortId() { 
            Guid guid = Guid.NewGuid();

            byte[] bytes = new byte[16 + sizeof(long)];
            guid.TryWriteBytes(bytes);

            long ticks = _preciseClock.UtcNow.Ticks;
            byte[] tickBytes = BitConverter.GetBytes(ticks);
            for (int i = 0; i < sizeof(long); i++) {
                bytes[16 + i] = tickBytes[i];
            }

            return Convert.ToBase64String(bytes).TrimEnd(_padding).Replace('+', '-').Replace('/', '_'); ;
        }
    }
}
