using Race_Assignment_MaxGuclu_FSCS.Models;
using Race_Assignment_MaxGuclu_FSCS.Utilities;

namespace Race_Assignment_MaxGuclu_FSCS.Services
{
    public class Race
    {
        public async static Task RunRace()
        {
            Race.RaceIntroduction(Helper.TrackCreation(), Helper.CarCreation());
            Task.Run(async () => await Race.RacerOne(Helper.TrackCreation(), Helper.CarCreation(), Helper.EventCreation())).Wait();
        }


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
        public async static Task RacerOne(Track[] track, Car[] contenders, Event[] events)
        {
            Input.AwaitKeyInput(contenders, track);
            Console.Write(contenders[0].Name + " Sets off!...\n");
            while (track[0].Length > 1)
            {
                int eventGenerator = new Random().Next(1, 101);
                switch (eventGenerator)
                {
                    case int n when (n >= 1 && n <= 2):
                        track[0].Length = track[0].Length - events[0].Effect;
                        Console.Write("RF!(-30s)... ");
                        break;
                    case int n when (n >= 3 && n <= 6):
                        track[0].Length = track[0].Length - events[1].Effect;
                        Console.Write("FT!(-20s)... ");
                        break;
                    case int n when (n >= 7 && n <= 16):
                        track[0].Length = track[0].Length - events[2].Effect;
                        Console.Write("B!(-10s)... ");
                        break;
                    case int n when (n >= 17 && n <= 26):
                        track[0].Length = track[0].Length - events[3].Effect;
                        contenders[0].Speed = contenders[0].Speed - events[4].Effect;
                        Console.Write("EP!(-1km/h)... ");
                        break;
                    case int n when (n >= 27 && n <= 100):
                        track[0].Length = track[0].Length - contenders[0].Speed;
                        break;
                    default:
                        Console.WriteLine("Unknown error ");
                        break;
                }
                Console.Write(Math.Round((track[0].Length / 1000), 2) + " KM left!... ");
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
        public async static void RacerThree(Track[] track, Car[] contenders, Event[] events)
        {

            while (track[2].Length > 1)
            {
                int eventGenerator = new Random().Next(1, 101);
                switch (eventGenerator)
                {
                    case int n when (n >= 1 && n <= 2):
                        Console.WriteLine(events[0].Type);
                        track[2].Length = track[2].Length - events[0].Effect;
                        Console.WriteLine(contenders[2].Name + " appears to need refueling!");
                        break;
                    case int n when (n >= 3 && n <= 6):
                        Console.WriteLine(events[1].Type);
                        track[2].Length = track[2].Length - events[1].Effect;
                        Console.WriteLine(contenders[2].Name + "'s tire goes flat!");
                        break;
                    case int n when (n >= 7 && n <= 16):
                        Console.WriteLine(events[2].Type);
                        track[2].Length = track[2].Length - events[2].Effect;
                        Console.WriteLine(contenders[2].Name + " needs to get their windshield cleaned, full of bugs!");
                        break;
                    case int n when (n >= 17 && n <= 26):
                        Console.WriteLine(events[3].Type);
                        track[2].Length = track[2].Length - events[3].Effect;
                        contenders[1].Speed = contenders[2].Speed - events[4].Effect;
                        Console.WriteLine(contenders[2].Name + "'s vehicle is sputtering, engine problem?!");
                        break;
                    case int n when (n >= 27 && n <= 100):
                        Console.WriteLine(events[4].Type);
                        track[2].Length = track[2].Length - contenders[2].Speed;
                        Console.WriteLine(contenders[2].Name + " is soaring onwards!");
                        break;
                    default:
                        Console.WriteLine("Unknown error");
                        break;
                }
                Console.WriteLine(contenders[2].Name + " has about... " + Math.Round((track[2].Length / 1000), 2) + " KM to go!");
                await WaitingFunctions.oneRound();
            }
            Console.WriteLine(contenders[2].Name + " FINISHES!!");
        }
        public async static void RacerFour(Track[] track, Car[] contenders, Event[] events)
        {

            while (track[2].Length > 1)
            {
                int eventGenerator = new Random().Next(1, 101);
                switch (eventGenerator)
                {
                    case int n when (n >= 1 && n <= 2):
                        Console.WriteLine(events[0].Type);
                        track[3].Length = track[3].Length - events[0].Effect;
                        Console.WriteLine(contenders[3].Name + " appears to need refueling!");
                        break;
                    case int n when (n >= 3 && n <= 6):
                        Console.WriteLine(events[1].Type);
                        track[3].Length = track[3].Length - events[1].Effect;
                        Console.WriteLine(contenders[3].Name + "'s tire goes flat!");
                        break;
                    case int n when (n >= 7 && n <= 16):
                        Console.WriteLine(events[3].Type);
                        track[3].Length = track[3].Length - events[2].Effect;
                        Console.WriteLine(contenders[3].Name + " needs to get their windshield cleaned, full of bugs!");
                        break;
                    case int n when (n >= 17 && n <= 26):
                        Console.WriteLine(events[3].Type);
                        track[3].Length = track[3].Length - events[3].Effect;
                        contenders[3].Speed = contenders[3].Speed - events[4].Effect;
                        Console.WriteLine(contenders[3].Name + "'s vehicle is sputtering, engine problem?!");
                        break;
                    case int n when (n >= 27 && n <= 100):
                        Console.WriteLine(events[4].Type);
                        track[3].Length = track[3].Length - contenders[2].Speed;
                        Console.WriteLine(contenders[3].Name + " is soaring onwards!");
                        break;
                    default:
                        Console.WriteLine("Unknown error");
                        break;
                }
                Console.WriteLine(contenders[3].Name + " has about... " + Math.Round((track[3].Length / 1000), 2) + " KM to go!");
                await WaitingFunctions.oneRound();
            }
            Console.WriteLine(contenders[3].Name + " FINISHES!!");
        }
    }
}
