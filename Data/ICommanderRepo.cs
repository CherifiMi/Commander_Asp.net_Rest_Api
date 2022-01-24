using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
        void CreatCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeletCommand(Command cmd);
    }
}
