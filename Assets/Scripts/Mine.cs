using UnityEngine;

public class Mine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamageable damageable))
        {
            switch (Difficulty.currentDifficulty)
            {
                case Difficulty.DifficultyMode.Low:
                    damageable.TakeHealthDamage(10);
                    break;
                case Difficulty.DifficultyMode.Medium:
                    damageable.TakeHealthDamage(20);
                    break;
                case Difficulty.DifficultyMode.Hard:
                    damageable.TakeHealthDamage(40);
                    break;
            }
            Destroy(transform.parent.gameObject);

        }

        //if (gameObject.TryGetComponent(out IDamageable damageable1))
        //{
        //    damageable1.TakeHealthDamage(damageReceived);
        //}

    }
}
