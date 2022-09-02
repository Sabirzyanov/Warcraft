namespace WarcraftCore;

public abstract class Unit
{
    protected int health;
    protected int maxHealth;
    protected string name;
    protected int cost;
    protected int level;
    
    protected bool isDestroyed;

    protected Unit(int health, int maxHealth, string name, int cost, int level)
    {
        this.health = health;
        this.maxHealth = maxHealth;
        this.name = name;
        this.cost = cost;
        this.level = level;
    }

    public virtual void GetHit(int damage)
    {
        if (health > 0)
        {
            health -= damage;
        }
        else
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        isDestroyed = true;
    }

    public void SetHealthPoint(int healPoint)
    {
        if (isDestroyed)
            return;
        
        if (CanHeal(healPoint))
        {
            health += healPoint;
        }
    }

    private bool CanHeal(int healPoint)
    {
        return health + healPoint <= maxHealth;
    }

    public bool IsDestroyed()
    {
        return isDestroyed;
    }
}