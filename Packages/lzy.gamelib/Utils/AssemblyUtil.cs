using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GameUtils.Util
{
    public class AssemblyUtil
    {
        /// <summary>
        /// 获取程序集
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Assembly GetAssemblyByName(string name)
        {
            return AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == name);
        }
    }
}
