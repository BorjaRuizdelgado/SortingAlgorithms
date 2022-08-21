using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.src
{
    //Tree sort is a sorting algorithm that is based on Binary Search Tree data structure.
    //It first creates a binary search tree from the elements of the input list or array and then
    //performs an in-order traversal on the created binary search tree to get the elements in sorted order. 
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

        Node root;

        public BinaryTreeSort() => root = null;

        public void Sort(int[] array)
        {
            PopulateBinaryTreeWithArray(array);
            List<int> list = new List<int>();
            InorderRec(root, list);
            Array.Copy(list.ToArray(), array, array.Length);
        }
     
        void Insert(int key)
        {
            root = InsertNodeRecursively(root, key);
        }

        Node InsertNodeRecursively(Node root, int key)
        {

            if (root == null)
            {
                root = new Node(key);
                return root;
            }
            if (key < root.key)
                root.left = InsertNodeRecursively(root.left, key);
            else if (key > root.key)
                root.right = InsertNodeRecursively(root.right, key);

            return root;
        }

        void InorderRec(Node root, List<int> list)
        {
            if (root != null)
            {
                InorderRec(root.left, list);
                list.Add(root.key);
                InorderRec(root.right, list);

            }
        }

        void PopulateBinaryTreeWithArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Insert(arr[i]);
            }
        }
    }
}

