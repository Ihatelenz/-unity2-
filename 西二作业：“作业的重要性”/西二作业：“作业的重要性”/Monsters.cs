using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 西二作业__作业的重要性_
{
    class Monsters
    {
        public string monstorName;
        private int hp;
        private int mp;

        public Monsters() { }

        public Monsters(string m_monsterName, int m_HP, int m_MP)
        {
            monstorName = m_monsterName;
            HP = m_HP;
            MP = m_MP;
        }

        public int HP
        {
            get { return hp; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                hp = value;
            }
        }

        public int MP
        {
            get { return mp; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                mp = value;
            }
        }
    }
    
}
