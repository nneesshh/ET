
namespace GameUtils.IO
{
    public static class StorageData
    {
        private static IStorageData _storageData;

        public static void SetStorageData(IStorageData newStorageData)
        {
            _storageData = newStorageData;
        }

        public static void SetHeadKey(string key)
        {
            _storageData.headKey = key;
        }

        /// <summary>
        /// 保存本地数据 INT类型
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SaveLocalIntData(string key, int value)
        {
            return _storageData.SaveLocalIntData(key, value);
        }

        /// <summary>
        /// 保存本地数据 FLOAT类型
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SaveLocalFloatData(string key, float value)
        {
            return _storageData.SaveLocalFloatData(key, value);
        }


        /// <summary>
        /// 获取本地数据 INT类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetLocalIntDataByKey(string key)
        {
            return _storageData.GetLocalIntDataByKey(key);
        }

        /// <summary>
        /// 获取本地数据 FLOAT类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static float GetLocalFloatDataByKey(string key)
        {
            return _storageData.GetLocalFloatDataByKey(key);
        }

        /// <summary>
        /// 保存本地数据 STRING类型
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SaveLocalStringData(string key, string value)
        {
            return _storageData.SaveLocalStringData(key, value);
        }

        /// <summary>
        /// 获取本地数据 STRING类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetLocalStringDataByKey(string key)
        {
            return _storageData.GetLocalStringDataByKey(key);
        }

        /// <summary>
        /// 是否有数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool HasLocalDataByKey(string key)
        {
            return _storageData.HasLocalDataByKey(key);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool DeleteDataByKey(string key)
        {
            return _storageData.DeleteDataByKey(key);
        }

        /// <summary>
        /// 删除所有数据
        /// </summary>
        /// <returns></returns>
        public static bool DeleteAllData()
        {
            return _storageData.DeleteAllData();
        }
    }
}
