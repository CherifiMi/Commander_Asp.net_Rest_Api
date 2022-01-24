using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContect _contect;

        public SqlCommanderRepo(CommanderContect contect)
        {
            _contect = contect;
        }

        public void CreatCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _contect.Commands.Add(cmd);
        }
        public void DeletCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _contect.Commands.Remove(cmd);
        }

        public Command GetCommandById(int id)
        {
            return _contect.Commands.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Command> GetCommands()
        {
            return _contect.Commands.ToList();
        }

        public bool SaveChanges()
        {
            return(_contect.SaveChanges()>=0);
        }

        public void UpdateCommand(Command cmd)
        {
            //no
        }
    }
}
