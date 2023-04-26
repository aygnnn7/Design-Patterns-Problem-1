using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    public class Instructor
    {
        private IInstruction Instruction;

        public void setInstruction(IInstruction instruction)
        {
            Instruction = instruction;
        }

        public void giveInstruction()
        {
            Console.WriteLine();
            Instruction.GiveInstruction();
        }
        public void UndoIt()
        {
            Console.WriteLine();
            Instruction.Undo();
        }

    }
}
