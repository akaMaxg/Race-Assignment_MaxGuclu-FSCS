using Race_Assignment_MaxGuclu_FSCS.Models;
using Race_Assignment_MaxGuclu_FSCS.Services;
using Race_Assignment_MaxGuclu_FSCS.Utilities;
using Spectre.Console;
using System.Security.Cryptography.X509Certificates;

namespace Race_Assignment_MaxGuclu_FSCS
{


    internal class Program
    {
        static async Task Main(string[] args)
        {
            await WaitingFunctions.CountDown();
            UI.TableGenerator(Helper.TrackCreation(), Helper.CarCreation(), Helper.EventCreation());

            Task.Run(async () => await Race.RunRace()).Wait();
            Console.ReadLine();

        }
    }
}