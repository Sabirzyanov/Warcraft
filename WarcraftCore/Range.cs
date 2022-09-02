namespace WarcraftCore;


/// <summary>
/// 
/// </summary>
public abstract class Range : Millitary
{
    protected int range;
    protected int mana;

    protected Range(int health, string name, int cost, int level, int moveSpeed, 
        int damage, int attackSpeed, int armor, int range, int mana) : 
        base(health, name, cost, level, moveSpeed, damage, attackSpeed, armor)
    {
        this.range = range;
        this.mana = mana;
    }
}