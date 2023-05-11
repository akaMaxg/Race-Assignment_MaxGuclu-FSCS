namespace Race_Assignment_MaxGuclu_FSCS.Models
{
    public class Event //Events object
    {
        public string Type { get; set; }
        public double Effect { get; set; }
        public Event(string type, double effect)  //Constructor
        {
            this.Type = type;
            this.Effect = effect;
        }
    }
}
