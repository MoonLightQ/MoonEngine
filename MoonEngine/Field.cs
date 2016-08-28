using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MoonEngine
{
    class Field
    {
        public ArrayList entityList = new ArrayList();
        public void Add(object o)
        {
            entityList.Add(o);
        }
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
        }
        
    }
}
