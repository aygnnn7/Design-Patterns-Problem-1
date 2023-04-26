
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    public class StandUpCommand : IInstruction
    {
        private ExercisingPerson ExercisingP;

        public StandUpCommand(ExercisingPerson exercisingP)
        {
            ExercisingP = exercisingP;
        }

        public void GiveInstruction()
        {
            Console.WriteLine("Instructor gave instruction - stand up.");
            ExercisingP.StandUp();
        }

        public void Undo()
        {
            Console.WriteLine("Instructor undid instruction - stand up.");
            ExercisingP.LayDown();
        }
    }
}
