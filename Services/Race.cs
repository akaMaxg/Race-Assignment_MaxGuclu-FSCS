using Race_Assignment_MaxGuclu_FSCS.Models;
using Race_Assignment_MaxGuclu_FSCS.Utilities;
using System.Diagnostics;

namespace Race_Assignment_MaxGuclu_FSCS.Services
{
    public class Race
    {
        public async static Task RunRace(Car[] cars, Event[] events, Track track) //Main logic code for race
        {
            Race.PreRace(cars, events, track);//Introduction + Countdown
            {
                List<Task> tasks = new List<Task>(); //Creates a list of tasks that should all be awaited before the program finishes

                for (int i = 0; i < cars.Length; i++)
                {
                    int y = i; 
                    Task task = Task.Run(() => Race.Racer(cars[y], events, track)); //Runs the main-race function Service->Race->Racer for all participants
                    tasks.Add(task);
                }

                while (track.Position.Count == 0) // Key to post status update as long as noone has finished
                {
                    Console.ReadKey();
                    for (int i = 0; i < cars.Length; i++)
                    {
                        int z = i;
                        Task statusPost = Task.Run(() => Helper.PrintStatus(cars[z])); // Calls a print status functions 
                    }
                }
                await Task.WhenAll(tasks); //Waits for each car object to finish their race
                Console.WriteLine("With that, the race has finished, thank you for participating!");
            }
        }
        public async static Task PreRace(Car[] contenders, Event[] events, Track tracks) //Introduction + Countdown function
        {
            Console.WriteLine("Welcome to this beautiful track of Bertas Backe, where we host an annual race!\n\nThese are todays contestans:");
            foreach (var car in contenders)
            {
                Console.WriteLine($"> {car.Name}");
            }
            await WaitingFunctions.CountDown(3);
        }
        public async static Task Racer(Car contender, Event[] events, Track track) // Race code
        {

            double distanceSecondsPerEvent = 30; //Threshold for event
            Random randomGenerator = new Random();

            Stopwatch stopwatch = Stopwatch.StartNew(); //Start timer


            while (contender.distanceTraveled < track.Length) // Has the car exceeded the length of the track?
            {
                double elapsedSeconds = stopwatch.Elapsed.TotalSeconds; //Updates current timer-standing

                if (elapsedSeconds % 30 == 0) //Check if 30s has passed, triggers an event
                {
                    int eventGenerator = new Random().Next(1, 101);
                    switch (eventGenerator)
                    {
                        case int n when (n >= 1 && n <= 2): //Between 1-2, a 2% chance, events[0] effects kicks in, which a temporary speedreduction of 33,3m/s, i.e. 0 progress.
                            contender.distanceTraveled = contender.distanceTraveled + ((contender.Speed + events[0].Effect) * distanceSecondsPerEvent); //
                            contender.Incidents.Add(events[0].Type); //Adds it to a log for tracking
                            Console.WriteLine($"{contender.Name} goes into a pitstop for refueling!");
                            break;
                        case int n when (n >= 3 && n <= 6): // 4% chance for flat tire, reduced speed by 22,2m/s
                            contender.distanceTraveled = contender.distanceTraveled + ((contender.Speed + events[1].Effect) * distanceSecondsPerEvent);
                            contender.Incidents.Add(events[1].Type);
                            Console.WriteLine($"{contender.Name} has flat tire!");
                            break;
                        case int n when (n >= 7 && n <= 16): //Similar set up
                            contender.distanceTraveled = contender.distanceTraveled + ((contender.Speed + events[2].Effect) * distanceSecondsPerEvent);
                            contender.Incidents.Add(events[2].Type);
                            Console.WriteLine($"{contender.Name} slows down to wipe bugs off their windshield!");
                            break;
                        case int n when (n >= 17 && n <= 36): //20% chance for engine problems
                            contender.Speed = contender.Speed + events[3].Effect; //First permanantly decreases speed by 1 km/h,  -0.277 m/s, then proceeds.
                            contender.distanceTraveled = contender.distanceTraveled + (contender.Speed * distanceSecondsPerEvent);
                            contender.Incidents.Add(events[3].Type);
                            Console.WriteLine($"{contender.Name}'s engine starts puttering!");
                            break;
                        case int n when (n >= 37 && n <= 100): // Smooth sailing
                            contender.distanceTraveled = contender.distanceTraveled + (contender.Speed * distanceSecondsPerEvent);
                            contender.Incidents.Add(events[4].Type);
                            break;
                        default: // I dont want this plz
                            Console.WriteLine("Unknown error ");
                            break;
                    }
                }
                    if (elapsedSeconds % 1 == 0) //Updates cars current position every second
                    {
                        contender.distanceTraveled = contender.distanceTraveled + (contender.Speed * 1);
                    }
            }
            if (track.Position.Count == 0) //After the while loop, if no other cars has added entry to track position, add car and pronounce winner
            {
                track.Position.Add(contender.Name);
                Console.WriteLine($"{contender.Name} comes in first place!");
            }
            else if (contender.distanceTraveled > track.Length) //Else just add the car to the list
            {
                track.Position.Add(contender.Name);
                Console.WriteLine($"{contender.Name} crosses the finish line!");
            }
        }
    }
}
