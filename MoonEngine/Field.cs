using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MoonEngine
{
    /// <summary>
    /// 定义了游戏中广义的场地，如棋盘、牌库、墓地等。游戏中的各种实体必须存在于场地之中。
    /// Field 类封装了一个 EntryList。
    /// </summary>
    class Field
    {
        private ArrayList entityList = new ArrayList();

        /// <summary>
        /// 添加一个对象到 Field 中。
        /// </summary>
        /// <param name="o">要添加的对象（按引用传递）。</param>
        public void Add(object o)
        {
            entityList.Add(o);
        }

        /// <summary>
        /// 将该 Field 中的对象重新随机排列。
        /// </summary>
        public void Shuffle() {
            bool[] assigned = new bool[entityList.Count];
            ArrayList newEntityList = new ArrayList();
            Random sourceGen = new Random();
            int flag = 0;
            for (int i = 0; i < entityList.Count; i++)
                assigned[i] = false;
            for (int i = 0; i < entityList.Count; i++) {
                int step = sourceGen.Next(entityList.Count);
                for (int j = 0; j < step; j++)
                    do
                        flag = (flag + 1) % entityList.Count;
                    while (assigned[flag]);
                assigned[flag] = true;
                newEntityList.Add(entityList[flag]);
            }
            entityList.RemoveRange(0, entityList.Count);
            entityList.AddRange(newEntityList);
            EntityList e = new EntityList();
            
        }
        
    }
}
