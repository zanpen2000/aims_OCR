using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionsLib
{
    /// <summary>
    /// 可遍历容器扩展类
    /// author:张鹏
    /// 日期：2014/2/24
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// 对象的string值，obj为空不抛异常
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string StringValue(this object obj)
        {
            if (obj != null)
            {
                return obj.ToString();
            }
            else return "";
        }

        /// <summary>
        /// 延迟返回可遍历结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Func<T, T> func)
        {
            source.ThrowIfNull("source");
            func.ThrowIfNull("func");
            foreach (T element in source)
            {
                yield return func(element);
            }
        }

        /// <summary>
        /// 针对每个元素执行action
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            source.ThrowIfNull("source");
            action.ThrowIfNull("action");
            foreach (T element in source)
            {
                action(element);
            }
        }

        /// <summary>
        /// 检查对象
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="msg"></param>
        public static void ThrowIfNull(this object obj, string msg)
        {
            if (obj == null)
            {
                throw new NullReferenceException(msg);
            }
        }
    }
}
