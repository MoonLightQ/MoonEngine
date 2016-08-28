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
        ArrayList entityList = new ArrayList();

        public void Shuffle() {
            bool[] assigned = new bool[entityList.Count];
            ArrayList newEntityList = new ArrayList();
            Random sourceGen = new Random();
            int flag = 0;
            for (int i = 0; i < entityList.Count; i++) {
                int step = sourceGen.Next(entityList.Count);
                for (int j = 0; j < step; j++)
                    while (!assigned[flag])
                        flag = (flag + 1) % entityList.Count;
                assigned[flag] = true;
                newEntityList.Add(entityList[flag]);
            }
            entityList.RemoveRange(0, entityList.Count);
            entityList.AddRange(newEntityList);
        }
        
    }
}
