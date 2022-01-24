using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    //hiiiiiiiiiiiiiiii
    
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreatCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeletCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "hi", Line = "zero" };
        }

        public IEnumerable<Command> GetCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0,HowTo="hi",Line="zero"},
                new Command{Id=1,HowTo="ho",Line="one"},
                new Command{Id=2,HowTo="ha",Line="two"},
                new Command{Id=3,HowTo="he",Line="three"}
            };
            return commands;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
