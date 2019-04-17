using Microsoft.AspNetCore.Mvc;
using RobotApp.API.Models;
using RobotApp.API.Services;
using RobotApp.Data;
using RobotApp.Data.DbSets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RobotApp.API.Controllers
{
    [ApiController]
    public class ChoreController : ControllerBase
    {
        #region private variables and constructors 
        private readonly IChoreService _choreService;
        public ChoreController(IChoreService choreService) => _choreService = choreService;
        #endregion

        #region Public Methods
        [Route("api/PerformChore")]
        public async Task<CompletedChoreDTO> PerformChore([FromBody]PerformChore choreInfo) => await _choreService.PerformChore(choreInfo);
        #endregion
    }
}