using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise start!");
            

            Instructor instructor = new Instructor();
            ExercisingPerson exercisingPerson = new ExercisingPerson();
            OnlineSpectator alexSpectator = new OnlineSpectator("Alex");
            OnlineSpectator ivanSpectator = new OnlineSpectator("Ivan");
            OnlineSpectator MariaSpectator = new OnlineSpectator("Maria");

            exercisingPerson.Watch(alexSpectator);
            exercisingPerson.Watch(ivanSpectator);
            exercisingPerson.Watch(MariaSpectator);

            instructor.setInstruction(new LayDownCommand(exercisingPerson));
            instructor.giveInstruction();
            instructor.UndoIt();
            instructor.giveInstruction();

            Console.WriteLine("Ivan lefts.");
            exercisingPerson.UnWatch(ivanSpectator);

            instructor.setInstruction(new StandUpCommand(exercisingPerson));
            instructor.giveInstruction();
            instructor.UndoIt();

            Console.WriteLine();
            Console.WriteLine("Exercise done!");
            Console.ReadLine();
        }
    }
}
