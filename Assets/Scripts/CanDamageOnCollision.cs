using UnityEngine;

public class CanDamageOnCollision : MonoBehaviour
{
    //public BulletData damage;
    [SerializeField] private int damageDealt = 20;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeHealthDamage(damageDealt);
            
        }
        
        //if (gameObject.TryGetComponent(out IDamageable damageable1))
        //{
        //    damageable1.TakeHealthDamage(damageReceived);
        //}

    }
}
