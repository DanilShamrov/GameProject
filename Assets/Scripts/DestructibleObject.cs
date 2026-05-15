using UnityEngine;

public class DestructibleObject : MonoBehaviour, IDamageable
{
    [SerializeField] int maxHealth=100;
    private int currentHealth;
    public void TakeHealthDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name+" "+currentHealth);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
