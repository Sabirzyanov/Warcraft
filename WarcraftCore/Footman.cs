namespace WarcraftCore;

public class Footman : Millitary
{
    public Footman(int health, int maxHealth, string name, int cost, int level, int moveSpeed, int damage, 
        int attackSpeed, int armor) : base(health, maxHealth, name, cost, level, moveSpeed, damage, attackSpeed, armor)
    {
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
    
    public void Berserker()
    {
        
    }

    public void Stun(Unit target)
    {
        if (isDestroyed || target.IsDestroyed())
            return;
    }
}