using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    public class OnlineSpectator : IObserver
    {
        public string Name { get; set; }

        public OnlineSpectator(string name)
        {
            Name = name;
        }

        public void SeeInstruction(bool laidDown)
        {
            string instruction = laidDown ? "laid down" : "standed up";
            Console.WriteLine(Name + $" saw the instruction and {instruction} too.");
        }
    }
}
