using Race_Assignment_MaxGuclu_FSCS.Models;

namespace Race_Assignment_MaxGuclu_FSCS.Utilities
{
    public class Helper
    {
        public static void LoadSetting()
        {
            Track[] track = Helper.TrackCreation();
            Car[] contenders = Helper.CarCreation();
            Event[] events = Helper.EventCreation();
        }
        public static Event[] EventCreation()
        {
            Event[] events = new Event[] //An array of objects, 
            {
            //Creates 5 Event-objects with 3 arguments for Type, effect and probability
            //Effect is converted into m/seconds, i.e. a stop for 30s equals a reduction of 999,9 meters during that slot of time
            //0.02 equals 2% probability, or 1/50
            new Event("Low gas", 0, 0.02),
            new Event("Flat-tire", 333.333, 0.04),
            new Event("Bugs on windshield", 666.666, 0.1),
            new Event("Engine problem", 991.6670, 0.2), // if engine problems, speed property of vehicle changes. A distance of 10
            new Event("Smooth sailing", 1000, 0.64)
            };
            return events;
        }
        public static Car[] CarCreation()
        {

            Car[] cars = new Car[] //An array of objects, 
            {
            //Creates 3 car-objects with 3 arguments for Type, effect and probability
            //Effect is converted into m/seconds, i.e. a stop for 30s equals a reduction of 999,9 meters during that slot of time
            //0.02 equals 2% probability, or 1/50
            new Car("Snabba Sixten", "Red", 1000),
            new Car("Hala Hasse", "Black", 1000),
            new Car("Ettriga Einar","Yellow", 1000),
            new Car("Brännarn Bettan", "White", 1000) // if engine problems, speed property of vehicle changes. A distance of 10
            };
            return cars;

        }
        public static Track[] TrackCreation()
        {
            Track[] tracks = new Track[] //An array of objects, 
            {
            //Creates 3 car-objects with 3 arguments for Type, effect and probability
            //Effect is converted into m/seconds, i.e. a stop for 30s equals a reduction of 999,9 meters during that slot of time
            //0.02 equals 2% probability, or 1/50
            new Track("First slot", 10000),
            new Track("Second slot",10000),
            new Track("Third slot",10000),
            new Track("Fourth slot",10000)
            };
            return tracks;
        }
    }

}