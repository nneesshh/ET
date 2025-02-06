using System.Globalization;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using GameUtils.IO;

namespace GameUtils.Util
{
    public static class StringUtil
    {
        private static StringBuilder stringBuilder = new StringBuilder(256); // 设置初始容量

        public static StringBuilder GetStringBuilder()
        {
            // 清空 StringBuilder 对象，以便重复使用
            stringBuilder.Clear();
            return stringBuilder;
            //return new StringBuilder(256);
        }

        public static string GenString(IEnumerable<string> args)
        {
            var sb = GetStringBuilder();
            foreach (var arg in args)
            {
                sb.Append(arg);
            }
            string result = sb.ToString(); // 使用StringBuilder生成结果

            return result;
        }

        public static string GenString(params string[] args)
        {
            var sb = GetStringBuilder();
            for (int i = 0; i < args.Length; i++)
            {
                sb.Append(args[i]);
            }

            string result = sb.ToString(); // 使用StringBuilder生成结果

            return result;
        }

        public static StringBuilder GetStringBuilder(IEnumerable<string> args)
        {
            var sb = GetStringBuilder();
            foreach (var arg in args)
            {
                sb.Append(arg);
            }

            return sb;
        }

        private static Dictionary<int, string> _int2StringMap = new Dictionary<int, string>();
        private static LinkedList<int> _lruList = new LinkedList<int>(); // 用于追踪使用顺序
        private static int _maxCacheSize = 1000; // 设置最大缓存容量

        public static string Int2String(int value)
        {
            if (_int2StringMap.ContainsKey(value))
            {
                // 如果已经存在，将其移动到 LRU 链表头部，表示最近使用过
                _lruList.Remove(value);
                _lruList.AddFirst(value);
            }
            else
            {
                // 如果缓存超过最大容量，移除最近最少使用的项
                if (_int2StringMap.Count >= _maxCacheSize)
                {
                    int leastUsed = _lruList.Last.Value;
                    _lruList.RemoveLast();
                    _int2StringMap.Remove(leastUsed);
                }

                // 添加新值到缓存，并且放入 LRU 链表头部
                _int2StringMap[value] = value.ToString();
                _lruList.AddFirst(value);
                //GameLog.LogError("新增:" + value + " " + _int2StringMap[value] + " " + _lruList.Count);
            }

            return _int2StringMap[value];
        }

        /// <summary>
        /// 是否为数字
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool IsNumber(string message)
        {
            System.Text.RegularExpressions.Regex rex =
            new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                return true;
            }
            else
                return false;
        }

        private static readonly Regex AccountRegex = new Regex("^[a-zA-Z0-9_.-]{4,20}$");

        public static bool IsValidAccount(string account, int minLength, int maxLenght)
        {
            // 检查长度  
            if (account.Length < 4 || account.Length > 20)
                return false;

            // 检查是否只包含允许的字符  
            return AccountRegex.IsMatch(account);

            // 如果需要其他检查（如唯一性），可以在这里添加  
        }

        public static string ConvertNumberToChinese(long number)
        {
            if (number < 100000)
            {
                return number.ToString();
            }
            else if (number < 100000000)
            {
                double valueInWan = number / 10000.0;
                return valueInWan.ToString("0.00") + "万"; // 始终显示两位小数
            }
            else
            {
                double valueInYi = number / 100000000.0;
                return valueInYi.ToString("0.00") + "亿"; // 始终显示两位小数
            }
        }

        public static string ConvertNumberToChinese(float number)
        {
            if (number < 100000)
            {
                return number.ToString();
            }
            else if (number < 100000000)
            {
                float valueInWan = number / 10000.0f;
                return valueInWan.ToString("0.00") + "万"; // 始终显示两位小数
            }
            else
            {
                float valueInYi = number / 100000000.0f;
                return valueInYi.ToString("0.00") + "亿"; // 始终显示两位小数
            }
        }

        public static string ConvertNumberToChinese(double number)
        {
            if (number < 100000)
            {
                return number.ToString();
            }
            else if (number < 100000000)
            {
                double valueInWan = number / 10000.0f;
                return valueInWan.ToString("0.00") + "万"; // 始终显示两位小数
            }
            else
            {
                double valueInYi = number / 100000000.0f;
                return valueInYi.ToString("0.00") + "亿"; // 始终显示两位小数
            }
        }

        /// <summary>
        /// 输入百分比 如 500 => 5%
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ConvertNumberToPercentage(int value)
        {
            int baseValue = 10000;
            float percentage = (float)value / baseValue * 100;
            return $"{percentage:F0}%"; // 使用"F0"格式化字符串来去除小数部分  
        }

        /// <summary>
        /// 输入百分比 如 500 => 5%
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ConvertNumberToPercentage(long value)
        {
            long baseValue = 10000;
            double percentage = (double)value / baseValue * 100;
            return $"{percentage:F0}%"; // 使用"F0"格式化字符串来去除小数部分  
        }

        /// <summary>
        /// 格式化数字 12288 => 122,88
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string FormatNumber(long number, string format = "zh-CN")
        {
            double doubleNumber = number / 100.0;

            // 使用自定义的文化信息来格式化数字
            CultureInfo culture = new CultureInfo(format);

            culture.NumberFormat.NumberGroupSeparator = ","; // 千位分隔符
            culture.NumberFormat.NumberDecimalSeparator = "."; // 小数点分隔符

            return doubleNumber.ToString("N2", culture);
        }

        /// <summary>
        /// 截取字符串的前N个字符，包括中文和英文混合的情况。
        /// </summary>
        /// <param name="input">原始字符串。</param>
        /// <param name="length">要截取的字符数。</param>
        /// <returns>截取后的字符串。</returns>
        public static string SafeSubstring(string input, int length)
        {
            if (string.IsNullOrEmpty(input)) return input;
            if (length <= 0) return string.Empty;

            StringBuilder result = new StringBuilder();
            int currentLength = 0;
            foreach (char c in input)
            {
                if (currentLength >= length) break;

                // 检查字符是否是中文字符
                if (char.IsSurrogate(c) || (c >= 0x4e00 && c <= 0x9fa5))
                {
                    // 中文字符，占用2个字符位置
                    result.Append(c);
                    currentLength += 2;
                }
                else
                {
                    // 英文字符，占用1个字符位置
                    result.Append(c);
                    currentLength++;
                }
            }

            return result.ToString();
        }
    }
}