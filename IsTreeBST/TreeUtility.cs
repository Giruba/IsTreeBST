using System;
using System.Collections.Generic;
using System.Text;

namespace IsTreeBST
{
    static class TreeUtility
    {
        private static BinaryTreeNode previousNode;

        public static bool IsTreeBST(BinaryTreeNode rootNode) {
            return _IsTreeBST(rootNode);
        }

        /* Inorder Traversal of a BST prints the tree in ascending order.
         * Hence, traverse the tree 'Inorder' checking the previous node's
         * value whenever a node is encountered.
         * If any previous node's value is greater than the value of the 
         * current node, return false as the tree is not a BST
         */
        private static bool _IsTreeBST(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return true;
            }

            if (!_IsTreeBST(binaryTreeNode.GetLeftNode())) {
                return false;
            }

            if (previousNode != null) {
                if (previousNode.GetData() > binaryTreeNode.GetData()) {
                    return false;
                }
            }

            previousNode = binaryTreeNode;

            return _IsTreeBST(binaryTreeNode.GetRightNode());
        }
    }
}
