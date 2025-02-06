using System;
using YooAsset;

namespace GameConst
{
    public class GlobalConst
    {
        public const int TimerInterval = 1;
        public const int GameFrameRate = 30;                        //游戏帧频
        public const float SingleFrameTime = 1F / GameFrameRate;

        public const int ScreenWidth = 1080;
        public const int ScreenHeight = 1920;

        //public static string WebServerAddress = "http://18.163.14.56:35001/";      //测试更新地址


        //public static int SocketPort = 37100;                           //Socket服务器端口
        //public static string GameServerAddress = "ws://18.163.14.56:37100/ws";                 //Socket服务器地址

        ///// <summary>
        ///// 资源服务器地址
        ///// </summary>
        //public const string CDN_IP = "";

        public static string Version = "0.0.0";

        /// <summary>
        /// 游戏资源包
        /// </summary>
        public const string ResPakcageGameRes = "GameRes";

        /// <summary>
        /// 原生资源包
        /// </summary>
        public const string ResPakcageGameRaw = "GameRaw";

        //模式
#if UNITY_EDITOR
        //在Unity3d编辑器下开启模拟器模式
        public static EPlayMode ResPlayMode = EPlayMode.EditorSimulateMode;
#else
        //运行模式
        public static EPlayMode ResPlayMode = EPlayMode.OfflinePlayMode;
#endif

    }
}
