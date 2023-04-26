using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    public class ExercisingPerson : ISubject
    {
        private List<IObserver> Watchers = new List<IObserver>();
        private bool laidDown;
        public bool LaidDown
        {
            get { return laidDown; }
            set
            {
                laidDown = value;
                Show(value);
            }
        }
        public void StandUp()
        {
            Console.WriteLine("Exercising person standed up.");
            LaidDown = false;
        }
        public void LayDown()
        {
            Console.WriteLine("Exercising person laid down.");
            LaidDown = true;
        }

        public void Show(bool value)
        {
            foreach (var watcher in Watchers)
            {
                watcher.SeeInstruction(value);
            }
        }
        public void Watch(IObserver spectator)
        {
            Watchers.Add(spectator);
        }
        public void UnWatch(IObserver spectator)
        {
            Watchers.Remove(spectator);
        }
    }
}
