using System;
using System.Collections.Generic;
using System.Text;

// Anita Russo (101073718)
// Saad Khan (101157307)

namespace WeaponShopAssign2
{   // This class implements a backpack as a linked list
    // The backpack can hold any number of weapons as long as maxWeight is not crossed.
    // If an attempt to add a weapon to backpack is rejected due to weight
    class Backpack
    {
        double maxWeight;
        double presentWeight;
        Weapon root;


        public Backpack(double max_weight)
        {
            root = null;
            presentWeight = 0;
            maxWeight = max_weight;
        }

        public bool addWeapon(Weapon wpn)
        {
            if (presentWeight + wpn.weight > maxWeight)
            {
                return false;
            }
            if(root == null)
            {
                presentWeight += wpn.weight;
                root = wpn;
                return true;
            }

            if(root.next == null)
            {
                presentWeight += wpn.weight;
                root.next = wpn;
                return true;
            }

            Weapon currentWeapon = root.next;

            while (currentWeapon.next != null)
            {
                currentWeapon = currentWeapon.next;
            }

            presentWeight += wpn.weight;
            currentWeapon.next = wpn;
            return true;        
        }

        public void printBackPack()
        {
            Weapon currentWpn = root;
            if(currentWpn == null)
            {
                return;
            }


            while(currentWpn!= null)
            {
               Console.WriteLine(currentWpn.weaponName);
                currentWpn = currentWpn.next;
            }

        }


    }

    
}
