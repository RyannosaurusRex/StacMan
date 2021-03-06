﻿using System;

namespace StackExchange.StacMan
{
    internal static class DateTimeExtensions
    {
        private static readonly DateTime UnixEpochDateTimeUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ToDateTime(this long secondsSince1970)
        {
            return UnixEpochDateTimeUtc.AddSeconds(secondsSince1970);
        }

        public static DateTime? ToNullableDateTime(this long? secondsSince1970)
        {
            return secondsSince1970.HasValue ? UnixEpochDateTimeUtc.AddSeconds(secondsSince1970.Value) : (DateTime?)null;
        }

        public static long ToUnixTime(this DateTime dt)
        {
            return (long)(dt - UnixEpochDateTimeUtc).TotalSeconds;
        }
    }
}
