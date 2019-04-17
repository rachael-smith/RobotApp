using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.API.Models
{
    public class CompletedChoreDTO
    {
        public int ChoreCompletedID { get; set; }
        public int RobotCompletedID { get; set; }
        public long TimeTakenToComplete { get; set; }
        public DateTime TimeCompleted { get; set; } = DateTime.Now;
        public bool ChoreCompletedSuccessfully { get; set; }
        public string ChoreCompleted { get; set; }
        public string RobotName { get; set; }
    }
}
