namespace Race_Assignment_MaxGuclu_FSCS.Models
{
    public class Track //Track object
    {
        public double Length { get; set; } //Using double for precision
        public List<string> Position { get; set; }

        public Track(double length)  //Constructor
        {
            this.Length = length;
            Position = new List<string>();

        }

    }
}
