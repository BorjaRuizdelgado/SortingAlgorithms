using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.src
{
    public class BinaryTreeSort : SortingAlgorithm
    {
        internal class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }
        public BinaryTreeSort()
        {
            root = null;
        }

        public void Sort(int[] array)
        {
            Treeins(array);
            List<int> list = new List<int>();
            InorderRec(root, list);
            Array.Copy(list.ToArray(), array, array.Length);
        }

        

        // Root of BST
        Node root;

        // Constructor
        

        // This method mainly
        // calls insertRec()
        void Insert(int key)
        {
            root = InsertRec(root, key);
        }

        /* A recursive function to
          insert a new key in BST */
        Node InsertRec(Node root, int key)
        {

            /* If the tree is empty,
                return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur
                down the tree */
            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else if (key > root.key)
                root.right = InsertRec(root.right, key);

            /* return the root */
            return root;
        }

        // A function to do
        // inorder traversal of BST
        void InorderRec(Node root, List<int> list)
        {
            if (root != null)
            {
                InorderRec(root.left, list);
                list.Add(root.key);
                InorderRec(root.right, list);

            }
        }
        void Treeins(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Insert(arr[i]);
            }

        }
    }
}

