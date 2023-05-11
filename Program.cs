using Race_Assignment_MaxGuclu_FSCS.Models;
using Race_Assignment_MaxGuclu_FSCS.Services;
using Race_Assignment_MaxGuclu_FSCS.Utilities;

namespace Race_Assignment_MaxGuclu_FSCS
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, press any key to start the program.");
            Console.ReadKey();
            Console.WriteLine("Not that one... im just kidding, i wont do it again i swear - press something.\n");
            Console.ReadKey();
            //Run program
            Race.RunRace(Helper.CarCreation(), Helper.EventCreation(), Helper.TrackCreation());
        }
    }
}