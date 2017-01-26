using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4150PS2
{
    public class Ceiling
    {
        /// <summary>
        /// List of trees from the input
        /// </summary>
        List<BST> TreeList;

        static void Main(string[] args)
        {
            Ceiling c = new Ceiling();
            Console.WriteLine(c.CreateTrees());
        }


        public string CreateTrees()
        {
            string line = "";
            char[] whitespace = { ' ', '\t' };
            string[] numbers;
            int count = 0;
            BST tree;
            TreeList = new List<BST>();
            while ((line = Console.ReadLine()) != null && line != "")
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
            return UniqueTrees(TreeList);
        }
        /// <summary>
        /// Determines the number of unique tree shapes
        /// </summary>
        /// <returns></returns>
        public string UniqueTrees(List<BST> t)
        {
            int uniqueCount = 0;
            int sameCount = 0;
            if (t.Count == 0)
            {
                return "0";
            }
            if (t.Count == 1)
            {
                return "1";
            }

            // Checks to see how many trees are the same shape

            for (int i = 0; i < t.Count - 1; i++)
            {
                for (int j = i + 1; j < t.Count; j++)
                {
                    if (SameShape(t.ElementAt(i).GetRoot(), t.ElementAt(j).GetRoot()))
                    {
                        sameCount++;
                    }
                    // If all the same
                    if (sameCount == t.Count)
                    {
                        return "1";
                    }
                }
            }
            uniqueCount = t.Count - sameCount;
            return uniqueCount.ToString();
        }

        /// <summary>
        /// Determines if two trees are the same shape
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public bool SameShape(Node root1, Node root2)
        {
            // Empty trees are same size
            if (root1 == null && root2 == null)
                return true;

            // Empty tree is not same shape as non-empty one (obviously)
            if ((root1 == null && root2 != null)
                || (root1 != null && root2 == null))
                return false;

            // otherwise check recursively
            return SameShape(root1.GetLeft(), root2.GetLeft())
                && SameShape(root1.GetRight(), root2.GetRight());
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

        /// <summary>
        /// Gets Left child of node
        /// </summary>
        /// <returns></returns>
        public Node GetLeft()
        {
            return left;
        }

        /// <summary>
        /// Gets right child of node
        /// </summary>
        /// <returns></returns>
        public Node GetRight()
        {
            return right;
        }
    }

    /// <summary>
    /// Creates a BST
    /// </summary>
    public class BST
    {
        // Root of the tree
        private Node root;


        /// <summary>
        /// BST Constructor
        /// </summary>
        public BST()
        {
            root = null;
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
