using System;

namespace _002_BINARY_TREE
{
    class BinaryTree
    {
        /*
        ...
        */

        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }

        public TreeNode Find(int data)
        {
            //checking if the root is not null
            if (root != null)
            {
                return root.Find(data);
            }
            else
            {
                return null;
            }
        }
    }
}