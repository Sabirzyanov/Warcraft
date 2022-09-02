namespace WarcraftCore;

public class Mage : Range
{
    private const int HEAL_MANA_COST = 6;
    
    private const int FIREBALL_DAMAGE_MULTIPLIER = 3;
    private const int FIREBALL_MANA_COST = 15;
    
    private const int BLIZZARD_DAMAGE_MULTIPLIER = 2;
    private const int BLIZZARD_MANA_COST = 10;

    private Random rand = new Random();
    
    public Mage(int health, string name, int cost, int level, 
        int moveSpeed, int damage, int attackSpeed, int armor, int range, int mana) : 
        base(health, name, cost, level, moveSpeed, damage, attackSpeed, armor, range, mana)
    {
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public override void Attack(Unit target)
    {
        // 1 - FireBall
        // 2 - Blizzard
        // 3 - Base attack
        int attackType = rand.Next(1, 5);
        int healPoint = rand.Next(10, 20);
        switch (attackType)
        {
            case 1:
                FireBall(target);
                break;
            case 2:
                Blizzard(target);
                break;
            case 3:
                base.Attack(target);
                break;
            case 4:
                Heal(healPoint);
                break;
        }
        base.Attack(target);
    }

    public void FireBall(Unit target)
    {
        if (isDestroyed || target.IsDestroyed())
            return;
        
        target.GetHit(FIREBALL_DAMAGE_MULTIPLIER * damage);
        mana -= FIREBALL_MANA_COST;
    }

    public void Blizzard(Unit target)
    {
        if (isDestroyed || target.IsDestroyed())
            return;
        
        target.GetHit(BLIZZARD_DAMAGE_MULTIPLIER * damage);
        mana -= BLIZZARD_MANA_COST;
    }
    
    public void Heal(int healPoint)
    {
        if (mana >= HEAL_MANA_COST && !isDestroyed)
        {
            this.SetHealthPoint(healPoint);
            mana -= HEAL_MANA_COST * healPoint;
        }
    }
}