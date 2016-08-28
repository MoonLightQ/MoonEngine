using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MoonEngine
{
    public class EntityList : CollectionBase
    {
        /// <summary>
        /// 将对象添加到 EntityList 的结尾处。
        /// </summary>
        /// <param name="newEntity"></param>
        public void Add(Entity newEntity)
        {
            List.Add(newEntity);
        }

        public void Remove(Entity oldEntity)
        {
            List.Remove(oldEntity);
        }

        public Entity this[int entityIndex]
        {
            get
            {
                return (Entity)List[entityIndex];
            }
            set
            {
                List[entityIndex] = value;
            }
        }

        /// <summary>
        /// 将该 EntityList 内的元素拷贝到目标 EntityList 中。
        /// </summary>
        /// /// <param name="targetEntityList">目标 EntityList。</param>
        public void CopyTo(EntityList targetEntityList)
        {
            for(int index = 0; index < this.Count; index++)
            {
                targetEntityList[index] = this[index];
            }
        }


    }
}
