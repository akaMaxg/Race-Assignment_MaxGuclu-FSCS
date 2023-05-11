using Race_Assignment_MaxGuclu_FSCS.Models;

namespace Race_Assignment_MaxGuclu_FSCS.Utilities
{
    //Functions to help run the program
    public class Helper
    {
        public static Event[] EventCreation() //Creates 5 Event-objects with 2 arguments for Type, effect in m/s

        {
            Event[] events = new Event[]
            {
            //Effect is converted into m/seconds, i.e. a stop for 30s equals a reduction of 999,9 meters during that slot of time
            new Event("Low gas", -33.3),
            new Event("Flat-tire", -22.2),
            new Event("Bugs on windshield", -11.1),
            new Event("Engine problem", -0.277), // if engine problems, speed property of vehicle changes.
            new Event("Smooth sailing", 0)
            };
            return events;
        }
        public static Car[] CarCreation() //Method that instansiates the array of cars
        {
            Car[] cars = new Car[]
            {
            //Creates 3 car-objects with 2 arguments for Name, and Speed (could have hardcoded speed in constructor, but for scaleability
            //Speed is converted to m/s
            new Car("Snabba Sixten", 33.3),
            new Car("Ettriga Einar", 33.3),
            new Car("Brännarn Bettan", 33.3)
            };
            return cars;
        }

        public static Track TrackCreation() //Creates (10km in m) track

        {
            Track tracks = new Track(10000);
            return tracks;
        }

        public static async Task PrintStatus(Car car) //A method that takes a Car-object and prints the name and current distance
        {
            Console.WriteLine($"-----------{car.Name} has traveled {Math.Round(car.distanceTraveled, 2)}m with current speed of {Math.Round(car.Speed, 0)* 3.6} ---------");
        }
    }

    //Functions related to time
    public class WaitingFunctions
    {
        public async static Task CountDown(int i) //Functions, takes an int for number of seconds in the countdown
        {
            Console.WriteLine("\nDrivers, start your engines!");
            Console.WriteLine("~~ Engines revving ~~");
            i = 0;
            while (i >= 1)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
                Console.WriteLine($"{i}...");
                i--;
            }
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("==== GO! ====");
            Console.WriteLine("~~ The cars set off ~~");
            Console.WriteLine("\n-- Press any key to see the current standing of the contenders. --");


        }
        public async static Task Seconds(int sec)//Functions, takes an int for number of seconds to wait
        {
            await Task.Delay(TimeSpan.FromSeconds(sec));
        }
    }

}

