using System;

public class WalkAction: CreatureAction
{
    public WalkAction(double left, double top)
    {
        setDoubleAttribute("left", left);
        setDoubleAttribute("top", top);
    }

    public double getLeft()
    {
        return getDoubleAttribute("left");
    }

    public double getTop()
    {
        return getDoubleAttribute("top");
    }
}
