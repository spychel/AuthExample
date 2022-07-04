namespace AuthExample.Data
{
    public class Option
    {
        public int SelectedTg { get; set; } = 4;
        public DateTime BeginTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; } = DateTime.Now;
        public Variant Variant { get; set; } = Variant.Start;

    }

    public enum Variant
    {
        Stop,
        Start
    };
}