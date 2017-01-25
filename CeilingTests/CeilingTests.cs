using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS4150PS2;
using System.IO;
using System.Collections.Generic;

namespace CeilingTests
{
    [TestClass]
    public class CeilingTests
    {
        Ceiling c;
        List<BST> trees;

        [TestMethod]
        public void TestCorrect1()
        {
            c = new Ceiling();
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
            Assert.AreEqual("4", c.UniqueTreesTesting(trees));
        }

        [TestMethod]
        public void TestCorrect2()
        {
            {
                c = new Ceiling();
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
                Assert.AreEqual("2", c.UniqueTreesTesting(trees));
            }
        }
        [TestMethod]
        public void TestLeftStick1()
        {
            {
                c = new Ceiling();
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
                Assert.AreEqual("1", c.UniqueTreesTesting(trees));
            }
        }
        [TestMethod]
        public void TestRightStick1()
        {
            {
                c = new Ceiling();
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
                Assert.AreEqual("1", c.UniqueTreesTesting(trees));
            }
        }
        [TestMethod]
        public void TestLeftRightStick1()
        {
            {
                c = new Ceiling();
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
                Assert.AreEqual("0", c.UniqueTreesTesting(trees));
            }
        }
       [TestMethod]
        public void Test2SameShape()
        {
            {
                c = new Ceiling();
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
                Assert.AreEqual("2", c.UniqueTreesTesting(trees));
            }
        }
    }
}
