using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModTool.WebClient.Helpers;
using RobotApp.WebApp.Helpers;
using RobotApp.WebApp.Models;
using RobotApp.WebApp.Models.DTOs;

namespace RobotApp.WebApp.Controllers
{
    public class RobotController : Controller
    {
        public async Task<ViewResult> Index()
        {
            var robotTypeDictionary = await new HttpRequestHelper().Get<Dictionary<int, string>>($@"api/GetRobotTypes");
            var result = new AllRobotsViewModel
            {
                Robots = await new HttpRequestHelper().Get<List<RobotInfoDTO>>($@"api/GetAllRobots"),
                ChoresList = await new HttpRequestHelper().Get<List<ChoreDTO>>($@"api/GetChoresList"),
                RobotTypesList = new DropdownsHelper().GetSelectListItems(robotTypeDictionary),
            };
            return View("Robots", result);
        }
        public async Task<ActionResult> Search(SearchRequestDTO request)
        {
            var result = new AllRobotsViewModel
            {
                Robots = await new HttpRequestHelper().Post<List<RobotInfoDTO>, SearchRequestDTO>($@"api/SearchRobots", request)
            };
            return View("Robots", result);
        }
        public async Task<ActionResult> RobotProfile(int id)
        {
            var robotTypeDictionary = await new HttpRequestHelper().Get<Dictionary<int, string>>($@"api/GetRobotTypes");
            var result = new RobotProfileViewModel
            {
                Robot = await new HttpRequestHelper().Post<RobotDTO, int>($@"api/GetRobotById", id),
                ChoresList = await new HttpRequestHelper().Get<List<ChoreDTO>>($@"api/GetChoresList"),
                RobotTypesList = new DropdownsHelper().GetSelectListItems(robotTypeDictionary)
            };
            return View("RobotProfile", result);
        }
        public async Task<JsonResult> UpdateRobot([FromBody]CreateUpdateRobotDTO robotInfo)
        {
            var robotId = await new HttpRequestHelper().Post<int, CreateUpdateRobotDTO>($@"api/UpdateRobot", robotInfo);
            if (robotId > 0)
            {
                return Json(new { success = true});
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }
}