// Created by: Braxton Fair
// Created on: 02/18/2021

using System;
using System.Collections.Generic;

namespace NestedForLoop
{
    public class Tree
    {
        // our private variables
        private int maxNumber = -1;
        private string treeLeaf = "n/a";

        // our gets and sets
        public int MaxNumber
        {
            get => this.maxNumber;
            set => this.maxNumber = value;
        }

        public string TreeLeaf
        {
            get => this.treeLeaf;
            set => this.treeLeaf = value;
        }

        // Our constructor
        public Tree(int max) : this(max, "*") { }

        public Tree(int max, string leaf)
        {
            this.MaxNumber = max;
            this.TreeLeaf = leaf;
        }

        // our other methods
        public void CreateTree()
        {
            for(var i =0;:q
                    :q
            for(var i = 1; i <= this.MaxNumber; i++)
            {
                Console.Write(this.TreeLeaf);
            }
        }
    }
}
