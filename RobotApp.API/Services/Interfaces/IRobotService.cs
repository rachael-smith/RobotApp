using System.Collections.Generic;
using System.Threading.Tasks;
using RobotApp.Data.DbSets;

namespace RobotApp.API.Services
{
    public interface IRobotService
    {
        Task<Robot> CreateRobot(CreateUpdateRobot robotInfo);
        List<RobotInfo> GetAllRobots();
        List<Robot> GetLeaderboard();
        Task<Robot> GetRobotById(int Id);
        Task<Dictionary<int, string>> GetRobotTypes();
        Task<List<RobotInfo>> SearchRobots(SearchRequest request);
        Task<bool> UpdateRobot(CreateUpdateRobot robotInfo);
    }
}