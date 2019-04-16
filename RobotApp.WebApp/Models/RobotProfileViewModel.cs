using Microsoft.AspNetCore.Mvc.Rendering;
using RobotApp.WebApp.Models;
using System.Collections.Generic;

namespace RobotApp.WebApp
{
    public class RobotProfileViewModel
    {
        public RobotDTO Robot { get; set; }
        public IEnumerable<SelectListItem> RobotTypesList { get; set; }
        public List<ChoreDTO> ChoresList { get; set; }
    }
}
