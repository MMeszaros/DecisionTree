using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree
{
    class BinaryTree : ITree
    {
        protected Branch origin;
        protected Branch current;

        public Branch Origin { get { return origin; } set { origin = value; } }
        public Branch Current { get { return current; } set { current = value; } }

        protected class BinaryBranch : Branch
        {
            BinaryBranch(string Name, string Data) : base (Name, Data)
            {
                this.branches = new List<Branch>(2);
            }
        }

        BinaryTree()
        {

        }
    }
}
