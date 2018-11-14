using System;

namespace IsTreeBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check whether a binary tree is a BST!");
            Console.WriteLine("-------------------------------------");

            BinaryTree binaryTree = ConstructBST();
            Console.WriteLine();
            if (TreeUtility.IsTreeBST(binaryTree?.GetRootNode()))
            {
                Console.WriteLine("------Entered tree is a BST!-----");
            }
            else {
                Console.WriteLine("------Entered tree is not a BST!-----");
            }

            Console.ReadLine();
        }

        private static BinaryTree ConstructBST() {
            BinaryTree binaryTree = null;
            Console.WriteLine("Enter the number of elements to construct the tree");
            try
            {
                binaryTree = new BinaryTree();
                int noOfElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                for (int i = 0; i < noOfElements; i++) {
                    binaryTree.Insert(int.Parse(elements[i]));
                }
                binaryTree.PrintTree(binaryTree.GetRootNode());
            }catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return binaryTree;
        }
    }
}
