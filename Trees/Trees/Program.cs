using System;
using System.ComponentModel;
using System.IO;
using System.Linq.Expressions;

namespace Trees
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;
            
        internal Node(int d)
        {
            data = d;
            left = null;
            right = null;
        }
    }

    class Tree
    {
        internal Node root;

        internal void generalinsert(Node node,int value)
        {
            Node new_node = new Node(value);
            if (node.data < value)
            {
                if (node.right != null)
                {
                    generalinsert(node.right,value);
                }
                else
                {
                    node.right = new_node;
                }
            }
            if (node.data > value)
            {
                if (node.left != null)
                {
                    generalinsert(node.left, value);
                }
                else
                {
                    node.left = new_node;
                }
            }
        }
        
        internal void insertvalue(Tree btree,int value)
        {
            Node new_node = new Node(value);
            if (btree.root == null)
            {
                btree.root = new_node;
            }
            else
            {
                generalinsert(btree.root, value);
            }
            
        }

        internal void outputtree(Tree btree)
        {
            Node current = btree.root;
            Console.WriteLine(current.data);
            
        }
        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.data);
                TraversePreOrder(parent.left);
                TraversePreOrder(parent.right);
            }
        }

        public void getsortedlist(Node parent)
        {
            if (parent.left != null)
            {
                getsortedlist(parent.left);
                Console.WriteLine(parent.data);
            }
            if (parent.left == null)
            {
                Console.WriteLine(parent.data);
            }
            if (parent.right != null)
            {
                getsortedlist(parent.right);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Tree btree = new Tree();
            btree.insertvalue(btree, 10);
            btree.insertvalue(btree, 15);
            btree.insertvalue(btree, 5);
            btree.insertvalue(btree, 4);
            btree.TraversePreOrder(btree.root);
            Console.WriteLine("Getting Sorted Value");
            btree.getsortedlist(btree.root);
            
        }
    }
}
