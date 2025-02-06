
using GameUtils.Util;
using System;

namespace GameCore
{
    public static class MathUtil
    {
        /// <summary>
        /// 浮点数精度
        /// </summary>
        public const float FEpsilon = 0.000001f;

        /// <summary>
        /// 浮点数是否等于0
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>是否等于0</returns>
        public static bool FEqualZero(float value)
        {
            return Math.Abs(value) < FEpsilon;
        }

        /// <summary>
        /// 浮点数是否相等
        /// </summary>
        /// <param name="left">值1</param>
        /// <param name="right">值2</param>
        /// <returns>是否相等</returns>
        public static bool FEqual(float left, float right)
        {
            return Math.Abs(left - right) < FEpsilon;
        }

        /// <summary>
        /// 小于精度时则置0
        /// </summary>
        /// <param name="value">值</param>
        /// <returns>结果</returns>
        public static float FFixed(float value)
        {
            return Math.Abs(value) < FEpsilon ? 0f : value;
        }

        /// <summary>
        /// 平方
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Sqr(float value)
        {
            return value * value;
        }
    }
}
