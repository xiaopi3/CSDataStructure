using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS数据结构
{
    /// <summary>
    /// 九大功能：长度|增2|删|清|判断|取值2|取索引
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IList<T>
    {
        int GetLength();//获取长度
        void Add(T item);//添加
        void Insert(T item, int index);//插入
        T Delete(int index);//删除
        void Clear();//清空
        bool IsEmpty();//判断空
        T GetEle(int index);//依据索引获取值
        T this[int index] { get; }//同上
        int Locate(T item);//依据值获取索引
    }
}
