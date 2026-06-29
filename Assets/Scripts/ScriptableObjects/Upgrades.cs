using UnityEngine;

[CreateAssetMenu(fileName = "Upgrades", menuName = "Scriptable Objects/Upgrades")]
public class Upgrades : ScriptableObject
{
    public enum Damage 
    { 
        Level1=10,
        Level2=20,
        Level3=40
    }
    public enum Health
    {
        Level1 = 100,
        Level2 = 150,
        Level3 = 200
    }
    public enum Boost
    {
        Level1 = 300,
        Level2 = 750,
        Level3 = 1200
    }

    public static Damage currentDamageLevel = Damage.Level1;
    public static Health currentHealthLevel = Health.Level1;
    public static Boost currentBoostLevel = Boost.Level1;

    public int upgradeLvl2Cost = 1000;
    public int upgradeLvl3Cost = 2000;

    public void SetDamageLvl1() { currentDamageLevel = Damage.Level1; }
    public void SetHealthLvl1() { currentHealthLevel = Health.Level1; }
    public void SetBoostLevel1() { currentBoostLevel = Boost.Level1; }
    public void SetDamageLvl2() {
        if (!GameManager.Instance.upgradeDamage2Unlocked)
        {
            if (GameManager.Instance.points >= upgradeLvl2Cost) 
            { 
                GameManager.Instance.points -= upgradeLvl2Cost;
                GameManager.Instance.upgradeDamage2Unlocked=true;
                currentDamageLevel = Damage.Level2;
            }
        }
        else
        {
            currentDamageLevel = Damage.Level2;
        }
    }
    public void SetHealthLvl2() {
        if (!GameManager.Instance.upgradeHealth2Unlocked)
        {
            if (GameManager.Instance.points >= upgradeLvl2Cost)
            {
                GameManager.Instance.points -= upgradeLvl2Cost;
                GameManager.Instance.upgradeHealth2Unlocked = true;
                currentHealthLevel = Health.Level2;
            }
        }
        else
        {
            currentHealthLevel = Health.Level2;
        }
    }
    public void SetBoostLevel2() {
        if (!GameManager.Instance.upgradeBoost2Unlocked)
        {
            if (GameManager.Instance.points >= upgradeLvl2Cost)
            {
                GameManager.Instance.points -= upgradeLvl2Cost;
                GameManager.Instance.upgradeBoost2Unlocked = true;
                currentBoostLevel = Boost.Level2;
            }
        }
        else
        {
            currentBoostLevel = Boost.Level2;
        }
    }
    public void SetDamageLvl3() {
        if (GameManager.Instance.upgradeDamage2Unlocked)
        {
            if (!GameManager.Instance.upgradeDamage3Unlocked)
            {
                if (GameManager.Instance.points >= upgradeLvl3Cost)
                {
                    GameManager.Instance.points -= upgradeLvl3Cost;
                    GameManager.Instance.upgradeDamage3Unlocked = true;
                    currentDamageLevel = Damage.Level3;
                }
            }
            else
            {
                currentDamageLevel = Damage.Level3;
            }
        }
    }
    public void SetHealthLvl3() {
        if (GameManager.Instance.upgradeHealth2Unlocked)
        {
            if (!GameManager.Instance.upgradeHealth3Unlocked)
            {
                if (GameManager.Instance.points >= upgradeLvl3Cost)
                {
                    GameManager.Instance.points -= upgradeLvl3Cost;
                    GameManager.Instance.upgradeHealth3Unlocked = true;
                    currentHealthLevel = Health.Level3;
                }
            }
            else
            {
                currentHealthLevel = Health.Level3;
            }
        }
    }
    public void SetBoostLevel3() {
        if (GameManager.Instance.upgradeBoost2Unlocked)
        {
            if (!GameManager.Instance.upgradeBoost3Unlocked)
            {
                if (GameManager.Instance.points >= upgradeLvl3Cost)
                {
                    GameManager.Instance.points -= upgradeLvl3Cost;
                    GameManager.Instance.upgradeBoost3Unlocked = true;
                    currentBoostLevel = Boost.Level3;
                }
            }
            else
            {
                currentBoostLevel = Boost.Level3;
            }
        }
    }

}
