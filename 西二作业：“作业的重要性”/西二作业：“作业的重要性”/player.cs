using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 西二作业__作业的重要性_
{
    class Player
    {
        public string playername;
        private int hp;
        private int mp;
        public int level;
        public Player() { }

        public Player(string m_name, int m_HP, int m_MP, int m_level)
        {
            playername = m_name;
            HP = m_HP;
            MP = m_MP;
            level = m_level;
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
