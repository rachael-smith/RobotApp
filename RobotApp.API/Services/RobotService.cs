using Microsoft.EntityFrameworkCore;
using RobotApp.Data;
using RobotApp.Data.DbSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.API.Services
{
    public class RobotService : IRobotService
    {
        #region private variables and constructors
        private readonly RobotAppContext _RobotAppContext;
        public RobotService(RobotAppContext RobotAppContext) => _RobotAppContext = RobotAppContext;
        #endregion

        #region Public Methods
        /// <summary>
        /// Get a robot from the database by id passed
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Robot> GetRobotById(int Id) => await _RobotAppContext.Robots.FindAsync(Id);

        /// <summary>
        /// Creates a robot
        /// </summary>
        /// <param name="robotInfo"></param>
        /// <returns></returns>
        public async Task<Robot> CreateRobot(CreateUpdateRobot robotInfo)
        {
            var newRobot = new Robot
            {
                RobotTypeID = robotInfo.RobotType,
                RobotName = robotInfo.RobotName
            };
            _RobotAppContext.Robots.Add(newRobot);
            await _RobotAppContext.SaveChangesAsync();
            return newRobot;
        }

        /// <summary>
        /// updates a robot with information passed
        /// </summary>
        /// <param name="robotInfo"></param>
        /// <returns></returns>
        public async Task<bool> UpdateRobot(CreateUpdateRobot robotInfo)
        {
            var success = false;
            try
            {
                var robot = await _RobotAppContext.Robots.FindAsync(robotInfo.RobotID);
                robot.RobotTypeID = robotInfo.RobotType;
                robot.RobotName = robotInfo.RobotName;
                _RobotAppContext.Robots.Update(robot);
                await _RobotAppContext.SaveChangesAsync();
                success = true;
            }
            catch (Exception e)
            {
                success = false;
            }
            return success;
        }

        /// <summary>
        /// gets all robots from the database
        /// </summary>
        /// <returns></returns>
        public List<RobotInfo> GetAllRobots() => GetAllRobotsIQueryable().OrderBy(x => x.RobotID).ToList();

        /// <summary>
        /// Performs search on params passed
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<List<RobotInfo>> SearchRobots(SearchRequest request)
        {
            //TODO:make robot type and chore search by id not string 
            var filter = request.SearchText.ToLower();
            var query = GetAllRobotsIQueryable();
            try
            {
                switch (request.SearchBy.ToLower())
                {
                    case "robotid":
                        var intFilter = int.Parse(filter);
                        return await query.Where(sr => sr.RobotID == intFilter).ToListAsync();
                    case "robotname":
                        return await query.Where(sr => sr.RobotName == filter).ToListAsync();
                    case "robottypename":
                        return await query.Where(sr => sr.RobotTypeName.ToLower() == filter).ToListAsync();
                    case "taskcompeleted":
                        return await query.Where(sr => sr.CompletedChoreName == filter).ToListAsync();
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets current leaderboard
        /// </summary>
        /// <returns></returns>
        public List<Robot> GetLeaderboard() => _RobotAppContext.Robots.OrderByDescending(x => x.NumberOfChoresCompleted).Take(10).ToList();

        /// <summary>
        /// Gets a dictionary of the robot types (dictionary so they will stay as key value pairs)
        /// </summary>
        /// <returns></returns>
        public async Task<Dictionary<int, string>> GetRobotTypes() => await _RobotAppContext.RobotTypes.Distinct().ToDictionaryAsync(t => t.RobotTypeID, t => t.RobotTypeName);

        #endregion
        /// <summary>
        /// query that needs to be filtered to get all the information for a robot (used for search)
        /// </summary>
        /// <returns></returns>
        private IQueryable<RobotInfo> GetAllRobotsIQueryable()
        {
            try
            {
                var query = (from robot in _RobotAppContext.Robots
                             join robotType in _RobotAppContext.RobotTypes on robot.RobotTypeID equals robotType.RobotTypeID into robotRobotTypeJoin
                             from robotRobotType in robotRobotTypeJoin.DefaultIfEmpty()
                             join completedChore in _RobotAppContext.CompletedChores on robot.RobotID equals completedChore.RobotCompletedID into robotCompletedChoresJoin
                             from robotCompletedChores in robotCompletedChoresJoin
                             join Chores in _RobotAppContext.Chores on robotCompletedChores.ChoreCompletedID equals Chores.ChoreID into choresRobotCompletedChoresJoin
                             from choresRobotCompletedChores in choresRobotCompletedChoresJoin
                             select new RobotInfo
                             {
                                 RobotID = robot.RobotID,
                                 RobotName = robot.RobotName,
                                 RobotTypeName = robotRobotType.RobotTypeName,
                                 RobotTypeID = robotRobotType.RobotTypeID,
                                 ChoreID = choresRobotCompletedChores.ChoreID,
                                 CompletedChoreName = choresRobotCompletedChores.ChoreName,
                                 NumberOfChoresCompleted = robot.NumberOfChoresCompleted
                             });
                return query;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
