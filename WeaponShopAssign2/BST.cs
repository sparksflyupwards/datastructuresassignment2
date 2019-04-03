using System;
namespace WeaponShopAssign2

// Anita Russo (101073718)
// Saad Khan (101157307)

{
    public class BST
    {
        public Weapon root;

        public BST()
        {
            root = null;
        }

        public void insert(Weapon w) {
            root = insertWorker(root, w);
        }

        public Weapon insertWorker(Weapon curr, Weapon w) {
            if (curr == null) return w;
            if (w.weaponName.CompareTo(curr.weaponName) == -1) {
                curr.left = insertWorker(curr.left, w);
            } 
            if (w.weaponName.CompareTo(curr.weaponName) == 1) {
                curr.right = insertWorker(curr.right, w);
            }
            if (w.weaponName.CompareTo(curr.weaponName) == 0)
            {
                curr.count++;
            }
            return curr;
        }

        public void printInOrder() {
            inOrderWorker(root);
        }

        public void inOrderWorker(Weapon curr) {
            if (curr == null) return;
            inOrderWorker(curr.left);
            Console.WriteLine("Weapon: {0} (In stock: {1})\nDamage: {2}\tCost: {3}\n",
                              curr.weaponName, curr.count, curr.damage, curr.cost);
            inOrderWorker(curr.right);
        }

        public Weapon search(string name) {
            return searchWorker(root, name);
        }

        public Weapon searchWorker(Weapon curr, string name) {
            if (curr == null) return null;
            if (curr.weaponName == name) return curr;
            if (name.CompareTo(curr.weaponName) == -1) {
                return searchWorker(curr.left, name);
            }
            return searchWorker(curr.right, name);
        }


    }
}
