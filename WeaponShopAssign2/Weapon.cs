using System;
using System.Collections.Generic;
using System.Text;

// Anita Russo (101073718)

namespace WeaponShopAssign2
{
    public class Weapon
    {
        public string weaponName;
        public int range;
        public int damage;
        public double weight;
        public double cost;
        public int count;
        public Weapon right;
        public Weapon left;
        public Weapon next;

        public Weapon(string n, int rang, int dam, double w, double c)
        {
            weaponName = n;
            damage = dam;
            range = rang;
            weight = w;
            cost = c;
            count = 1;
            right = null;
            left = null;
            next = null;
        }
    }
}
