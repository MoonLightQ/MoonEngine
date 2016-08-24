using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonEngine
{
    class Card
    {
        public readonly UInt32 ID;
        public readonly string Name;
        public readonly string Description;

        private readonly Int32 originAttack;
        private readonly Int32 originLife;
        private readonly Int32 originMana;

        private Int32 attack;
        private Int32 life;
        private Int32 maxLife;
        private Int32 mana;

        private Card()
        {

        }

        public Card(string def)
        {
            //TODO;
        }

        public int Initialize()
        {
            //TODO;
            return 0;
        }
    }
}
