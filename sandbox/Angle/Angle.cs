class Angle
{
    private double _radians;

    public Angle()
    {
        _radians = 0.0;
    }

    public Angle(double radians)
    {
        _radians = radians;
    }

    public Angle(int degrees)
    {
        _radians = ToRadians(degrees);
    }



    public double GetRadians()
    {
        return _radians;
    }

    public double GetDegrees()
    {
        return ToDegrees();
    }


    public void SetDegrees(double degrees)
    {
        _radians = ToRadians(degrees);
    }
    private double ToDegrees()
    {
        return _radians / Math.PI * 180;
    }
    private double ToRadians(double degrees)
    {
        return degrees / 180 * Math.PI;
    }
}