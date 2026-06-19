using UnityEngine;

public class PlayerDamageOnCollision : MonoBehaviour
{
    //public BulletData damage;
    //[SerializeField] private int damageDealt = 20;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeHealthDamage((int)Upgrades.currentDamageLevel);
        }
        
        //if (gameObject.TryGetComponent(out IDamageable damageable1))
        //{
        //    damageable1.TakeHealthDamage(damageReceived);
        //}

    }
}
