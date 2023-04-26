using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    public interface ISubject
    {
        void Watch(IObserver spectator);
        void UnWatch(IObserver spectator);
        void Show(bool laidDown);
    }
}
