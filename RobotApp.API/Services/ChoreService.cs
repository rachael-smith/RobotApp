using RobotApp.API.Models;
using RobotApp.Data;
using RobotApp.Data.DbSets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RobotApp.API.Services
{
    public class ChoreService : IChoreService
    {
        #region private variables and constructors
        private readonly RobotAppContext _RobotAppContext;
        private Stopwatch _stopwatch;
        public ChoreService(RobotAppContext RobotAppContext)
        {
            _stopwatch = new Stopwatch();
            _RobotAppContext = RobotAppContext;
        }
        #endregion
        #region Public Methods
        public async Task<CompletedChore> PerformChore(PerformChore choreInfo)
        {
            var chore = await _RobotAppContext.Chores.FindAsync(choreInfo.ChoreID);
            var robot = await _RobotAppContext.Robots.FindAsync(choreInfo.RobotID);

            try
            {
                if (chore != null)
                {
                    _stopwatch.Start();
                    Thread.Sleep(chore.TimeToComplete);
                    _stopwatch.Stop();
                }
                robot.NumberOfChoresCompleted = robot.NumberOfChoresCompleted + 1;
                _RobotAppContext.SaveChanges();
                return await UpdateCompletedChores(_stopwatch, chore.ChoreID, robot.RobotID);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Chore> GetChoresList() => _RobotAppContext.Chores.ToList();
        #endregion
        #region Private Methods
        private async Task<CompletedChore> UpdateCompletedChores(Stopwatch timer, int choreId, int robotId)
        {
            var completedChore = new CompletedChore
            {
                TimeTakenToComplete = timer.ElapsedMilliseconds,
                ChoreCompletedID = choreId,
                RobotCompletedID = robotId,
                ChoreCompletedSuccessfully = true
            };
            _RobotAppContext.CompletedChores.Add(completedChore);
            await _RobotAppContext.SaveChangesAsync();
            return completedChore;
        }
        #endregion
    }
}
