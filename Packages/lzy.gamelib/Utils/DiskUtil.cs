using System;
using System.Collections.Generic;
using System.IO;

namespace GameUtils.Util
{
    public class DiskUtil
    {
        /// <summary>
        /// 检查磁盘空间
        /// </summary>
        /// <param name="diskPath">磁盘路径</param>
        /// <param name="minSpaceMB">阈值，表示磁盘空间不足的最小值（以MB为单位）</param>
        /// <returns></returns>
        public static ResultEnum CheckDiskSpace(string diskPath, float minSpaceMB)
        {
            return ResultEnum.SUCCEED;

            //这里先注释，在Android下，DriveInfo不支持，以后再改

            //DriveInfo drive = new DriveInfo(diskPath);

            //// 检查磁盘空间是否足够
            //if (drive.IsReady && drive.AvailableFreeSpace / (1024f * 1024f) < minSpaceMB)
            //{
            //    //磁盘空间不足
            //    return ResultEnum.FAILED;
            //}
            //else
            //{
            //    //磁盘空间充足
            //    return ResultEnum.SUCCEED;
            //}
            //try
            //{
            //    DriveInfo drive = new DriveInfo(diskPath);

            //    // 检查磁盘空间是否足够
            //    if (drive.IsReady && drive.AvailableFreeSpace / (1024f * 1024f) < minSpaceMB)
            //    {
            //        //磁盘空间不足
            //        return ResultEnum.FAILED;
            //    }
            //    else
            //    {
            //        //磁盘空间充足
            //        return ResultEnum.SUCCEED;
            //    }
            //}
            //catch (Exception e)
            //{
            //    //$"检查磁盘空间时发生错误：{e.Message}"
            //    string mssage = e.Message;
            //    return ResultEnum.ERROR;
            //}
        }
    }
}
