using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.API
{
    public class RobotInfo
    {
        public int RobotID { get; set; }
        public string RobotName { get; set; }
        public int RobotTypeID { get; set; }
        public string RobotTypeName { get; set; }
        public int ChoreID { get; set; }
        public string CompletedChoreName { get; set; }
        public int NumberOfChoresCompleted { get; set; }
    }
}
