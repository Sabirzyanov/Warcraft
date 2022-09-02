namespace WarcraftCore;

public class Dragon : Range
{
    private const int FIRE_BREATH_MULTIPLIER = 5;
    private const int FIRE_BREATH_MANA_COST = 50;
    public Dragon(int health, string name, int cost, int level, int moveSpeed, 
        int damage, int attackSpeed, int armor, int range, int mana) : 
        base(health, name, cost, level, moveSpeed, damage, attackSpeed, armor, range, mana)
    {
    }

    public void FireBreath(Unit target)
    {
        target.GetHit(FIRE_BREATH_MULTIPLIER * damage);
        mana -= FIRE_BREATH_MANA_COST;
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}