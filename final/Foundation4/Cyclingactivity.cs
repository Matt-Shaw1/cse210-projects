public class CyclingActivity : Activity
{
    private double SpeedInMph;

    public CyclingActivity(string date, int lengthInMinutes, double speedInMph)
        : base(date, lengthInMinutes)
    {
        SpeedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        return SpeedInMph * (LengthInMinutes / 60.0); 
    }

    public override double GetSpeed()
    {
        return SpeedInMph;
    }

    public override double GetPace()
    {
        return 60.0 / SpeedInMph; 
    }
}
