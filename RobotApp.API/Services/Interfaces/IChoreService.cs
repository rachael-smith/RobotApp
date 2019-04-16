using System.Collections.Generic;
using System.Threading.Tasks;
using RobotApp.API.Models;
using RobotApp.Data.DbSets;

namespace RobotApp.API.Services
{
    public interface IChoreService
    {
        List<Chore> GetChoresList();
        Task<CompletedChore> PerformChore(PerformChore choreInfo);
    }
}