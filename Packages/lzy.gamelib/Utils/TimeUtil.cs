using GameUtils.IO;
using System;

namespace GameUtils.Util
{
    public static class TimeUtil
    {
        /// <summary>
        /// 时间格式转换
        /// </summary>
        /// <param name="second">秒</param>
        /// (TimeFormat(60)); // 输出: 03:46:40
        /// (TimeFormat(60, "HH:mm")); // 输出: 03:46
        /// (TimeFormat(60, "dd天HH小时mm分ss秒")); // 输出: 01天03小时46分40秒
        /// (TimeFormat(60, "d天h小时m分s秒")); // 输出: 1天3小时46分40秒
        /// (TimeFormat(60, "mm:ss")); // 输出: 03:46 
        /// <returns></returns>
        public static string TimeFormat(int second, string format = "HH:mm:ss")
        {
            int hour = second / 3600;
            int minute = (second % 3600) / 60;
            int sec = second % 60;
            int day = hour / 24;
            hour = hour % 24;

            // 替换格式中的占位符
            format = format.Replace("dd", day.ToString("D2"))
                           .Replace("d", day.ToString())
                           .Replace("HH", hour.ToString("D2"))
                           .Replace("h", hour.ToString())
                           .Replace("mm", minute.ToString("D2"))
                           .Replace("m", minute.ToString())
                           .Replace("ss", sec.ToString("D2"))
                           .Replace("s", sec.ToString());
            return format;
        }

        /// <summary>
        /// 时间格式转换
        /// </summary>
        /// <param name="second">秒</param>
        /// (TimeFormat(60)); // 输出: 03:46:40
        /// (TimeFormat(60, "HH:mm")); // 输出: 03:46
        /// (TimeFormat(60, "dd天HH小时mm分ss秒")); // 输出: 01天03小时46分40秒
        /// (TimeFormat(60, "d天h小时m分s秒")); // 输出: 1天3小时46分40秒
        /// (TimeFormat(60, "mm:ss")); // 输出: 03:46 
        /// <returns></returns>
        public static string TimeFormat(long second, string format = "HH:mm:ss")
        {
            long hour = second / 3600;
            long minute = (second % 3600) / 60;
            long sec = second % 60;
            long day = hour / 24;
            hour = hour % 24;

            // 替换格式中的占位符
            format = format.Replace("dd", day.ToString("D2"))
                           .Replace("d", day.ToString())
                           .Replace("HH", hour.ToString("D2"))
                           .Replace("h", hour.ToString())
                           .Replace("mm", minute.ToString("D2"))
                           .Replace("m", minute.ToString())
                           .Replace("ss", sec.ToString("D2"))
                           .Replace("s", sec.ToString());
            return format;
        }

        /// <summary>
        /// 获取时间截
        /// </summary>
        /// <returns></returns>
        public static long GetUnixTimestampSeconds()
        {
            DateTimeOffset now = DateTimeOffset.UtcNow;
            return now.ToUnixTimeSeconds();
        }

        /// <summary>
        /// 将时间戳转换为自定义格式的北京时间字符串。
        /// </summary>
        /// <param name="timestamp">时间戳（以秒为单位）。</param>
        /// <param name="format">自定义日期格式，例如 "M月d号 H时m分"。</param>
        /// <returns>转换后的日期字符串。</returns>
        public static string ConvertTimestampToDateString(long timestamp, string format = "m分ss秒")
        {
            // 将时间戳转换为 DateTime 对象 (UTC 时间)
            DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;

            // 将 UTC 时间转换为北京时间 (UTC+8)
            DateTime beijingTime = dateTime.AddHours(8);

            // 使用传入的格式字符串来格式化日期
            string dateString = beijingTime.ToString(format);

            return dateString;
        }
    }
}
