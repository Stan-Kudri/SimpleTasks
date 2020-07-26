using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks
{
    interface ISimpleTaskExecute
    {
        string Name { get; }
        void Execute();
    }
}
