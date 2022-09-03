namespace WarcraftCore;

public class Blacksmith
{
    private readonly List<Unit> unitsList;
    private ILogger logger;
    
    private const int UPGRADE_ARMOR_COUNT = 2;
    private const int UPGRADE_WEAPON_COUNT = 4;
    private const int UPGRADE_BOW_COUNT = 10;

    public Blacksmith(ILogger logger)
    {
        this.logger = logger;
    }

    public void UpgradeArmor()
    {
        foreach (Footman footman in unitsList.Select(x => x as Footman))
        {
            if (footman is null)
            {
                logger.Log("Нет пехотинцев");
                return;
            }
            
            footman.UpgradeArmor(UPGRADE_ARMOR_COUNT);
            logger.Log("Blacksmith улучшил броню всех пехотинцев");
        }
    }

    public void UpgradeWeapon()
    {
        foreach (Millitary millitary in unitsList.Select(x => x as Millitary))
        {
            if (millitary is null)
            {
                logger.Log("Нет пехотинцев");
                return;
            }
            
            // millitary.UpgradeWeapon(UPGRADE_ARMOR_COUNT);
            logger.Log("Blacksmith улучшил оружие всех персонажев");
        }
    }

    public void UpgradeBow()
    {
        foreach (Archer archer in unitsList.Select(x => x as Archer))
        {
            if (archer is null)
            {
                logger.Log("Нет пехотинцев");
                return;
            }
            
            archer.UpgradeBow(UPGRADE_BOW_COUNT);
            logger.Log("Blacksmith улучшил лук у всех лучников");
        }
    }
}