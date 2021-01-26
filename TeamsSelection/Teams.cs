using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamsSelection
{
    public class Teams
    {

        public List<List<string>> GetAllPossibleTeamsOfThree(List<string> engineersList)
        {
            var allPossibleTeams = new List<List<string>>();
            var stackTeam = new Stack<string>();
            var totalItems = engineersList.Count;
            for(int i=0; i< totalItems; i++)
            {
                var p1 = i;
                var p2 = i + 1;
                stackTeam.Push(engineersList[p1]);
                while (p2 < totalItems){
                    stackTeam.Push(engineersList[p2]);
                    var p3 = p2 + 1;
                    while(p3< totalItems){
                        stackTeam.Push(engineersList[p3]);
                        if (!allPossibleTeams.Any(t => t.All(stackTeam.Contains))){
                            var tmp = new List<string>(stackTeam.ToList());
                            allPossibleTeams.Add(tmp);
                            stackTeam.Pop();
                        }
                        p3++;
                    }
                    p2++;
                    if (p3 == totalItems){
                        stackTeam.Pop();
                    }
                }
                stackTeam.Pop();
            }

            return allPossibleTeams;
        }

        public void PrintTeams(List<List<string>> allPossibleTeams)
        {
            for (int i = 0; i < allPossibleTeams.Count; i++)
            {
                var list = allPossibleTeams[i];
                for (int j = 0; j < list.Count; j++)
                {
                    Console.Write($"{list[j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}