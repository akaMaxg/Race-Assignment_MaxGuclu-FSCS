namespace Race_Assignment_MaxGuclu_FSCS.Models
{
    public class Track
    {
        public string Slot { get; set; }

        public double Length { get; set; } //double because the distance will be measured in seconds

        public Track(string slot, double length)  //Constructor that takes 1 parameter
        {
            this.Slot = slot;
            this.Length = length;

        }

    }
}
