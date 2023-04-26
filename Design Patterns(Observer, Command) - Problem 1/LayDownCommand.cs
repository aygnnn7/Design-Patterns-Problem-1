
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    public class LayDownCommand : IInstruction
    {
        private ExercisingPerson ExercisingP;

        public LayDownCommand(ExercisingPerson exercisingP)
        {
            ExercisingP = exercisingP;
        }

        public void GiveInstruction()
        {
            Console.WriteLine("Instructor gave instruction - lay down.");
            ExercisingP.LayDown();
        }
        
        public void Undo()
        {
            ExercisingP.StandUp();
            Console.WriteLine("Instructor undid instruction - lay down.");
        }
    }
}
