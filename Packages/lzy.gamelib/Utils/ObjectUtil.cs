using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using GameUtils.IO;

namespace GameUtils.Util
{
    public class ObjectUtil
    {
        /// <summary>
        /// 生成对象唯一Key
        /// 结合对象的类型和内存地址
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetObjectUniqueKey(object obj)
        {
            if (obj == null)
            {
                return "null";
            }

            // 使用对象的类型和哈希码生成唯一字符串
            string objectType = obj.GetType().FullName;
            // 内存地址
            int objectHashCode = RuntimeHelpers.GetHashCode(obj);
            string uniqueKey = $"{objectType}_{objectHashCode}";
            return uniqueKey;
        }

        /// <summary> 
        /// 将一个object对象序列化，返回一个byte[]         
        /// </summary> 
        /// <param name="obj">能序列化的对象</param>         
        /// <returns></returns> 
        public static byte[] ObjectToBytes(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter(); formatter.Serialize(ms, obj); return ms.GetBuffer();
            }
        }

        /// <summary> 
        /// 将一个序列化后的byte[]数组还原         
        /// </summary>
        /// <param name="Bytes"></param>         
        /// <returns></returns> 
        public static object BytesToObject(byte[] Bytes)
        {
            using (MemoryStream ms = new MemoryStream(Bytes))
            {
                IFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(ms);
            }
        }

        /// <summary>
        /// 对象深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepCopyByBinary<T>(T obj)
        {
            object retval;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                retval = bf.Deserialize(ms);
                ms.Close();
            }
            return (T)retval;
        }

        public static void CloneList<T>(ref List<T> destination, List<T> source)
        {
            if (destination == null)
                destination = new List<T>();
            else
            {
                if (Equals(destination, source))
                {
                    GameLog.LogError($"CloneList 参数 destination 和 source 是同一个内存引用：{destination}");
                }
                destination.Clear();
            }

            for (int i = 0; i < source.Count; i++)
            {
                destination.Add(source[i]);
            }
        }

        public static void CloneDictionary<TKey, TValue>(ref Dictionary<TKey, TValue> destination, Dictionary<TKey, TValue> source)
        {
            if (destination == null)
                destination = new Dictionary<TKey, TValue>();
            else
            {
                if (Equals(destination, source))
                {
                    GameLog.LogError($"CloneDictionary 参数 destination 和 source 是同一个内存引用：{destination}");
                }
                destination.Clear();
            }

            foreach (var pair in source)
            {
                destination[pair.Key] = pair.Value;
            }
        }
    }
}
