using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.WebApp
{
    public class CompletedChoreDTO
    {
        public int CompletedTaskID { get; set; }
        public int TaskCompletedID { get; set; }
        public int RobotCompletedID { get; set; }
        public long TimeTakenToComplete { get; set; }
        public DateTime TimeCompleted { get; set; } = DateTime.Now;
        public bool ChoreCompletedSuccessfully { get; set; }
    }
}
