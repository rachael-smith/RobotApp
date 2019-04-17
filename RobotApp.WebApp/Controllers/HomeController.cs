using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Leaderboard()
        {
            var robotTypeDictionary = await new HttpRequestHelper().Get<Dictionary<int, string>>($@"api/GetRobotTypes");
            var result = new CreateRobotModalViewModel
            {
                ChoresList = await new HttpRequestHelper().Get<List<ChoreDTO>>($@"api/GetChoresList"),
                RobotTypesList = new DropdownsHelper().GetSelectListItems(robotTypeDictionary),
                Leaderboard = await new HttpRequestHelper().Get<List<RobotDTO>>($@"api/GetLeaderboard"),
            };
            return View("Leaderboard", result);
        }
        public async Task<CompletedChoreDTO> PerformChore([FromBody]PerformChoreDTO choreInfo)
        {
            var result = await new HttpRequestHelper().Post<CompletedChoreDTO, PerformChoreDTO>($@"api/PerformChore", choreInfo);
            return result;
        }
        public async Task<RobotDTO> CreateRobot([FromBody]CreateUpdateRobotDTO robotInfo) => await new HttpRequestHelper().Post<RobotDTO, CreateUpdateRobotDTO>($@"api/CreateRobot", robotInfo);
    }
}
