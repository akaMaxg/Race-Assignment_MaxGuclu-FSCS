using Race_Assignment_MaxGuclu_FSCS.Models;
using Race_Assignment_MaxGuclu_FSCS.Utilities;

namespace Race_Assignment_MaxGuclu_FSCS.Services
{
    public class Race
    {
        public static void RaceIntroduction (Track[] track, Car[] contenders)
            {
            Console.WriteLine("Welcome to this beautiful track of Bertas Backe, where we host an annual race");

            Console.WriteLine("\nLadies and gentlemen... The track length is meters and the drivers are approaching! ");

            foreach (var item in contenders)
            {
                Console.WriteLine(item.Name + "\n");
            }
            Console.WriteLine("...and off they go!");
        }
        public async static void RacerOne(Track[] track, Car[] contenders, Event[] events)
        {

            while (track[0].Length > 1)
            {
                int eventGenerator = new Random().Next(1, 101);
                Console.WriteLine("\n");
                switch (eventGenerator)
                {
                    case int n when (n >= 1 && n <= 2):
                        Console.WriteLine(events[0].Type);
                        track[0].Length = track[0].Length - events[0].Effect;
                        Console.WriteLine(contenders[0].Name + " appears to need refueling!");
                        break;
                    case int n when (n >= 3 && n <= 6):
                        Console.WriteLine(events[1].Type);
                        track[0].Length = track[0].Length - events[1].Effect;
                        Console.WriteLine(contenders[0].Name + "'s tire goes flat!");
                        break;
                    case int n when (n >= 7 && n <= 16):
                        Console.WriteLine(events[2].Type);
                        track[0].Length = track[0].Length - events[2].Effect;
                        Console.WriteLine(contenders[0].Name + " needs to get their windshield cleaned, full of bugs!");
                        break;
                    case int n when (n >= 17 && n <= 26):
                        Console.WriteLine(events[3].Type);
                        track[0].Length = track[0].Length - events[3].Effect;
                        contenders[0].Speed = contenders[0].Speed - events[4].Effect;
                        Console.WriteLine(contenders[0].Name + "'s vehicle is sputtering, engine problem?!");
                        break;
                    case int n when (n >= 27 && n <= 100):
                        Console.WriteLine(events[4].Type);
                        track[0].Length = track[0].Length - contenders[0].Speed;
                        Console.WriteLine(contenders[0].Name + " is soaring onwards!");
                        break;
                    default:
                        Console.WriteLine("Unknown error");
                        break;
                }
                Console.WriteLine(contenders[0].Name + " has about... " + Math.Round((track[0].Length / 1000), 2) + " KM to go!");
                await WaitingFunctions.oneRound();
            }
            Console.WriteLine(contenders[0].Name + " FINISHES!!");
        }
        public async static void RacerTwo(Track[] track, Car[] contenders, Event[] events)
        {

            while (track[1].Length > 1)
            {
                int eventGenerator = new Random().Next(1, 101);
                switch (eventGenerator)
                {
                    case int n when (n >= 1 && n <= 2):
                        Console.WriteLine(events[0].Type);
                        track[1].Length = track[1].Length - events[0].Effect;
                        Console.WriteLine(contenders[1].Name + " appears to need refueling!");
                        break;
                    case int n when (n >= 3 && n <= 6):
                        Console.WriteLine(events[1].Type);
                        track[1].Length = track[1].Length - events[1].Effect;
                        Console.WriteLine(contenders[1].Name + "'s tire goes flat!");
                        break;
                    case int n when (n >= 7 && n <= 16):
                        Console.WriteLine(events[2].Type);
                        track[1].Length = track[1].Length - events[2].Effect;
                        Console.WriteLine(contenders[1].Name + " needs to get their windshield cleaned, full of bugs!");
                        break;
                    case int n when (n >= 17 && n <= 26):
                        Console.WriteLine(events[3].Type);
                        track[1].Length = track[1].Length - events[3].Effect;
                        contenders[1].Speed = contenders[1].Speed - events[4].Effect;
                        Console.WriteLine(contenders[1].Name + "'s vehicle is sputtering, engine problem?!");
                        break;
                    case int n when (n >= 27 && n <= 100):
                        Console.WriteLine(events[4].Type);
                        track[1].Length = track[1].Length - contenders[0].Speed;
                        Console.WriteLine(contenders[1].Name + " is soaring onwards!");
                        break;
                    default:
                        Console.WriteLine("Unknown error");
                        break;
                }
                Console.WriteLine(contenders[1].Name + " has about... " + Math.Round((track[1].Length / 1000), 2) + " KM to go!");
                await WaitingFunctions.oneRound();
            }
            Console.WriteLine(contenders[1].Name + " FINISHES!!");
        }
    }

    public class WaitingFunctions
    {
        public async static Task WaitThree()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("\n3..");
        }
        public async static Task WaitTwo()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("\n2...");
        }
        public async static Task WaitOne()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("\n1...");
        }
        public async static Task WaitGo()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("\n*Gunshot*");
        }
        public async static Task oneRound()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
        }
    }
}
