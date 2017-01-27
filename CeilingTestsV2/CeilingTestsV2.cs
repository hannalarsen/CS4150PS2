using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PS2version2;
using System.Collections.Generic;
using System.IO;

namespace CeilingTestsV2
{
    [TestClass]
    public class CeilingTestsV2
    {
        CeilingV2 c;
        List<BST> trees;

        [TestMethod]
        public void TestCorrect1()
        {
            c = new CeilingV2();
            trees = new List<BST>();
            int count = 0;
            BST tree;
            string[] numbers;
            char[] whitespace = { ' ', '\t' };
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\1.in"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
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
                        trees.Add(tree);
                    }
                    count++;
                }
            }
            Assert.AreEqual("4", c.UniqueTrees(trees));
        }

        [TestMethod]
        public void TestCorrect2()
        {
            c = new CeilingV2();
            trees = new List<BST>();
            int count = 0;
            BST tree;
            string[] numbers;
            char[] whitespace = { ' ', '\t' };
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\2.in"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
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
                        trees.Add(tree);
                    }
                    count++;
                }
            }
            Assert.AreEqual("2", c.UniqueTrees(trees));
        }

        [TestMethod]
        public void TestCorrect3()
        {
            c = new CeilingV2();
            trees = new List<BST>();
            int count = 0;
            BST tree;
            string[] numbers;
            char[] whitespace = { ' ', '\t' };
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\testCorrect3.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
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
                        trees.Add(tree);
                    }
                    count++;
                }
            }
            Assert.AreEqual("3", c.UniqueTrees(trees));
        }
        [TestMethod]
        public void TestLeftStick1()
        {
            {
                c = new CeilingV2();
                trees = new List<BST>();
                int count = 0;
                BST tree;
                string[] numbers;
                char[] whitespace = { ' ', '\t' };
                using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\leftStick.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
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
                            trees.Add(tree);
                        }
                        count++;
                    }
                }
                Assert.AreEqual("1", c.UniqueTrees(trees));
            }
        }
        [TestMethod]
        public void TestRightStick1()
        {
            {
                c = new CeilingV2();
                trees = new List<BST>();
                int count = 0;
                BST tree;
                string[] numbers;
                char[] whitespace = { ' ', '\t' };
                using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\rightStick.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
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
                            trees.Add(tree);
                        }
                        count++;
                    }
                }
                Assert.AreEqual("1", c.UniqueTrees(trees));
            }
        }
        [TestMethod]
        public void TestLeftRightStick1()
        {
            {
                c = new CeilingV2();
                trees = new List<BST>();
                int count = 0;
                BST tree;
                string[] numbers;
                char[] whitespace = { ' ', '\t' };
                using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\leftRightStick.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
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
                            trees.Add(tree);
                        }
                        count++;
                    }
                }
                Assert.AreEqual("2", c.UniqueTrees(trees));
            }
        }
        [TestMethod]
        public void Test2SameShape()
        {
            {
                c = new CeilingV2();
                trees = new List<BST>();
                int count = 0;
                BST tree;
                string[] numbers;
                char[] whitespace = { ' ', '\t' };
                using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\2SameShape.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
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
                            trees.Add(tree);
                        }
                        count++;
                    }
                }
                Assert.AreEqual("1", c.UniqueTrees(trees));
            }

        }
        [TestMethod]
        public void Test5SameShape()
        {
            c = new CeilingV2();
            trees = new List<BST>();
            int count = 0;
            BST tree;
            string[] numbers;
            char[] whitespace = { ' ', '\t' };
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\5SameShape.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
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
                        trees.Add(tree);
                    }
                    count++;
                }
            }
            Assert.AreEqual("1", c.UniqueTrees(trees));
        }
        [TestMethod]
        public void Test3AllDifferent()
        {
            c = new CeilingV2();
            trees = new List<BST>();
            int count = 0;
            BST tree;
            string[] numbers;
            char[] whitespace = { ' ', '\t' };
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\3AllDifferent.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
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
                        trees.Add(tree);
                    }
                    count++;
                }
            }
            Assert.AreEqual("3", c.UniqueTrees(trees));
        }

        [TestMethod]
        public void TestCorrect4()
        {
            c = new CeilingV2();
            trees = new List<BST>();
            int count = 0;
            BST tree;
            string[] numbers;
            char[] whitespace = { ' ', '\t' };
            using (StreamReader sr = File.OpenText(@"C:\Users\hannal\Documents\testCorrect4.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
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
                        trees.Add(tree);
                    }
                    count++;
                }
            }
            Assert.AreEqual("4", c.UniqueTrees(trees));
        }
    }

}
