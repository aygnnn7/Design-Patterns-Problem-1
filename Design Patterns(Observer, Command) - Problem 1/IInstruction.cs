using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    public interface IInstruction
    {
        void GiveInstruction();
        void Undo();
    }
}
