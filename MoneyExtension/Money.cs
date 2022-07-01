using System;

namespace MoneyExtension
{
    public static class Money
    {
        public static int ToCents(this decimal val)
        {
            if (val <= 0)
                return 0;

            var value = val
                .ToString("N2")
                .Replace(",", "")
                .Replace(".", "");

            if (string.IsNullOrEmpty(value))
                return 0;

            int.TryParse(value, out var result);
            return result;
        }
    }
}
