using Race_Assignment_MaxGuclu_FSCS.Models;
using Race_Assignment_MaxGuclu_FSCS.Services;
using Race_Assignment_MaxGuclu_FSCS.Utilities;

namespace Race_Assignment_MaxGuclu_FSCS
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Race.RaceIntroduction(Helper.TrackCreation(), Helper.CarCreation());
            Race.RacerOne(Helper.TrackCreation(), Helper.CarCreation(), Helper.EventCreation());
            Race.RacerTwo(Helper.TrackCreation(), Helper.CarCreation(), Helper.EventCreation());

            Console.WriteLine("Is it running?___");
            Console.ReadKey();
        }
    }
}