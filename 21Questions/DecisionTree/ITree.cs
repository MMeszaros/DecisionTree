using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree
{
    public interface ITree
    {
        Branch Origin { get; set; }

        Branch Current { get; set; }
    }
}
