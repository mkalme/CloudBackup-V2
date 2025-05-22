using System;
using System.Globalization;

namespace CloudBackup.Gui {
    public static class DateTimeExtensions {
        public static string ToPropertyString(this DateTime dateTime) {
            return dateTime.ToString("MMM MM, yyyy HH:mm:ss", new CultureInfo("en-US"));
        }
    }
}
