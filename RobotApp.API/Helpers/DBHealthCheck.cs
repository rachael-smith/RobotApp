using Microsoft.Extensions.Diagnostics.HealthChecks;
using RobotApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RobotApp.API.Helpers
{
    public class DBHealthCheck : IHealthCheck
    {
        private RobotAppContext _context;
        public DBHealthCheck(RobotAppContext context) => _context = context;

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                _context.Database.CanConnect();
                return await Task.FromResult(HealthCheckResult.Healthy("Can connect to RobotApp database"));
            }
            catch
            {
                return await Task.FromResult(HealthCheckResult.Healthy("Can't connect to RobotApp database"));
            }
        }
    }
}
