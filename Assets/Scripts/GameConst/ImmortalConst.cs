using System.Collections.Generic;

namespace GameConst
{
    public class ImmortalConst
    {
        /// <summary>
        /// 论道技能ID
        /// </summary>
        public static readonly int CAMP_WAR_SK_ID = 20000000;

        /// <summary>
        /// 论道技能树ID
        /// </summary>
        public static readonly int CAMP_WAR_SKT_ID = 20000000;

        /// <summary>
        /// 虚弱BUFF ID
        /// </summary>
        public static readonly int BUFF_ID_WEAK = 19005;

        /// <summary>
        /// 重生BUFF ID
        /// </summary>
        public static readonly int BUFF_ID_REBIRTH = 19100;

        /// <summary>
        /// 论道初始BUFF列表
        /// </summary>
        public static readonly List<int> CAMP_WAR_INIT_BUFF_LIST = new List<int>() { 19003 };

        /// <summary>
        /// 技能近战随机概率(百分比)
        /// </summary>
        public static readonly int SKILL_MELEE_RATE = 50;

        /// <summary>
        /// 技能远程随机概率(百分比)
        /// </summary>
        public static readonly int SKILL_REMOTE_RATE = 50;

        /// <summary>
        /// 技能刷新时间(毫秒)
        /// </summary>
        public static readonly int SKILL_REFRESH_TIME = 20000;

        /// <summary>
        /// 面板显示时间
        /// </summary>
        public static readonly float NAMEPLATE_SHOW_TIME = 10F;

        /// <summary>
        /// 功法组解锁境界
        /// </summary>
        public static readonly List<int> SKILL_GROUP_NEED_REAL_LIST = new List<int>() { 0, 7, 22 };

        /// <summary>
        /// 竞技场战斗时间(秒)
        /// </summary>
        public static readonly int ARENA_BATTLE_TIME = 10;

        /// <summary>
        /// 竞技场结算时间(秒)
        /// </summary>
        public static readonly int ARENA_SETTLE_TIME = 5;
    }
}
