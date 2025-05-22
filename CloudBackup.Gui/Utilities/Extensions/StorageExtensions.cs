using System;

namespace CloudBackup.Gui {
    public static class StorageExtensions {
        private static string[] _prefixesShort = new string[5]{ "B", "KB", "MB", "GB", "TB" };

        public static string ConvertToShortStorage(this long storage) {
            int num = (int)Math.Floor(Math.Log(storage, 1024.0));

            if (storage == 0L) num = 0;
            else if(num >= _prefixesShort.Length) num = _prefixesShort.Length - 1;

            return $"{(storage / Math.Pow(1024.0, num)).Format()} {_prefixesShort[num]}";
        }

        public static string Format(this double storage) {
            return storage.ToString("N0");
        }
    }
}
