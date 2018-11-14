using System;
using System.Collections.Generic;
using System.Text;

namespace IsTreeBST
{
    class BinaryTree
    {
        BinaryTreeNode rootNode;

        public BinaryTree() { }

        public void SetRootNode(BinaryTreeNode binaryTreeNode) {
            rootNode = binaryTreeNode;
        }

        public BinaryTreeNode GetRootNode() {
            return rootNode;
        }

        public void Insert(int data) {
            rootNode = _InsertUtil(rootNode, data);
        }

        private BinaryTreeNode _InsertUtil(BinaryTreeNode binaryTreeNode, int data) {

            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode(data);
                return binaryTreeNode;
            }
            
            if (binaryTreeNode.GetLeftNode() == null)
            {
                binaryTreeNode.SetLeftNode(
                    _InsertUtil(binaryTreeNode.GetLeftNode(), data)
                    );
            }
            else {
                binaryTreeNode.SetRightNode(
                    _InsertUtil(binaryTreeNode.GetRightNode(), data)
                    );
            }

            return binaryTreeNode;
        }

        public void PrintTree(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null)
            {
                Console.WriteLine("Entered tree is null!");
            }
            else {
                Console.WriteLine("-------Printing Inorder Traversal--------");
                InorderTraversal(binaryTreeNode);
            }
        }

        public void InorderTraversal(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }
            InorderTraversal(binaryTreeNode.GetLeftNode());
            Console.Write(binaryTreeNode.GetData()+"->");
            InorderTraversal(binaryTreeNode.GetRightNode());
        }        
    }
}
