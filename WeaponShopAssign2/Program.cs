using System;

// Anita Russo (101073718)

namespace WeaponShopAssign2
{
    class Program
    {
        public static void addWeapons(BST b)
        {
            Console.WriteLine("------------------\nWEAPON ADDING MENU\n------------------\n");
            string weaponName; int weaponRange; int weaponDamage; double weaponWeight; double weaponCost;
            Console.WriteLine("Please enter the NAME of the Weapon ('end' to quit):");
            weaponName=Console.ReadLine();
            while (weaponName.CompareTo("end") != 0)
            {
                Console.WriteLine("Please enter the Range of the Weapon (0-10):");                
                weaponRange= Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Please enter the Damage of the Weapon:");
                weaponDamage=Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Please enter the Weight of the Weapon (in pounds):");
                weaponWeight= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the Cost of the Weapon:");
                weaponCost=Convert.ToDouble(Console.ReadLine());
                Weapon w = new Weapon(weaponName, weaponRange, weaponDamage, weaponWeight, weaponCost);
                b.insert(w);
                Console.WriteLine("\nPlease enter the NAME of another Weapon ('end' to quit):");
                weaponName = Console.ReadLine();
            }
        }

        public static void printShowRoom(BST b, Player p)
        {
            Console.WriteLine("\n--------\nSHOWROOM\n--------");
            b.printInOrder();
            Console.WriteLine(" You have " + p.money + " money.");
            Console.WriteLine("Please select a weapon to buy('end' to quit):");
        }

        public static void showRoom(BST b, Player p)
        {
            string choice;
            printShowRoom(b, p);
            choice=Console.ReadLine();
            while (choice.CompareTo("end") != 0 && !p.inventoryFull())
            {
                Weapon w = b.search(choice);
                if (w != null)
                {
                    if (w.cost > p.money)
                    {
                        Console.WriteLine("Insufficient funds to buy "+w.weaponName );

                    }
                    else if (w.count < 1) {
                        Console.WriteLine("Out of stock!");
                    }
                    else
                    {
                        p.buy(w);
                        p.withdraw(w.cost);

                        printShowRoom(b,p);

                
                    }
                }
                else
                {
                    Console.WriteLine(" ** "+choice+" not found!! **" );
                }
                Console.WriteLine("Please select another weapon to buy('end' to quit):");
                choice = Console.ReadLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string pname;
            Console.Write("Please enter Player name: ");
            pname = Console.ReadLine();
            Console.WriteLine();
            Player pl = new Player(pname,45);
            BST b = new BST();
            addWeapons(b);
            showRoom(b, pl);
            pl.printCharacter();
            Console.ReadKey();

        }
    }
}
