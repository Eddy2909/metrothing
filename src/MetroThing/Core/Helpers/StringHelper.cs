using System;
using System.Collections.Generic;

namespace MetroThing.Core.Helpers
{
    public static class StringHelper
    {
        public static string ConvertByteSizeToHumanReadable(long? byteCount)
        {
            if (byteCount == null) return String.Empty;

            string[] scale = {"b", "KiB", "MiB", "GiB", "TiB", "PiB", "EiB", "ZiB", "YiB"};
            return ConvertBaseToHumanReadable(scale, 1024, (long) byteCount);
        }

        public static string ConvertLongToHumanReadableWithUnitPrefix(long? number)
        {
            if (number == null) return String.Empty;

            string[] scale = {"", "k", "M", "G", "T", "P", "E", "Z", "Y"};
            return ConvertBaseToHumanReadable(scale, 1000, (long) number);
        }

        private static string ConvertBaseToHumanReadable(IReadOnlyList<string> scale, int steps, long count)
        {
            if (count == 0)
                return "0 " + scale[0];

            var absCount = Math.Abs(count);
            var place = Convert.ToInt32(Math.Floor(Math.Log(absCount, steps)));
            var num = Math.Round(absCount/Math.Pow(steps, place), 1);
            return (Math.Sign(absCount)*num) + " " + scale[place];
        }

        public static string TimeAgo(DateTime? dateTime, int averageSecondsJustNow = 10)
        {
            if (dateTime == null) return String.Empty;

            var diff = DateTime.Now - (DateTime) dateTime;

            if (diff.Days > 365)
                return String.Format("{0} years ago", diff.Days/365);

            if (diff.Days > 30)
                return String.Format("{0} months ago", diff.Days/30);

            if (diff.Days > 0)
                return String.Format("{0} days ago", diff.Days);

            if (diff.Hours > 0)
                return String.Format("{0} hours ago", diff.Hours);

            if (diff.Minutes > 0)
                return String.Format("{0} minutes ago", diff.Minutes);

            if (diff.Seconds > averageSecondsJustNow)
                return String.Format("{0} seconds ago", diff.Seconds);

            return "just now";
        }
    }
}