using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RobotApp.Data.DbSets
{
    public class Chore
    {
        public int ChoreID { get; set; }
        public string ChoreName { get; set; }
        public int TimeToComplete { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
