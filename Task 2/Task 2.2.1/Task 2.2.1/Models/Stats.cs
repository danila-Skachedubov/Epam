using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1
{
    class Stats
    {
        private int hp;
        private double hp_reg;
        private double damage;

        public Stats()
        {
            hp = 100;

        }

        public Stats(int hp, int energy)
        {
            this.hp = hp;

        }

    }
}