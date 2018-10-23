using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree
{
    public class Branch
    {
        protected string name;

        protected string data;

        protected List<Branch> branches;

        string Name { get; set; }
        string Data { get; set; }
        List<Branch> Branches { get; }

        public Branch(string Name, string Data)
        {
            name = Name;
            data = Data;
        }
    }
}
