using Commander.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class CommanderContect:DbContext
    {
        public CommanderContect(DbContextOptions<CommanderContect> opt):base(opt)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}
