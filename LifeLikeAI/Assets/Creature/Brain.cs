using System;
public class Brain
{
    Random random = new Random();

    public Brain()
    {
    }

    public CreatureAction getNextAction()
    {
        double left = random.Next(-1, 2) / 10.0;
        double top = random.Next(-1, 2) / 10.0;
        return new WalkAction(left, top);
    }
}
