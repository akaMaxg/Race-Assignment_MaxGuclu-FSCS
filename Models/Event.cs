namespace Race_Assignment_MaxGuclu_FSCS.Models
{
    public class Event
    {
        public string Type { get; set; }
        public double Effect { get; set; }
        public Event(string type, double effect)  //Constructor that takes five parameters.
        {
            this.Type = type;
            this.Effect = effect;
        }
    }
}
