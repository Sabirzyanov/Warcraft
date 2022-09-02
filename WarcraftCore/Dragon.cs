namespace WarcraftCore;

public class Dragon : Range
{
    public Dragon(int health, int maxHealth, string name, int cost, int level, int moveSpeed, 
        int damage, int attackSpeed, int armor, int range, int mana) : 
        base(health, maxHealth, name, cost, level, moveSpeed, damage, attackSpeed, armor, range, mana)
    {
    }

    public void FireBreath()
    {
        
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}