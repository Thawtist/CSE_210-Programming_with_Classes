
class Circle
{
    public double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        // Math.Pow(_radius, 2);
        return Math.PI * _radius * _radius;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }
}