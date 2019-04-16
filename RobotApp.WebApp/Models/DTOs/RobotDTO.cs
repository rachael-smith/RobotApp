using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApp.WebApp
{
    public class RobotDTO
    {
        public int RobotID { get; set; }
        public string RobotName { get; set; }
        public int RobotTypeID { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public int NumberOfChoresCompleted { get; set; }
    }
}
