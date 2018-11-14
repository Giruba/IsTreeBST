using System;
using System.Collections.Generic;
using System.Text;

namespace IsTreeBST
{
    class BinaryTreeNode
    {
        int data;
        BinaryTreeNode leftNode;
        BinaryTreeNode rightNode;

        public BinaryTreeNode(int data) {
            this.data = data;
        }

        public int GetData() {
            return data;
        }

        public BinaryTreeNode GetLeftNode() {
            return leftNode;
        }

        public BinaryTreeNode GetRightNode() {
            return rightNode;
        }
        
        public void SetData(int data) {
            this.data = data;
        }

        public void SetLeftNode(BinaryTreeNode leftNode) {
            this.leftNode = leftNode;
        }

        public void SetRightNode(BinaryTreeNode rightNode) {
            this.rightNode = rightNode;
        }
    }
}
