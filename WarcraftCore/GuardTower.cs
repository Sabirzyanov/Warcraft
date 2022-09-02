namespace WarcraftCore;

public class GuardTower : Unit
{
    protected int range;
    protected int damage;
    protected double attackSpeed;

    public GuardTower(int health, int maxHealth, string name, int cost, 
        int level, int range, int damage, double attackSpeed) : 
        base(health, maxHealth, name, cost, level)
    {
        this.range = range;
        this.damage = damage;
        this.attackSpeed = attackSpeed;
    }

    public void Attack(Unit target)
    {
        if (isDestroyed || target.IsDestroyed())
            return;
        
        target.GetHit(damage);
    }
}