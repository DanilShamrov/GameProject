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
}
