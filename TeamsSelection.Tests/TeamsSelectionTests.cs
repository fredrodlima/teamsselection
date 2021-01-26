using System;
using System.Collections.Generic;
using Xunit;
using TeamsSelection;

namespace TeamsSelection.Tests
{
    public class TeamsSelectionTests
    {
        [Fact]
        public void Test_GetAllPossibleTeams_Return_ExpectAmountOfResults()
        {
            var engineersList = new List<string>() { "H", "S", "B", "D", "N" };
            Teams teams = new Teams();
            int size=10; //This value was obtained from combinatorial formula N=5 R=3 => 5!/3!(5-3)! = 20/2 = 10
            var result = teams.GetAllPossibleTeamsOfThree(engineersList);
            Assert.Equal(size, result.Count);
        }
    }
}
