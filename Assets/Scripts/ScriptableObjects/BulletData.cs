using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "Scriptable Objects/BulletData")]
public class BulletData : ScriptableObject
{
    public static int enemyDamageLowDifficulty=5;
    public static int enemyDamageMedDifficulty = 10;
    public static int enemyDamageHighDifficulty = 20;
}
