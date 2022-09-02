namespace WarcraftCore;

public abstract class Range : Millitary
{
    protected int range;
    protected int mana;

    protected Range(int health, int maxHealth, string name, int cost, int level, int moveSpeed, 
        int damage, int attackSpeed, int armor, int range, int mana) : 
        base(health, maxHealth, name, cost, level, moveSpeed, damage, attackSpeed, armor)
    {
        this.range = range;
        this.mana = mana;
    }
}