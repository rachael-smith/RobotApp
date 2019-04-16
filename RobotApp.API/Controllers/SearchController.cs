using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RobotApp.API.Services;
using RobotApp.Data.DbSets;

namespace RobotApp.API.Controllers
{
    [ApiController]
    public class SearchController : ControllerBase
    {
        #region private variables and constructors 
        private readonly IRobotService _robotService;
        private readonly IChoreService _choreService;
        public SearchController(IRobotService robotService, IChoreService choreService)
        {
            _choreService = choreService;
            _robotService = robotService;
        }
        #endregion
        #region Public Methods
        [Route("api/GetRobotTypes")]
        public async Task<Dictionary<int, string>> GetRobotTypes() => await _robotService.GetRobotTypes();
        [Route("api/GetAllRobots")]
        public List<RobotInfo> GetAllRobots() => _robotService.GetAllRobots();
        [Route("api/GetRobotById")]
        public async Task<Robot> GetRobotById([FromBody]int id) => await _robotService.GetRobotById(id);
        [Route("api/SearchRobots")]
        public async Task<List<RobotInfo>> SearchRobots(SearchRequest request) => await _robotService.SearchRobots(request);
        [Route("api/GetChoresList")]
        public List<Chore> GetChoresList() => _choreService.GetChoresList();
        [Route("api/GetLeaderboard")]
        public List<Robot> GetLeaderboard() => _robotService.GetLeaderboard();
        #endregion
    }
}