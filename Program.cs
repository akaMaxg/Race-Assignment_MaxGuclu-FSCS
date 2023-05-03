using Race_Assignment_MaxGuclu_FSCS.Models;
using Race_Assignment_MaxGuclu_FSCS.Services;
using Race_Assignment_MaxGuclu_FSCS.Utilities;

namespace Race_Assignment_MaxGuclu_FSCS
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () => await Race.RunRace()).Wait();
            Console.ReadLine();

        }
    }
}