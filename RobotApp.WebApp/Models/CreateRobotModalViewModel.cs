using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.WebApp.Models
{
    public class CreateRobotModalViewModel
    {
        public List<ChoreDTO> ChoresList { get; set; }
        public IEnumerable<SelectListItem> RobotTypesList { get; set; }
        public List<RobotDTO> Leaderboard { get; set; }
    }
}
