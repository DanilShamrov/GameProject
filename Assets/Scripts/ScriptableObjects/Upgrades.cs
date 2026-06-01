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
        Level1 = 100,
        Level2 = 250,
        Level3 = 500
    }

    public static Damage currentDamageLevel = Damage.Level1;
    public static Health currentHealthLevel = Health.Level1;
    public static Boost currentBoostLevel = Boost.Level1;

    public void SetDamageLvl1() { currentDamageLevel = Damage.Level1; }
    public void SetHealthLvl1() { currentHealthLevel = Health.Level1; }
    public void SetBoostLevel1() { currentBoostLevel = Boost.Level1; }
    public void SetDamageLvl2() { currentDamageLevel = Damage.Level2; }
    public void SetHealthLvl2() { currentHealthLevel = Health.Level2; }
    public void SetBoostLevel2() {  currentBoostLevel = Boost.Level2; }
    public void SetDamageLvl3() { currentDamageLevel = Damage.Level3; }
    public void SetHealthLvl3() { currentHealthLevel = Health.Level3; }
    public void SetBoostLevel3() { currentBoostLevel = Boost.Level3; }

}
