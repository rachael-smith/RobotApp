using Microsoft.EntityFrameworkCore;
using RobotApp.Data.DbSets;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.Data
{
    public class RobotAppContext : DbContext
    {
        public RobotAppContext(DbContextOptions options) : base(options) { }

        public DbSet<Robot> Robots { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<CompletedChore> CompletedChores { get; set; }
        public DbSet<RobotType> RobotTypes { get; set; }
    }
}
