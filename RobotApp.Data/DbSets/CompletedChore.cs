using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RobotApp.Data.DbSets
{
    public class CompletedChore
    {
        public int CompletedChoreID { get; set; }
        public int ChoreCompletedID { get; set; }
        public int RobotCompletedID { get; set; }
        public long TimeTakenToComplete { get; set; }
        public DateTime TimeCompleted { get; set; } = DateTime.Now;
        public bool ChoreCompletedSuccessfully { get; set; }
    }
}
