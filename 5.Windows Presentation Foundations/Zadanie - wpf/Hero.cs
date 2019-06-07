using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie___wpf
{
    class Hero
    {
        private int hp;
        private string name;
        private int minDmg;
        private int maxDmg;

        public Hero(string name)
        {
            this.name = name;
            this.hp = 100;
            this.minDmg = 10;
            this.maxDmg = 30;
        }

        

        //getters and setters
        //name
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        //hp
        public int getHp()
        {
            return this.hp;
        }

        public void setHp(int hp)
        {
            this.hp = hp;
        }

        //minDmg
        public void setMinDmg(int minDmg)
        {
            this.minDmg = minDmg;
        }

        public int getMinDmg()
        {
            return minDmg;
        }

        //maxDmg
        public void setMaxDmg(int maxDmg)
        {
            this.maxDmg = maxDmg;
        }

        public int getMaxDmg()
        {
            return maxDmg;
        }


    }
}
