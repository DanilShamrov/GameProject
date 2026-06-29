using UnityEngine;

public class EnemyDamageOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.TryGetComponent(out IDamageable damageable))
        {
            if (gameObject.layer!=11)
            {
                switch (Difficulty.currentDifficulty)
                {
                    case Difficulty.DifficultyMode.Low:
                        damageable.TakeHealthDamage(BulletData.enemyDamageLowDifficulty);
                        break;
                    case Difficulty.DifficultyMode.Medium:
                        damageable.TakeHealthDamage(BulletData.enemyDamageMedDifficulty);
                        break;
                    case Difficulty.DifficultyMode.Hard:
                        damageable.TakeHealthDamage(BulletData.enemyDamageHighDifficulty);
                        break;
                }
                transform.Rotate(new Vector3(0, 0, 180));
            }
        }

    }
}
