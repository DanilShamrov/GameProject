using UnityEngine;

public class EnemyDamageOnCollision : MonoBehaviour
{
    //public BulletData damage;
    //[SerializeField] private int damageDealt = 20;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IDamageable damageable))
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
            
            
        }
        
        //if (gameObject.TryGetComponent(out IDamageable damageable1))
        //{
        //    damageable1.TakeHealthDamage(damageReceived);
        //}

    }
}
