using System;
using System.Collections.Generic;
using System.Text;

// Anita Russo (101073718)

namespace WeaponShopAssign2
{
    class Player
    {
        public string name;
        public Backpack backpack;
        public int numItems;
        public double money;
        public int backpack_max_weight;

        public Player(string n, double m)
        {
            name = n;
            money = m;
            numItems = 0;
            backpack_max_weight = 20;
            backpack = new Backpack(backpack_max_weight);
        }

        public void buy(Weapon w)
        {
            
          

            if (backpack.addWeapon(w) == true)
            {
                Console.WriteLine(w.weaponName + " bought...\n");
                w.count--;
                numItems++;
                Console.Write(numItems);
            }
            else
            {
                Console.WriteLine("This item is too heavy to add to your bag");
            }
           
        }
        public void withdraw(double amt)
        {
            money = money - amt;
        }

        public bool inventoryFull()
        {
            bool full = false;
            if (numItems == 10) full = true;
            return full;
        }


        public void printCharacter()
        {
            Console.WriteLine(" Name: "+name+"\n Money:"+money);
            printBackpack();
        }

        public void printBackpack()
        {
            Console.WriteLine(" "+name+", you own "+numItems+" Weapon(s):");
            backpack.printBackPack();
           
            Console.WriteLine();
        }
    }
}
