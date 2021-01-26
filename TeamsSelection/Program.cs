using System.Collections.Generic;

namespace TeamsSelection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var engineersList = new List<string> { "Herb", "Shane", "Brent", "Diego", "Nathan" };
            Teams teams= new Teams();
            var ret = teams.GetAllPossibleTeamsOfThree(engineersList);
            teams.PrintTeams(ret);
        }
        
    }
}
