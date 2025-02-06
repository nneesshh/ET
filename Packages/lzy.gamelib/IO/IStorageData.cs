namespace GameUtils.IO
{
    public interface IStorageData
    {
        string headKey { get; set; }

        /// <summary>
        /// 保存本地数据 INT类型
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        bool SaveLocalIntData(string key, int value);

        /// <summary>
        /// 获取本地数据 INT类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        int GetLocalIntDataByKey(string key);

        /// <summary>
        /// 获取本地数据 FLOAT类型
        /// </summary>
        /// <param name="key"></param>
        float GetLocalFloatDataByKey(string key);

        /// <summary>
        /// 保存本地数据 STRING类型
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        bool SaveLocalStringData(string key, string value);

        /// <summary>
        /// 保存本地数据 FLOAT类型
        /// </summary>
        /// <param name="key"></param>
        bool SaveLocalFloatData(string key, float value);

        /// <summary>
        /// 获取本地数据 STRING类型
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetLocalStringDataByKey(string key);

        /// <summary>
        /// 是否有数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool HasLocalDataByKey(string key);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool DeleteDataByKey(string key);

        /// <summary>
        /// 删除所有数据
        /// </summary>
        /// <returns></returns>
        bool DeleteAllData();
    }
}
