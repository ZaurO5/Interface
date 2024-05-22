public class TrafficLight
{
    private Color currentColor;

    public TrafficLight(Color initialColor)
    {
        currentColor = initialColor;
    }

    public Color CurrentColor
    {
        get { return currentColor; }
    }
    public void ChangeNextColor()
    {
        switch (currentColor)
        {
            case Color.Red:
                currentColor = Color.Green;
                break;
            case Color.Yellow:
                currentColor = Color.Red;
                break;
            case Color.Green:
                currentColor = Color.Yellow;
                break;
            default:
                throw new InvalidOperationException("Invalid traffic light color.");
        }
    }
}