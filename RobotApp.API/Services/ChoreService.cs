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
        /// <summary>
        /// Has a robot a chore that is passed to it
        /// </summary>
        /// <param name="choreInfo"></param>
        /// <returns></returns>
        public async Task<CompletedChoreDTO> PerformChore(PerformChore choreInfo)
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
                var completedChore = await UpdateCompletedChores(_stopwatch, chore.ChoreID, robot.RobotID);
                return CreateCompletedTaskDTO(completedChore, robot.RobotName, chore.ChoreName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Gets a list of all chores from database
        /// </summary>
        /// <returns></returns>
        public List<Chore> GetChoresList() => _RobotAppContext.Chores.ToList();
        #endregion
        #region Private Methods
        /// <summary>
        /// Updates the Completed Chores table with the chore that was just performed
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="choreId"></param>
        /// <param name="robotId"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Creates the DTO that passes to the front end so it can show notification of completion (needed to pass a couple extra params to front end)
        /// </summary>
        /// <param name="completedChore"></param>
        /// <param name="robotName"></param>
        /// <param name="choreName"></param>
        /// <returns></returns>
        private CompletedChoreDTO CreateCompletedTaskDTO(CompletedChore completedChore, string robotName, string choreName)
        {
            var completedChoreResponse = new CompletedChoreDTO
            {
                TimeTakenToComplete = completedChore.TimeTakenToComplete,
                ChoreCompletedID = completedChore.ChoreCompletedID,
                RobotCompletedID = completedChore.RobotCompletedID,
                ChoreCompletedSuccessfully = true,
                RobotName = robotName,
                ChoreCompleted = choreName
            };
            return completedChoreResponse;
        }
        #endregion
    }
}
