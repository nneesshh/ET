
using GameUtils.Util;

namespace GameConst
{
    public static class ResPathConst
    {
        public static string RES_DIR = "Assets/GameRes/";

        public static string GetResPath(string path) => RES_DIR + path;

        #region 场景资源路径=========================================================================================================
        public static string ART_SCENE_ROOT_DIR => RES_DIR + "Scenes/";
        public static string GetScenePathByName(string name) => ART_SCENE_ROOT_DIR + "Maps/" + name;
        public static string GetScenePrefabPathByName(string name) => StringUtil.GenString(ART_SCENE_ROOT_DIR, "Prefabs/", name);
        #endregion ==================================================================================================================


        #region 配置数据路径=========================================================================================================
        public static string RAW_DIR = "Assets/GameRaw/";
        public static string RAW_TABLE_ROOT_DIR => RAW_DIR + "Table/";

        public static string RAW_UNIT_ANIMATION_DIR => RAW_DIR + "UnitAnimation/";

        /// <summary>
        /// 获取单位动作配置
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetUnitAnimationPathById(int id) => string.Format("{0}/UnitAnimation/{1}.txt", RAW_DIR, id);

        /// <summary>
        /// 获取配表路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConfigPathByName(string name) => RAW_TABLE_ROOT_DIR + name;
        #endregion ==================================================================================================================


        #region 界面资源路径=========================================================================================================
        public static string RES_MAP_CONFIG_ROOT_DIR => RES_DIR + "Configs/Map/";
        public static string RES_UNIT_CONFIG_ROOT_DIR => RES_DIR + "Configs/Battle/";
        public static string RES_VIDEO_ROOT_DIR => RES_DIR + "Videos/";
        public static string RES_TIMELINE_ROOT_DIR => RES_DIR + "Timelines/";
        public static string RES_UI_ROOT_DIR => RES_DIR + "UI/";
        public static string RES_UI_COMPONENT_DIR => RES_UI_ROOT_DIR + "Component/";
        public static string RES_UI_IMAGES_DIR = RES_UI_ROOT_DIR + "Images/";
        public static string RES_UI_EFFECT_DIR => RES_UI_ROOT_DIR + "Effect/";
        public static string RES_LAYOUT_DIR => RES_UI_ROOT_DIR + "Layout/";
        public static string RES_UI_MATERIAL_DIR => RES_UI_ROOT_DIR + "Materials/";
        public static string RES_UI_ALTAS_DIR => RES_UI_ROOT_DIR + "Atlas/";
        public static string RES_UI_ALTAS_COMMON_DIR => RES_UI_ROOT_DIR + "Atlas/Common/";
        public static string RES_UI_COMPONENT_OBJECT_DIR => RES_UI_COMPONENT_DIR + "Object/";

        /// <summary>
        /// 获取图集路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetAtlasPathByName(string name) => StringUtil.GenString(RES_UI_ALTAS_DIR, name);

        /// <summary>
        /// 获取组件路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetUIComponentPathByName(string name) => StringUtil.GenString(RES_UI_COMPONENT_DIR, name);

        /// <summary>
        /// 获取UI特效组件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetUIFxComponentPathByName(string name) => StringUtil.GenString(RES_UI_EFFECT_DIR, name);

        /// <summary>
        /// 获取组件路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetUIMaterialPathByName(string name) => StringUtil.GenString(RES_UI_MATERIAL_DIR, name);

        /// <summary>
        /// 获取图片路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetImagePathByName(string name) => StringUtil.GenString(RES_UI_IMAGES_DIR, name);
        #endregion ==================================================================================================================


        #region 单位资源路径=========================================================================================================
        public static string GetUnitResPath(string path) => RES_DIR + path;
        #endregion ==================================================================================================================


        #region 特效资源路径=========================================================================================================
        public static string FX_DIR = RES_DIR + "Effect/Prefabs/";
        public static string GetFxPath(string path) => FX_DIR + path;
        #endregion ==================================================================================================================

        public static string GetMapConfigPath(int cfgId) => RES_MAP_CONFIG_ROOT_DIR + cfgId + ".txt";
    }
}
