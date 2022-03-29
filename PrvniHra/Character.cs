using System;
using System.Collections.Generic;
using System.Text;

namespace PrvniHra
{
    class Character
    {
        private int shield;
        private int hp;
        private int damage;

        public string Name { get; }
        public int HP { get=> hp;  }
        public int Shield { get=>shield; }
        public int Damage { get=>damage;  }

        public Character(string name)
        {
            Name = name;
            hp = 100;
            shield = 50;
            damage = 20;
        }

        public void GetHit(int damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                hp += shield;
                shield = 0;
            }

        }

        public void

        public override string ToString()
        {
            string text = "Name: " + Name + "\n";
            text += "HP: " + HP + "\n";
            text += "Shield: " + Shield + "\n";
            text += "Damage: " + Damage + "\n";
            return text;
        }
    }

}
