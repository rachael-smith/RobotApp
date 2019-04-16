using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.API
{
    public class CreateUpdateRobot
    {
        public int RobotID { get; set; }
        public string RobotName { get; set; }
        public int RobotType { get; set; }
    }
}
