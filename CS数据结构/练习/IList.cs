using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS数据结构.练习
{
    /// <summary>
    ///九大功能：长度|添加2|删除2|判空|取值|取索引|索引器
    /// </summary>
    interface IList<T>
    {
        int GetLength();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        void Clear();
        bool IsEmpty();
        T GetEle(int index);
        int Locate(T item);
        T this[int index] { get; }
    }
}
