namespace Race_Assignment_MaxGuclu_FSCS.Models
{
    public class Car
    {
        public string Color { get; set; }
        public double Speed { get; set; }
        public string Name { get; set; }
        public Car(string name, string color, double speed)  //Constructor that takes five parameters.
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;
        }
    }


}
