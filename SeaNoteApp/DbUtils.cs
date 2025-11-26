using System;

namespace SeaNoteApp.Utils
{
    public static class DbUtils
    {
        public static long SafeGetLong(object? val)
        {
            if (val == null || val == DBNull.Value) return 0L;
            return Convert.ToInt64(val);
        }

        public static long? SafeGetLongNullable(object? val)
        {
            if (val == null || val == DBNull.Value) return null;
            return Convert.ToInt64(val);
        }

        public static int SafeGetInt(object? val)
        {
            if (val == null || val == DBNull.Value) return 0;
            return Convert.ToInt32(val);
        }

        public static string SafeGetString(object? val)
        {
            return val == null || val == DBNull.Value ? "" : val.ToString()!;
        }

        public static DateTime? SafeGetDateTime(object? val)
        {
            if (val == null || val == DBNull.Value) return null;
            return Convert.ToDateTime(val);
        }
    }
}
