namespace WarcraftCore;

public class Mage : Range
{
    private const int HEAL_MANA_COST = 6;
    
    private const int FIREBALL_DAMAGE = 3;
    private const int FIREBALL_MANA_COST = 15;
    
    private const int BLIZZARD_DAMAGE = 2;
    private const int BLIZZARD_MANA_COST = 10;
    
    public Mage(int health, int maxHealth, string name, int cost, int level, 
        int moveSpeed, int damage, int attackSpeed, int armor, int range, int mana) : 
        base(health, maxHealth, name, cost, level, moveSpeed, damage, attackSpeed, armor, range, mana)
    {
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public void FireBall(Unit target)
    {
        if (isDestroyed || target.IsDestroyed())
            return;
        
        target.GetHit(FIREBALL_DAMAGE);
        mana -= FIREBALL_MANA_COST;
    }

    public void Blizzard(Unit target)
    {
        if (isDestroyed || target.IsDestroyed())
            return;
        
        target.GetHit(BLIZZARD_DAMAGE);
        mana -= BLIZZARD_MANA_COST;
    }
    
    public void Heal(Unit target, int healPoint)
    {
        if (mana >= HEAL_MANA_COST && !isDestroyed)
        {
            target.SetHealthPoint(healPoint);
            mana -= HEAL_MANA_COST * healPoint;
        }
    }
}