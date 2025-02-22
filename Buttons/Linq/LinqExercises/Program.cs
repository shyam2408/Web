using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises;
class Program
{
    static void Main(string[] args)
    {
        //You can get the trainee details from the GetTraineeDetails() method in TraineeData class
        TraineeData traineeData = new();
        List<TraineeDetails> trainees = traineeData.GetTraineeDetails();
        while (true)
        {
            System.Console.WriteLine("\nSelect Your option :");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    // Press 1 to Show the list of Trainee Id
                    var traineeIDs = trainees.Select(t => t.TraineeId);
                    System.Console.WriteLine("Trainee ID: " + string.Join(",", traineeIDs));
                    break;
                }
                case 2:
                {
                    // Press 2 to Show the first 3 Trainee Id using Take
                    var firstThreeTraineeIDs = trainees.Take(3).Select(t => t.TraineeId);
                    System.Console.WriteLine("First Three Trainee IDs: " + string.Join(",", firstThreeTraineeIDs));
                    break;
                }
                case 3:
                {
                    // Press 3 to show the last 2 Trainee Id using Skip
                    var lastTwoTraineeIDs = trainees.Skip(Math.Max(0, trainees.Count - 2)).Select(t => t.TraineeId);
                    System.Console.WriteLine("Last Two Trainee IDs: " + string.Join(",", lastTwoTraineeIDs));
                    break;
                }
                case 4:
                {
                    // Press 4 to show the count of Trainee
                    var traineeCount = trainees.Count;
                    System.Console.WriteLine("No of Trainees: " + traineeCount);
                    break;
                }
                case 5:
                {
                    // Press 5 to show the Trainee Name who are all passed out 2019 or later
                    var traineePassedOut=trainees.Where(t=>t.YearPassedOut>=2019).Select(t=>t.TraineeName);
                    System.Console.WriteLine("Trainee Passed Out 2019 or later: "+string.Join(",",traineePassedOut));
                    break;
                }
                case 6:
                {
                    // Press 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee's name.
                    var sortByName=trainees.OrderBy(t=>t.TraineeName).Select(t=>new {t.TraineeId,t.TraineeName});
                    System.Console.WriteLine("Trainee sorted by name");
                    foreach(var trainee in sortByName)
                    {
                        System.Console.WriteLine($"{trainee.TraineeId} - {trainee.TraineeName}");
                    }
                    break;
                }
                case 7:
                {
                    // Press 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 marks
                    var highScoringTrainees=trainees.SelectMany(t=>t.ScoreDetails.Where(s=>s.Mark>=4), (t,s)=>new{t.TraineeId,t.TraineeName,s.TopicName,s.ExerciseName,s.Mark});
                    System.Console.WriteLine("Trainee sorted by name");
                    foreach(var trainee in highScoringTrainees)
                    {
                        System.Console.WriteLine($"{trainee.TraineeId} - {trainee.TraineeName} - {trainee.TopicName} - {trainee.ExerciseName} - {trainee.Mark}");
                    }
                    break;
                }
                case 8:
                {            
                    // Press 8 to show the unique passed out year using distinct
                    var uniquePassedOutYears=trainees.Select(t=>t.YearPassedOut).Distinct();
                    System.Console.WriteLine("Unique passed-out years: "+string.Join(",",uniquePassedOutYears));
                    break;
                }
                case 9:
                {            
                    // Press 9 to show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message
                    System.Console.WriteLine("Enter ID to show total marks:");
                    string traineeID=Console.ReadLine().ToUpper();
                    var trainee=trainees.FirstOrDefault(t=>t.TraineeId==traineeID);
                    if(traineeID!=null)
                    {
                        var totalMarks=trainee.ScoreDetails.Sum(s=>s.Mark);
                        System.Console.WriteLine($"Total marks for Trainee {traineeID}: {totalMarks}");
                    }
                    else{ System.Console.WriteLine("Invalid ID");}
                    break;
                }
                case 10:
                {            
                    // Press 10 to show the first Trainee Id and Trainee Name
                    var firstTainee=trainees.FirstOrDefault();
                    if(firstTainee!=null)
                    {
                        System.Console.WriteLine($"1st Trinee: {firstTainee.TraineeId} - {firstTainee.TraineeName}");
                    }
                    break;
                }
                case 11:
                {            
                    // Press 11 to show the last Trainee Id and Trainee Name
                    var lastTainee=trainees.LastOrDefault();
                    if(lastTainee!=null)
                    {
                        System.Console.WriteLine($"1st Trinee: {lastTainee.TraineeId} - {lastTainee.TraineeName}");
                    }
                    break;
                }
                case 12:
                {            
                    // Press 12 to print the total score of each trainee
                    var traineeTotalScores=trainees.Select(t=> new{
                        t.TraineeId,
                        t.TraineeName,
                        TotalScore=t.ScoreDetails.Sum(s=>s.Mark)
                    });
                    System.Console.WriteLine("Total scores of each trainee");
                    foreach(var trainee in traineeTotalScores)
                    {
                        System.Console.WriteLine($"{trainee.TraineeId} - {trainee.TraineeName} - Total score :{trainee.TotalScore}");
                    }
                    break;
                }
                case 13:
                {
                    // Press 13 to show the maximum total score
                    var maxTotalScore = trainees.Max(t => t.ScoreDetails.Sum(s => s.Mark));
                    System.Console.WriteLine("Maximum Total score: "+ maxTotalScore);
                    break;
                }
                case 14:
                {            
                    // Press 14 to show the minimum total score
                    var minTotalScore = trainees.Min(t => t.ScoreDetails.Sum(s => s.Mark));
                    System.Console.WriteLine("Minimum Total score: "+ minTotalScore);
                    break;
                }
                case 15:
                {
                    // Press 15 to show the average of total score
                    var averageTotalScore = trainees.Average(t => t.ScoreDetails.Sum(s => s.Mark));
                    System.Console.WriteLine("Average Total score: "+ averageTotalScore);
                    break;
                }
                case 16:
                {            
                    // Press 16 to show true or false if anyone has the more than 40 score using any ()
                    bool anyHasMoreThan40=trainees.Any(t=>t.ScoreDetails.Sum(s=>s.Mark)>40);
                    System.Console.WriteLine("Any trainee has more than 40 score: "+anyHasMoreThan40);
                    break;
                }
                case 17:
                {            
                    // Press 17 to show true of false if all of them has the more than 20 using all ()
                    bool anyHaveMoreThan20=trainees.All(t=>t.ScoreDetails.Sum(s=>s.Mark)>20);
                    System.Console.WriteLine("Any trainee has more than 20 score: "+anyHaveMoreThan20);
                    break;
                }
                case 18:
                {            
                    // Press 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by showing the Trainee Name as descending order and then show the Mark as descending order.
                    var sortedByNameAndMarks=trainees
                    .SelectMany(t=>t.ScoreDetails,(t,s)=>new{t.TraineeId,t.TraineeName,s.TopicName,s.ExerciseName,s.Mark})
                    .OrderByDescending(t=>t.TraineeName)
                    .ThenByDescending(t=>t.Mark);
                    System.Console.WriteLine("Trainees sorted by name descending and marks descending:");
                    foreach(var trainee in sortedByNameAndMarks)
                    {
                        System.Console.WriteLine($"{trainee.TraineeId} - {trainee.TraineeName} - {trainee.TopicName} - {trainee.ExerciseName} - {trainee.Mark}");
                    }
                    break;
                }
                case 19:
                {
                    // exit
                    return;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Input.");
                    break;
                }
            }
        }
    }
}

