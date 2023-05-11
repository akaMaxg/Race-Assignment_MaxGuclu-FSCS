namespace Race_Assignment_MaxGuclu_FSCS.Models
{
    public class Car //car object 
    {
        public double Speed { get; set; }
        public double distanceTraveled { get; set; }
        public string Name { get; set; }
        public List<string> Incidents { get; set; }
        public Car(string name, double speed) //Constructor
        {
            this.Name = name;
            this.Speed = speed;
            distanceTraveled = 0;
            Incidents = new List<string>();
        }
    }
}
