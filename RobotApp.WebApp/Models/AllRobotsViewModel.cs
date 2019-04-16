using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RobotApp.WebApp.Models
{
    public class AllRobotsViewModel
    {
        public List<RobotInfoDTO> Robots { get; set; }
        public IEnumerable<SelectListItem> CompletedTasksList { get; set; }
        public IEnumerable<SelectListItem> RobotTypesList { get; set; }
        public List<ChoreDTO> ChoresList { get; set; }

    }
}
