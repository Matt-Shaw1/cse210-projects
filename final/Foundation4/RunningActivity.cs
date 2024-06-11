public class RunningActivity : Activity
{
    private double DistanceInMiles;

    public RunningActivity(string date, int lengthInMinutes, double distanceInMiles)
        : base(date, lengthInMinutes)
    {
        DistanceInMiles = distanceInMiles;
    }

    public override double GetDistance() => DistanceInMiles;
    public override double GetSpeed() => DistanceInMiles / (LengthInMinutes / 60.0);
    public override double GetPace() => LengthInMinutes / DistanceInMiles;
}
