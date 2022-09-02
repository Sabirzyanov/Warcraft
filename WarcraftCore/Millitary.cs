namespace WarcraftCore;

public abstract class Millitary : Moveable
{
    protected int damage;
    protected int attackSpeed;
    protected int armor;

    protected Millitary(int health, string name, int cost, int level, int moveSpeed, 
        int damage, int attackSpeed, int armor) : base(health, name, cost, level, moveSpeed)
    {
        this.damage = damage;
        this.attackSpeed = attackSpeed;
        this.armor = armor;
    }

    public virtual void Attack(Unit target)
    {
        if (isDestroyed || target.IsDestroyed() || stunned)
            return;
        target.GetHit(damage);
    }

    public override void GetHit(int damage)
    {
        // Formula for calculating damage taking into account armor
        base.GetHit(damage - armor / 2);
    }


    public int GetAttackSpeed()
    {
        return attackSpeed;
    }
}