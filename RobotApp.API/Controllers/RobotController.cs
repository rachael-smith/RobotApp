using Microsoft.AspNetCore.Mvc;
using RobotApp.API.Services;
using RobotApp.Data;
using RobotApp.Data.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.API.Controllers
{
    [ApiController]
    public class RobotController : ControllerBase
    {
        #region private variables and constructors 
        private readonly IRobotService _robotService;
        public RobotController(IRobotService robotService) => _robotService = robotService;
        #endregion

        [Route("api/CreateRobot")]
        public async Task<int> CreateRobot([FromBody]CreateUpdateRobot robotInfo) => await _robotService.CreateRobot(robotInfo);
        [Route("api/UpdateRobot")]
        public async Task<bool> UpdateRobot([FromBody]CreateUpdateRobot robotInfo) => await _robotService.UpdateRobot(robotInfo);
    }
}
