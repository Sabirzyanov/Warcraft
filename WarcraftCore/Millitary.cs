namespace WarcraftCore;

public abstract class Millitary : Moveable
{
    protected int damage;
    protected int attackSpeed;
    protected int armor;

    protected Millitary(int health, int maxHealth, string name, int cost, int level, int moveSpeed, 
        int damage, int attackSpeed, int armor) : base(health, maxHealth, name, cost, level, moveSpeed)
    {
        this.damage = damage;
        this.attackSpeed = attackSpeed;
        this.armor = armor;
    }

    public void Attack(Unit target)
    {
        if (isDestroyed || target.IsDestroyed())
            return;
        
        // Formula for calculating damage taking into account armor
        target.GetHit(damage);
    }

    public override void GetHit(int damage)
    {
        base.GetHit(damage - armor / 2);
    }
}