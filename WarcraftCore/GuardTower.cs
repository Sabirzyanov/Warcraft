namespace WarcraftCore;

public class GuardTower : Unit
{
    protected int range;
    protected int damage;
    protected int attackSpeed;

    public GuardTower(int health, string name, int cost, 
        int level, int range, int damage, int attackSpeed) : 
        base(health, name, cost, level)
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
    
    public int GetAttackSpeed()
    {
        return attackSpeed;
    }
}