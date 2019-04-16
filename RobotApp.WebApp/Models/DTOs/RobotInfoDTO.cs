using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.WebApp
{
    public class RobotInfoDTO
    {
        public int RobotID { get; set; }
        [DisplayName("Robot Name")]
        public string RobotName { get; set; }
        public int RobotTypeID { get; set; }
        [DisplayName("Robot Type")]
        public string RobotTypeName { get; set; }
        public int ChoreID { get; set; }
        [DisplayName("Completed Chore")]
        public string CompletedChoreName { get; set; }
        [DisplayName("Number Of Chores Completed")]
        public int NumberOfChoresCompleted { get; set; }
    }
}
