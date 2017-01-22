using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4150PS2
{
    class Ceiling
    {
        /// <summary>
        /// List of trees from the input
        /// </summary>
        List<BST> TreeList;

        static void Main(string[] args)
        {
            Ceiling c = new Ceiling();
            Console.WriteLine(c.UniqueTrees());
        }

        /// <summary>
        /// Determines the number of unique tree shapes
        /// </summary>
        /// <returns></returns>
        public string UniqueTrees()
        {
            string line = "";
            char[] whitespace = { ' ', '\t' };
            string[] numbers;
            int count = 0;
            BST tree;
            TreeList = new List<BST>();
            while((line = Console.ReadLine()) != null)
            {
                if (count > 0)
                {
                    // Creates a new tree from the input
                    tree = new BST();
                    numbers = line.Split(whitespace);
                    foreach (string number in numbers)
                    {
                        tree.AddNode(number);
                    }
                    TreeList.Add(tree);
                }
                count++;
            }
            

            
            return "";
        }
    }

    /// <summary>
    /// Creates a BST node
    /// </summary>
    public class Node
    {
        public string value;
        public Node left;
        public Node right;

        /// <summary>
        /// Node Constructor
        /// </summary>
        /// <param name="value"></param>
        public Node(string value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }

    /// <summary>
    /// Creates a BST
    /// </summary>
    public class BST
    {
        // Root of the tree
        private Node root;
        private int count;

        /// <summary>
        /// BST Constructor
        /// </summary>
        public BST()
        {
            root = null;
            count = 0;
        }

        /// <summary>
        /// Gets the root of the tree
        /// </summary>
        /// <returns></returns>
        public Node GetRoot()
        {
            return root;
        }

        public Node AddNode(string s)
        {
            Node node = new Node(s);
            try
            {
                if(root == null)
                {
                    root = node;
                }
                else
                {
                    Add(node, ref root);
                }
                return node;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// Finds the position of node to be inserted
        /// </summary>
        /// <param name="n"></param>
        /// <param name="tree"></param>
        private void Add(Node n, ref Node tree)
        {
            if (tree == null)
            {
                tree = n;
            }
            else
            {
                int compareResult = string.Compare(n.value, tree.value);
                if (compareResult == 0)
                {
                    throw new Exception();
                }
                else if (compareResult < 0)
                {
                    Add(n, ref tree.left);
                }
                else if (compareResult > 0)
                {
                    Add(n, ref tree.right);
                }
            }
        }
    }

}
