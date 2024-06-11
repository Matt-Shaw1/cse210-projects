public class SwimmingActivity : Activity
{
    private int NumberOfLaps;
    private const double LapLengthMeters = 50; 
    private const double MetersToMiles = 0.000621371; 

    public SwimmingActivity(string date, int lengthInMinutes, int numberOfLaps)
        : base(date, lengthInMinutes)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return NumberOfLaps * LapLengthMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        double distanceMiles = GetDistance();
        return distanceMiles / (LengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        double distanceMiles = GetDistance();
        return distanceMiles > 0 ? LengthInMinutes / distanceMiles : double.MaxValue;
    }
}
