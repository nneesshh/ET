using System;

namespace GameUtils.Util
{
    public static class EnumUtil
    {
        public static string EnumToString<TEnum>(TEnum enumValue) where TEnum : Enum
        {
            return ((int)(object)enumValue).ToString();
        }

        public static string GetEnumNameFromValue(Type enumType, int value)
        {
            if (enumType.IsEnum && Enum.IsDefined(enumType, value))
            {
                return Enum.GetName(enumType, value);
            }
            else
            {
                return "未找到对应的枚举名字";
            }
        }
    }
}
