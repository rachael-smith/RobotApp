using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RobotApp.WebApp.Models
{
    public class Search
    {
        public List<RobotInfoDTO> SearchResults { get; set; }
        public SearchRequestDTO SearchCriteria { get; set; }
    }
}
