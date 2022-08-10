using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the unique identifier of the matchup entry model
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the team competing id from the database, used to identify TeamCompeting
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        /// 
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the parent matchup id from the database, used to identify ParentMatchup
        /// </summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represents the matchup that team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
