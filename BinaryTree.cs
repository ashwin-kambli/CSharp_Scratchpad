using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryTree
    {
        private Node _root; 
        public BinaryTree()
        {
            _root = null;
        }

        public void Add(int val)
        {
            if(_root == null)
            {
                _root = new Node(val);
                return;
            }

            Node current = _root;
            Node parent = null; 
            while(current != null)
            {
                if(val < current.Value)
                {
                    parent = current;
                    current = current.Left; 
                }
                else
                {
                    parent = current;
                    current = current.Right; 
                }
            }
            Node node = new Node(val);
            if(val < parent.Value)
            {
                parent.Left = node;
            }
            else
            {
                parent.Right = node; 
            }
        }

        public bool Search(int searchVal)
        {
            Node current = _root; 
            while(current != null)
            {
                if (current.Value == searchVal)
                    return true;

                if (searchVal < current.Value)
                    current = current.Left;
                else
                    current = current.Right; 
            }
            return false; 
        }

        public void Delete(int val)
        {
            if (_root == null)
            {
                Console.WriteLine($"Tree is empty. Cannot delete {val}");
                return;
            }

            _root = DeleteRecursive(_root, val);
                return; 
        }

        private Node DeleteRecursive(Node root, int val)
        {
            if(root == null)
                return null;

            if(val < root.Value)
                root.Left = DeleteRecursive(root.Left, val);    
            else if(val > root.Value)
                root.Right = DeleteRecursive(root.Right, val);
            else //Match found
            {
                if (root.Left == null && root.Right == null) //Leaf Node
                    return null;
                else if(root.Left == null && root.Right != null)
                {
                    return root.Right; 
                }
                else if(root.Right == null && root.Left != null)
                {
                    return root.Left; 
                }
                else
                {
                    //Not leaf and has both sub-trees.
                    //TODO: Find max in left subtree and assign that ehre and delete the left max
                    return null; 
                }
            }
            return root; 
        }

        public void Print()
        {
             PrintRecurive(_root);
        }

        private void PrintRecurive(Node node)
        {
            if (node.Left != null)
                PrintRecurive(node.Left);

            Console.WriteLine($"{node.Value}, ");

            if(node.Right != null)
                PrintRecurive(node.Right);
        }
    }

    public class Node
    {
        private int _val;
        private Node _left;
        private Node _right; 
        public Node(int val)
        {
            _val = val;
            _left = null; 
            _right = null; 
        }

        public Node Left {  get { return _left; } set { _left = value; } }
        public Node Right { get { return _right; } set { _right = value; } }
        public int Value { get { return _val; } }
    }
}
