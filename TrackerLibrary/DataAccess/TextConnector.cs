using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamsFile = "TeamModels.csv";
        private const string TournamentsFile = "TournamentModels.csv";
        private const string MatchupsFile = "MatchupModels.csv";
        private const string MatchupEntriesFile = "MatchupEntryModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            // * Load the text file
            // * Convert the text to List<PrizeModel>
            List<PersonModel> people = GetPerson_All();

            // *Find the max id
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new ID (max+1)
            people.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to text file
            people.SaveToPeopleFile(GlobalConfig.PeopleFile);

            return model;
        }
        //TODO- convert all the files to global config versions
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // * Load the text file
            // * Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // *Find the max id
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new ID (max+1)
            prizes.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to text file
            prizes.SaveToPrizesFile(PrizesFile);

            return model;


        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamsFile(TeamsFile);
            return model;
        }

        // TODO - Convert other Create** to void methods as returning is unnecessary
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentsFile.
                FullFilePath().
                LoadFile().
                ConvertToTournamentModels(TeamsFile, PeopleFile, PrizesFile);

            // Add id, create id if none
            int currentId = 1;

            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Save the current id into the roundsfile
            model.SaveToRoundsFile(MatchupsFile, MatchupEntriesFile);

            tournaments.Add(model);

            tournaments.SaveToTournamentsFile(TournamentsFile);
        }
        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
        public List<TeamModel> GetTeam_All()
        {
            return TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }
        public List<TournamentModel> GetTournament_All()
        {
            return TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamsFile, PeopleFile, PrizesFile);
        }
    }
}
