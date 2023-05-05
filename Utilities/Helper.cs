using Race_Assignment_MaxGuclu_FSCS.Models;

namespace Race_Assignment_MaxGuclu_FSCS.Utilities
{
    public class Helper
    {
        public static Event[] EventCreation()
        {
            Event[] events = new Event[] //An array of objects, 
            {
            //Creates 5 Event-objects with 2 arguments for Type, effect
            //Effect is converted into m/seconds, i.e. a stop for 30s equals a reduction of 999,9 meters during that slot of time
            new Event("Low gas", 0),
            new Event("Flat-tire", 333.333),
            new Event("Bugs on windshield", 666.666),
            new Event("Engine problem", 991.6670), // if engine problems, speed property of vehicle changes. A distance of 10
            new Event("Smooth sailing", 1000)
            };
            return events; //returns the object as a list of objects
        }
        public static Car[] CarCreation()
        {

            Car[] cars = new Car[] //An array of objects, 
            {
            //Creates 4 car-objects with 3 arguments for Name, Color and Speed
            //Speed is converted to m/30s
            new Car("Snabba Sixten", "Red", 1000),
            new Car("Hala Hasse", "Black", 1000),
            new Car("Ettriga Einar","Yellow", 1000),
            new Car("Brännarn Bettan", "White", 1000) // if engine problems, speed property of vehicle changes. A distance of 10
            };
            return cars; //returns the object as a list of objects

        }
        public static Track[] TrackCreation()
        {
            Track[] tracks = new Track[] //An array of objects, 
            {
            //Creates 4 track-objects with 2 arguments for position and length (10km in m)
            //All are running on tracks that are of equal length, but "separetely"
            new Track("First slot", 10000),
            new Track("Second slot",10000),
            new Track("Third slot",10000),
            new Track("Fourth slot",10000)
            };
            return tracks; //returns the object as a list of objects
        }
    }
    public class WaitingFunctions
    {
        public async static Task CountDown()
        {
            int i = 3;
            while (i >= 1)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                Console.WriteLine($"{i}...");
                i--;
            }
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine($"GO!");
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
    public class Input
    {
        public static async void AwaitKeyInput(Car[] contenders, Track[] tracks)
        {
            Console.WriteLine("Press any key to see current status");
            while (tracks[0].Length>1)
            { 
            await Task.Run(() => Console.ReadKey(true));
            Console.WriteLine("\n-------------------\n" + contenders[0].Name + " has traveled " + tracks[0].Length/1000 +" Km" + "\n-------------------");
            Console.WriteLine("\nKey pressed!");
            }
        }
    }
}

