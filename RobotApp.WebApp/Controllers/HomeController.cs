using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ModTool.WebClient.Helpers;
using RobotApp.WebApp.Helpers;
using RobotApp.WebApp.Models;
using RobotApp.WebApp.Models.DTOs;

namespace RobotApp.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var robotTypeDictionary = await new HttpRequestHelper().Get<Dictionary<int, string>>($@"api/GetRobotTypes");
            var result = new CreateRobotModalViewModel
            {
                ChoresList = await new HttpRequestHelper().Get<List<ChoreDTO>>($@"api/GetChoresList"),
                RobotTypesList = new DropdownsHelper().GetSelectListItems(robotTypeDictionary),
                Leaderboard = await new HttpRequestHelper().Get<List<RobotDTO>>($@"api/GetLeaderboard"),
            };
            return View("Index", result);
        }

        public async Task<CompletedChoreDTO> PerformChore([FromBody]PerformChoreDTO choreInfo)
        {
            var result = await new HttpRequestHelper().Post<CompletedChoreDTO, PerformChoreDTO>($@"api/PerformChore", choreInfo);
            return result;
        }
        public async Task<JsonResult> CreateRobot([FromBody]CreateUpdateRobotDTO robotInfo)
        {
            var robotId = await new HttpRequestHelper().Post<int, CreateUpdateRobotDTO>($@"api/CreateRobot", robotInfo);
            if (robotId > 0)
            {
                return Json(new { success = true, robotId });
            }
            else
            {
                return Json(new { success = false, robotId });
            }
        }
    }
}
