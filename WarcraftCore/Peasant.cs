namespace WarcraftCore;

public class Peasant : Moveable
{
    public Peasant(int health, int maxHealth, string name, int cost, int level, int moveSpeed) : 
        base(health, maxHealth, name, cost, level, moveSpeed)
    {
    }

    public void Mine() { }

    public void Chop() { }
    

    public override void Move()
    {
        throw new NotImplementedException();
    }
}